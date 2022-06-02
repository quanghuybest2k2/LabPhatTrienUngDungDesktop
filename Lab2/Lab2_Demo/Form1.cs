﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_Demo
{
    public partial class frmTrungTam : Form
    {
        public frmTrungTam()
        {
            InitializeComponent();
        }

        private void lblTongTien_Click(object sender, EventArgs e)
        {

        }

        private void lblTinhTienHocTT_Click(object sender, EventArgs e)
        {

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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }
        // Function reset all values
        private void Reset()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDangKy.Value = DateTime.Now;
            this.rdNam.Checked = true;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int s = 0;
            if (chkTinHocA.Checked)
            {
                s += int.Parse(lblTienTHA.Text.Split('.')[0]);
            }
            if (chkTinHocB.Checked)
            {
                s += int.Parse(lblTienTHB.Text.Split('.')[0]);
            }
            if (chkTiengAnhA.Checked)
            {
                s += int.Parse(lblTienTAA.Text.Split('.')[0]);
            }
            if (chkTiengAnhB.Checked)
            {
                s += int.Parse(lblTienTAB.Text.Split('.')[0]);
            }
            this.txtTongTien.Text = s + ".000 đồng";
        }
    }
}
