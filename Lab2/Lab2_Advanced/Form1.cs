using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Advanced
{
    public partial class frmGiaoVien : Form
    {
        public frmGiaoVien()
        {
            InitializeComponent();
        }

        private void lbldanhsachmonhoc_Click(object sender, EventArgs e)
        {

        }

        private void lblWebsite_Click(object sender, EventArgs e)
        {

        }

        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "http://cntt.dlu.edu.vn";
            this.linklbLienHe.Links.Add(0, lienhe.Length, lienhe);
            for (int i = 1; i <= 5; i++)
            {
                this.cboMaSo.SelectedItem = this.cboMaSo.Items.Add("00"+i);
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachMH.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMonHocDay.Items.Add(lbDanhSachMH.SelectedItems[i]);
                this.lbDanhSachMH.Items.Remove(lbDanhSachMH.SelectedItems[i]);
                i--;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMonHocDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachMH.Items.Add(lbMonHocDay.SelectedItems[i]);
                this.lbMonHocDay.Items.Remove(lbMonHocDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;
            // bỏ chọn trên check lable ngoại ngữ
            for (int i = 0; i < chklbNgoaiNgu.Items.Count-1; i++)
            {
                chklbNgoaiNgu.SetItemChecked(i, false);
            }
            //chuyển các môn từ lbmonday sang dsmonhoc
            foreach (object ob in this.lbMonHocDay.Items)
            {
                this.lbDanhSachMH.Items.Add(ob);
            }
            this.lbMonHocDay.Items.Clear();
        }

        private void linklbLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien frm = new frmTBGiaoVien();
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }
        private GiaoVien GetGiaoVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
            {
                gt = "Nữ";
            }
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;
            // lấy thông tin ngoại ngữ
            string ngoaingu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count-1; i++)
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
            gv.NgoaiNgu = ngoaingu.Split(';');

            // lay thong tin danh sach mon hoc
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in lbMonHocDay.Items)
                mh.Them(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;

            return gv;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo);

            if (Result == DialogResult.No)
            {
                return;
            }
            if (Result == DialogResult.Yes)
            {
                Application.Exit();
                //this.Close();
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
        
       
        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimGiaoVien frmGV = new frmTimGiaoVien();
            frmGV.ShowDialog();
            
        }
    }
}
