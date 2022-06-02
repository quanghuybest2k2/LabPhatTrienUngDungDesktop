using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab3_Demo
{
    public partial class frmTuyChon : Form
    {
        private int i;
        public QuanLySinhVien qlsv;
        public List<SinhVien> sv;
        private TimTheo Loai;
        public frmTuyChon(QuanLySinhVien _qlsv, int _i)
        {
            InitializeComponent();
            i = _i;
            qlsv = _qlsv;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click_1(object sender, EventArgs e)
        {
            if (txtTim.Text == "")
            {
                MessageBox.Show("Hãy nhập thông tin tìm!", "Lỗi nhập thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sv = qlsv.TimKiem(Loai, txtTim.Text);
                if (sv.Count == 0)
                {
                    MessageBox.Show("Không có sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    DialogResult = DialogResult.OK;
                }
            }

        }
        // ẩn những thứ cần ẩn
        private void frmTuyChon_Load(object sender, EventArgs e)
        {
            rdMaSV.Checked = true;
            lblNhapThongTin.Text = rdMaSV.Text;
            if (i==0)
            {
                gbTim.Enabled = false;
                btnSapXep.Enabled = true;
            }
            else
            {
                gbTim.Enabled = true;
                btnSapXep.Enabled = false;
            }
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            qlsv.SapXep(Loai);
            DialogResult = DialogResult.OK;
        }

        private void rdMaSV_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton rdbtn = (RadioButton)sender;
                if (rdbtn.Checked)
                {
                    lblNhapThongTin.Text = rdMaSV.Text;
                    Loai = TimTheo.MaSV;
                }
            }
        }

        private void rdHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton rdbtn = (RadioButton)sender;
                if (rdbtn.Checked)
                {
                    lblNhapThongTin.Text = rdHoTen.Text;
                    Loai = TimTheo.HoTen;
                }
            }
        }

        private void rdNgaySinh_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton)
            {
                RadioButton rdbtn = (RadioButton)sender;
                if (rdbtn.Checked)
                {
                    lblNhapThongTin.Text = rdNgaySinh.Text;
                    Loai = TimTheo.NgaySinh;
                }
            }
        }
    }
}
