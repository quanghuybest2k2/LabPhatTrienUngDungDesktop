using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Advanced
{
    public partial class frmTimGiaoVien : Form
    {
        QuanLyGiaoVien qlgv;
        public frmTimGiaoVien()
        {
            InitializeComponent();
            
        }
        private int SoSanhTheoMa(object obj1, object obj2)
        {
            GiaoVien sv = obj2 as GiaoVien;
            return sv.MaSo.CompareTo(obj1);
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            GiaoVien kq = qlgv.Tim(gv.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as GiaoVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
            {
                MessageBox.Show("Mã sinh viên đã tồn tại!", "Lỗi thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
            }
        }
    }
}
