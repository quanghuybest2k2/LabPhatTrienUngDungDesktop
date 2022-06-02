using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab4
{
    public partial class frmSinhVien : Form
    {
        DanhSachSinhVien dssv;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result==DialogResult.Cancel)
            {
                return;
            }
            if (result == DialogResult.OK)
            {

                Application.Exit();
            }
        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        private void Reset()
        {
            this.txtMSSV.Text = "";
            this.txtHoTen.Text = "";
            this.rdNam.Checked = true;// gt Nam
            this.dtpNgaySinh.Value = DateTime.Now;
            this.cbbLop.SelectedIndex = 0;
            this.mtxtSDT.Text = "";
            this.txtDiaChi.Text = "";
            this.txtEmail.Text = "";
            this.txtHinh.Text = "";
            this.pbHinh.ImageLocation = "";
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image File(*.bmp; *.jpg; *.png;)|*.bmp; *.jpg; *.png;";
            open.Title = "Mở hình";
            if (open.ShowDialog()==DialogResult.OK)
            {
                txtHinh.Text =  open.FileName;
                pbHinh.Image = new Bitmap(open.FileName);
            }
        }
        private void LoadValueDefault()
        {
            txtMSSV.Text = "2015597";
            txtHoTen.Text = "Đoàn Quang Huy";
            txtEmail.Text = "quanghuybest@gmail.com";
            txtDiaChi.Text = "Ninh Thuận";
            cbbLop.SelectedIndex = 0;
            mtxtSDT.Text = "1111.222.333";
        }
        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            dssv = new DanhSachSinhVien();
            dssv.DocFile();
            LoadValueDefault();
            LoadListView();
        }
        // tạo tên hình ảnh, tránh bị trùng
        private string CreateFileName(string FileName)
        {
            DateTime dt = new DateTime();
            string ext = FileName.Substring(FileName.LastIndexOf("."));
            return dt.Year.ToString() + dt.Month.ToString() + dt.Day.ToString() + dt.Hour.ToString() + dt.Minute.ToString() + dt.Second.ToString() + ext;
        }
        private SinhVien GetSinhVien()
        {
            SinhVien sv = new SinhVien();
            //gắn các thuộc tính của sinh viên cho các controls
            sv.MSSV = txtMSSV.Text;
            sv.HoTen = txtHoTen.Text;
            bool gt = true; // gt Nam
            if (rdNu.Checked)
                gt = false;
            sv.NgaySinh = dtpNgaySinh.Value;
            sv.Lop = cbbLop.Text;
            sv.SDT = mtxtSDT.Text;
            sv.Email = txtEmail.Text;
            sv.DiaChi = txtDiaChi.Text;
            sv.Hinh = CreateFileName(Path.GetFileName(txtHinh.Text));
            //
            return sv;
        }
        //Thêm sinh viên vào ListView
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lvItem = new ListViewItem(sv.MSSV);
            lvItem.SubItems.Add(sv.HoTen);
            string gt = "Nữ";
            if (sv.Phai)
            {
                gt = "Nam";
            }
            lvItem.SubItems.Add(gt);
            lvItem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            lvItem.SubItems.Add(sv.Lop);
            lvItem.SubItems.Add(sv.SDT);
            lvItem.SubItems.Add(sv.Email);
            lvItem.SubItems.Add(sv.DiaChi);
            lvItem.SubItems.Add(sv.Hinh);
            lvSinhVien.Items.Add(lvItem);// add vào
        }
        //Đổ dữ liệu lên listview
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach (SinhVien sv in dssv.DanhSach)
            {
                ThemSV(sv);
                tsslTongSV.Text = "Tổng số sinh viên: " + lvSinhVien.Items.Count.ToString();
            }

        }
        // Copy file vao file txt
        private void LuuFile()
        {
            string path = Application.StartupPath + "\\DSSV.txt";
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
            sw.WriteLine(txtMSSV.Text + "*" + txtHoTen.Text + "*" + Phai + "*" + dtpNgaySinh.Value.ToShortDateString().ToString() + "*" + cbbLop.Text + "*" + mtxtSDT.Text + "*" + txtEmail.Text + "*" + txtDiaChi.Text + "*" + Path.GetFileName(txtHinh.Text));
            sw.Close();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string filePathDes = Application.StartupPath;
            SinhVien sv = GetSinhVien();
            File.Copy(txtHinh.Text, filePathDes + "\\" + CreateFileName(Path.GetFileName(txtHinh.Text)), true);
            SinhVien kq = dssv.Tim(sv.MSSV, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MSSV.CompareTo(obj1.ToString());
            });
            if (kq!=null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.dssv.Them(sv);
                this.LoadListView();
                this.LuuFile();
            }
            if (sv.MSSV==txtMSSV.Text)
            {
                bool kqSua;
                kqSua = dssv.Sua(sv, sv.MSSV, SoSanhTheoMa);
                if (kqSua)
                {
                    LoadListView();
                }
            }
        }
        // so sanh theo ma
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.MSSV.CompareTo(obj1);

        }
        // so sanh theo ho ten
        private int SoSanhTheoHoTen(object obj1, object obj2)
        {
            SinhVien sv = obj2 as SinhVien;
            return sv.HoTen.CompareTo(obj1);

        }
        private SinhVien GetSinhVienLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.Phai = false;
            if (lvitem.SubItems[2].Text == "Nam")
                sv.Phai = true;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.Lop = lvitem.SubItems[4].Text;
            sv.SDT = lvitem.SubItems[5].Text;
            sv.Email = lvitem.SubItems[6].Text;
            sv.DiaChi = lvitem.SubItems[7].Text;
            sv.Hinh = lvitem.SubItems[8].Text;
            return sv;
        }
        private void ThietLapThongTin(SinhVien sv)
        {
            this.txtMSSV.Text = sv.MSSV;
            this.txtHoTen.Text = sv.HoTen;
            if (sv.Phai)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cbbLop.Text = sv.Lop;
            this.mtxtSDT.Text = sv.SDT;
            this.txtEmail.Text = sv.Email;
            this.txtDiaChi.Text = sv.DiaChi;
            this.txtHinh.Text = sv.Hinh;
            this.pbHinh.ImageLocation = sv.Hinh;
            
        }
        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            //click vào thì hiện lên trên input
            int count = this.lvSinhVien.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0];
                SinhVien sv = GetSinhVienLV(lvitem);
                ThietLapThongTin(sv);
            }
        }
    }
}
