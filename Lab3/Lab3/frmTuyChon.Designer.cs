
namespace Lab3_Demo
{
    partial class frmTuyChon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdNgaySinh = new System.Windows.Forms.RadioButton();
            this.rdHoTen = new System.Windows.Forms.RadioButton();
            this.rdMaSV = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.gbTim = new System.Windows.Forms.GroupBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.lblNhapThongTin = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbTimTheo = new System.Windows.Forms.GroupBox();
            this.gbTim.SuspendLayout();
            this.gbTimTheo.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdNgaySinh
            // 
            this.rdNgaySinh.AutoSize = true;
            this.rdNgaySinh.Location = new System.Drawing.Point(384, 40);
            this.rdNgaySinh.Name = "rdNgaySinh";
            this.rdNgaySinh.Size = new System.Drawing.Size(74, 17);
            this.rdNgaySinh.TabIndex = 3;
            this.rdNgaySinh.TabStop = true;
            this.rdNgaySinh.Text = "Ngày Sinh";
            this.rdNgaySinh.UseVisualStyleBackColor = true;
            this.rdNgaySinh.CheckedChanged += new System.EventHandler(this.rdNgaySinh_CheckedChanged);
            // 
            // rdHoTen
            // 
            this.rdHoTen.AutoSize = true;
            this.rdHoTen.Location = new System.Drawing.Point(209, 40);
            this.rdHoTen.Name = "rdHoTen";
            this.rdHoTen.Size = new System.Drawing.Size(61, 17);
            this.rdHoTen.TabIndex = 2;
            this.rdHoTen.TabStop = true;
            this.rdHoTen.Text = "Họ Tên";
            this.rdHoTen.UseVisualStyleBackColor = true;
            this.rdHoTen.CheckedChanged += new System.EventHandler(this.rdHoTen_CheckedChanged);
            // 
            // rdMaSV
            // 
            this.rdMaSV.AutoSize = true;
            this.rdMaSV.Location = new System.Drawing.Point(49, 40);
            this.rdMaSV.Name = "rdMaSV";
            this.rdMaSV.Size = new System.Drawing.Size(57, 17);
            this.rdMaSV.TabIndex = 1;
            this.rdMaSV.TabStop = true;
            this.rdMaSV.Text = "Mã SV";
            this.rdMaSV.UseVisualStyleBackColor = true;
            this.rdMaSV.CheckedChanged += new System.EventHandler(this.rdMaSV_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(291, 249);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.Location = new System.Drawing.Point(125, 249);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(75, 23);
            this.btnSapXep.TabIndex = 6;
            this.btnSapXep.Text = "Sắp xếp";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // gbTim
            // 
            this.gbTim.Controls.Add(this.btnTim);
            this.gbTim.Controls.Add(this.txtTim);
            this.gbTim.Controls.Add(this.lblNhapThongTin);
            this.gbTim.Location = new System.Drawing.Point(12, 123);
            this.gbTim.Name = "gbTim";
            this.gbTim.Size = new System.Drawing.Size(522, 98);
            this.gbTim.TabIndex = 1;
            this.gbTim.TabStop = false;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(384, 35);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(75, 23);
            this.btnTim.TabIndex = 5;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click_1);
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(132, 37);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(232, 20);
            this.txtTim.TabIndex = 4;
            // 
            // lblNhapThongTin
            // 
            this.lblNhapThongTin.AutoSize = true;
            this.lblNhapThongTin.Location = new System.Drawing.Point(29, 40);
            this.lblNhapThongTin.Name = "lblNhapThongTin";
            this.lblNhapThongTin.Size = new System.Drawing.Size(77, 13);
            this.lblNhapThongTin.TabIndex = 2;
            this.lblNhapThongTin.Text = "Nhập thông tin";
            // 
            // gbTimTheo
            // 
            this.gbTimTheo.Controls.Add(this.rdNgaySinh);
            this.gbTimTheo.Controls.Add(this.rdMaSV);
            this.gbTimTheo.Controls.Add(this.rdHoTen);
            this.gbTimTheo.Location = new System.Drawing.Point(12, 13);
            this.gbTimTheo.Name = "gbTimTheo";
            this.gbTimTheo.Size = new System.Drawing.Size(522, 100);
            this.gbTimTheo.TabIndex = 8;
            this.gbTimTheo.TabStop = false;
            // 
            // frmTuyChon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 284);
            this.Controls.Add(this.gbTimTheo);
            this.Controls.Add(this.gbTim);
            this.Controls.Add(this.btnSapXep);
            this.Controls.Add(this.btnThoat);
            this.Name = "frmTuyChon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chọn";
            this.Load += new System.EventHandler(this.frmTuyChon_Load);
            this.gbTim.ResumeLayout(false);
            this.gbTim.PerformLayout();
            this.gbTimTheo.ResumeLayout(false);
            this.gbTimTheo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdNgaySinh;
        private System.Windows.Forms.RadioButton rdHoTen;
        private System.Windows.Forms.RadioButton rdMaSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.GroupBox gbTim;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblNhapThongTin;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.GroupBox gbTimTheo;
    }
}