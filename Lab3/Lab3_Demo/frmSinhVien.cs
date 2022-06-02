using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace Lab3_Demo
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv;
     
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        #region Phương thức bổ trợ 
        //Lấy thông tin từ controls thông tin SV
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = this.mtxtMaSo.Text;
            sv.HoTen = this.txtHoTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.DiaChi = this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh = CreateFileName(Path.GetFileName(this.txtHinh.Text));
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                if (clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
            sv.ChuyenNganh = cn;

            return sv;
        }
        //Lấy thông tin sinh viên từ dòng item của ListView
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if (lvitem.SubItems[5].Text == "Nam")
                sv.GioiTinh = true;
            List<string> cn = new List<string>();
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach (string t in s)
                cn.Add(t);
            sv.ChuyenNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }
        //Thiết lập các thông tin lên controls sinh viên
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyenNganh)
            {
                for (int i = 0; i < this.clbChuyenNganh.Items.Count;
                i++)
                    if
                    (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                        this.clbChuyenNganh.SetItemChecked(i,
                        true);
            }
        }
        //Thêm sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MaSo);
            lvitem.SubItems.Add(sv.HoTen);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvitem.SubItems.Add(sv.DiaChi);
            lvitem.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyenNganh)
                cn += s + ",";
            cn = cn.Substring(0, cn.Length - 1);
            lvitem.SubItems.Add(cn);
            lvitem.SubItems.Add(sv.Hinh);
            //them vao listview
            lvSinhVien.Items.Add(lvitem);
        }
        //Hiển thị các sinh viên trong qlsv lên ListView
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
                stastriplTongSV.Text = "Tổng số sinh viên: " + lvSinhVien.Items.Count.ToString();
            }
           
        }
        #endregion


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        #region Các sự kiện
        //sự kiện Load form
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }
        //Khi chọn dòng sinh viên bên ListView
        //thực hiện gán thông tin lên các control
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }// tra ve thoi gian tao tam hinh, cap nhat ten file
        private string CreateFileName(string FileName)
        {
            DateTime dt = DateTime.Now;
            string ext = FileName.Substring(FileName.LastIndexOf("."));
            return dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString() + ext; 
        }
        private void LuuFile()
        {
            string path = Application.StartupPath + "\\Data.txt";
            FileStream fs = new FileStream(path, FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            string Phai = "";
            if (rdNam.Checked)
            {
                Phai = "1";
            }
            else
            {
                Phai = "0";
            }
            sw.WriteLine(mtxtMaSo.Text + "*" + txtHoTen.Text + "*" + Phai + "*" + dtpNgaySinh.Value.ToShortDateString().ToString() + "*" + cboLop.Text + "*" + clbChuyenNganh.Items[0] + "*" + txtDiaChi.Text + "*" + Path.GetFileName(txtHinh.Text));
            sw.Close();
        }
        //Chức năng thêm sinh viên
        private void btnThem_Click(object sender, EventArgs e)
        {
            string filePathDes = Application.StartupPath; 
            SinhVien sv = GetSinhVien();
            File.Copy(txtHinh.Text, filePathDes + "\\" + CreateFileName(Path.GetFileName(txtHinh.Text)),true);
            SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
                this.LuuFile();
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            if (result == DialogResult.Yes)
                Application.Exit();
        }
        //Xóa tất cả sinh viên được chọn trên ListView
        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            LoadListView();
            btnMacDinh.PerformClick();
        }
        //Để các control ở giá trị mặc định
        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            mtxtMaSo.Text = "";
            txtHoTen.Text = "";
            dtpNgaySinh.Value = DateTime.Now;
            txtDiaChi.Text = "";
            cboLop.Text = cboLop.Items[0].ToString();
            txtHinh.Text = "";
            pbHinh.ImageLocation = "";
            rdNam.Checked = true;
            for (int i = 0; i < clbChuyenNganh.Items.Count-1; i++)
            {
                clbChuyenNganh.SetItemChecked(i,false);
            }
        }
        //Sửa thông tin sinh viên được chọn
        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqSua;
            kqSua = qlsv.Sua(sv,sv.MaSo, SoSanhTheoMa);
            if (kqSua)
            {
                LoadListView();
            }
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MaSo.CompareTo(obj1);
        }
        // click chon anh
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File(*.bmp; *.jpg; *.png;)|*.bmp; *.jpg; *.png;";
            open.Title = "Open File Image";
            if (open.ShowDialog()==DialogResult.OK)
            {
                txtHinh.Text = open.FileName;
                //txtHinh.Text = Path.GetFileName(open.FileName); // chỉ nhận fileName, không đường dẫn
                pbHinh.Image = new Bitmap(open.FileName);
            }
        }
        #endregion

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsmiTimKiem_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon();
            frm.ShowDialog();
        }

        private void tsmiSapXep_Click(object sender, EventArgs e)
        {
            frmTuyChon frm = new frmTuyChon();
            frm.ShowDialog();
            
        }
    }
}
