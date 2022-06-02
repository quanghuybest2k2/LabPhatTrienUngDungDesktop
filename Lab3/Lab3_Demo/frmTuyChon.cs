using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Lab3_Demo
{
    public partial class frmTuyChon : Form
    {
        enum TuyChon
        {
            MaSV,
            HoTen,
            NgaySinh
        }
        public frmTuyChon()
        {
            InitializeComponent();
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

        }
        // ẩn những thứ cần ẩn
        private void frmTuyChon_Load(object sender, EventArgs e)
        {
           
        }

        private void txtTim_TextChanged(object sender, EventArgs e)
        {
            //if (txtTim.Text != "")
            //{
            //    for (int i = lvSinhVien.Items.Count - 1; i >= 0; i--)
            //    {
            //        var item = lvSinhVien.Items[i];
            //        if (item.Text.ToLower().Contains(txtTim.Text.ToLower()))
            //        {
            //            item.BackColor = SystemColors.Highlight;
            //            item.ForeColor = SystemColors.HighlightText;
            //        }
            //        else
            //        {
            //            lvSinhVien.Items.Remove(item);
            //        }
            //    }
            //    if (lvSinhVien.SelectedItems.Count == 1)
            //    {
            //        lvSinhVien.Focus();
            //    }
            //}
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            
        }
    }
}
