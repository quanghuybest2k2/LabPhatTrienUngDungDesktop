
namespace Lab4
{
    partial class frmSinhVien
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
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.lblMSSV = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblHinh = new System.Windows.Forms.Label();
            this.gbThongTinSV = new System.Windows.Forms.GroupBox();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.cbbLop = new System.Windows.Forms.ComboBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblPhai = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.gbDSSinhVien = new System.Windows.Forms.GroupBox();
            this.statusStripTongSV = new System.Windows.Forms.StatusStrip();
            this.tsslTongSV = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.gbThongTinSV.SuspendLayout();
            this.gbDSSinhVien.SuspendLayout();
            this.statusStripTongSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbHinh
            // 
            this.pbHinh.Location = new System.Drawing.Point(12, 22);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(144, 204);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 0;
            this.pbHinh.TabStop = false;
            // 
            // lblMSSV
            // 
            this.lblMSSV.AutoSize = true;
            this.lblMSSV.Location = new System.Drawing.Point(23, 34);
            this.lblMSSV.Name = "lblMSSV";
            this.lblMSSV.Size = new System.Drawing.Size(37, 13);
            this.lblMSSV.TabIndex = 0;
            this.lblMSSV.Text = "MSSV";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(23, 69);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(58, 13);
            this.lblHoTen.TabIndex = 0;
            this.lblHoTen.Text = "Họ và Tên";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(23, 105);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(23, 136);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(41, 13);
            this.lblDiaChi.TabIndex = 0;
            this.lblDiaChi.Text = "Địa Chỉ";
            // 
            // lblHinh
            // 
            this.lblHinh.AutoSize = true;
            this.lblHinh.Location = new System.Drawing.Point(23, 166);
            this.lblHinh.Name = "lblHinh";
            this.lblHinh.Size = new System.Drawing.Size(29, 13);
            this.lblHinh.TabIndex = 0;
            this.lblHinh.Text = "Hình";
            // 
            // gbThongTinSV
            // 
            this.gbThongTinSV.Controls.Add(this.lblThongBao);
            this.gbThongTinSV.Controls.Add(this.btnThoat);
            this.gbThongTinSV.Controls.Add(this.btnLuu);
            this.gbThongTinSV.Controls.Add(this.btnMacDinh);
            this.gbThongTinSV.Controls.Add(this.mtxtSDT);
            this.gbThongTinSV.Controls.Add(this.cbbLop);
            this.gbThongTinSV.Controls.Add(this.rdNu);
            this.gbThongTinSV.Controls.Add(this.rdNam);
            this.gbThongTinSV.Controls.Add(this.dtpNgaySinh);
            this.gbThongTinSV.Controls.Add(this.btnChonHinh);
            this.gbThongTinSV.Controls.Add(this.txtHinh);
            this.gbThongTinSV.Controls.Add(this.txtDiaChi);
            this.gbThongTinSV.Controls.Add(this.txtEmail);
            this.gbThongTinSV.Controls.Add(this.txtHoTen);
            this.gbThongTinSV.Controls.Add(this.txtMSSV);
            this.gbThongTinSV.Controls.Add(this.lblSDT);
            this.gbThongTinSV.Controls.Add(this.lblLop);
            this.gbThongTinSV.Controls.Add(this.lblPhai);
            this.gbThongTinSV.Controls.Add(this.lblNgaySinh);
            this.gbThongTinSV.Controls.Add(this.lblMSSV);
            this.gbThongTinSV.Controls.Add(this.lblHinh);
            this.gbThongTinSV.Controls.Add(this.lblHoTen);
            this.gbThongTinSV.Controls.Add(this.lblDiaChi);
            this.gbThongTinSV.Controls.Add(this.lblEmail);
            this.gbThongTinSV.Location = new System.Drawing.Point(162, 12);
            this.gbThongTinSV.Name = "gbThongTinSV";
            this.gbThongTinSV.Size = new System.Drawing.Size(626, 229);
            this.gbThongTinSV.TabIndex = 2;
            this.gbThongTinSV.TabStop = false;
            this.gbThongTinSV.Text = "Thông tin sinh viên";
            // 
            // lblThongBao
            // 
            this.lblThongBao.AutoSize = true;
            this.lblThongBao.Location = new System.Drawing.Point(214, 15);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(59, 13);
            this.lblThongBao.TabIndex = 14;
            this.lblThongBao.Text = "Thông báo";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(483, 200);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(357, 200);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(239, 200);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(75, 23);
            this.btnMacDinh.TabIndex = 10;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(446, 133);
            this.mtxtSDT.Mask = "1111.222.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(174, 20);
            this.mtxtSDT.TabIndex = 8;
            // 
            // cbbLop
            // 
            this.cbbLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLop.FormattingEnabled = true;
            this.cbbLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
            this.cbbLop.Location = new System.Drawing.Point(446, 101);
            this.cbbLop.Name = "cbbLop";
            this.cbbLop.Size = new System.Drawing.Size(174, 21);
            this.cbbLop.TabIndex = 7;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(519, 67);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 6;
            this.rdNu.TabStop = true;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Location = new System.Drawing.Point(452, 67);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/mm/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(446, 34);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(174, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(519, 161);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(75, 23);
            this.btnChonHinh.TabIndex = 9;
            this.btnChonHinh.Text = "Chọn Hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // txtHinh
            // 
            this.txtHinh.Enabled = false;
            this.txtHinh.Location = new System.Drawing.Point(107, 163);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.Size = new System.Drawing.Size(392, 20);
            this.txtHinh.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(107, 133);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(207, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 102);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(207, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(107, 69);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(107, 34);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(207, 20);
            this.txtMSSV.TabIndex = 0;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(354, 136);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(70, 13);
            this.lblSDT.TabIndex = 0;
            this.lblSDT.Text = "Số điện thoại";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(354, 105);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(25, 13);
            this.lblLop.TabIndex = 0;
            this.lblLop.Text = "Lớp";
            // 
            // lblPhai
            // 
            this.lblPhai.AutoSize = true;
            this.lblPhai.Location = new System.Drawing.Point(354, 69);
            this.lblPhai.Name = "lblPhai";
            this.lblPhai.Size = new System.Drawing.Size(28, 13);
            this.lblPhai.TabIndex = 0;
            this.lblPhai.Text = "Phái";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(354, 37);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(54, 13);
            this.lblNgaySinh.TabIndex = 0;
            this.lblNgaySinh.Text = "Ngày sinh";
            // 
            // gbDSSinhVien
            // 
            this.gbDSSinhVien.Controls.Add(this.statusStripTongSV);
            this.gbDSSinhVien.Controls.Add(this.lvSinhVien);
            this.gbDSSinhVien.Location = new System.Drawing.Point(12, 247);
            this.gbDSSinhVien.Name = "gbDSSinhVien";
            this.gbDSSinhVien.Size = new System.Drawing.Size(776, 176);
            this.gbDSSinhVien.TabIndex = 0;
            this.gbDSSinhVien.TabStop = false;
            this.gbDSSinhVien.Text = "Danh sách sinh viên";
            // 
            // statusStripTongSV
            // 
            this.statusStripTongSV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTongSV});
            this.statusStripTongSV.Location = new System.Drawing.Point(3, 151);
            this.statusStripTongSV.Name = "statusStripTongSV";
            this.statusStripTongSV.Size = new System.Drawing.Size(770, 22);
            this.statusStripTongSV.TabIndex = 1;
            this.statusStripTongSV.Text = "statusStrip1";
            // 
            // tsslTongSV
            // 
            this.tsslTongSV.Name = "tsslTongSV";
            this.tsslTongSV.Size = new System.Drawing.Size(84, 17);
            this.tsslTongSV.Text = "Tổng sinh viên";
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colHoTen,
            this.colPhai,
            this.colNgaySinh,
            this.colLop,
            this.colSDT,
            this.colEmail,
            this.colDiaChi,
            this.colHinh});
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.FullRowSelect = true;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 16);
            this.lvSinhVien.MultiSelect = false;
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(770, 157);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ và tên";
            // 
            // colPhai
            // 
            this.colPhai.Text = "Phái";
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            // 
            // colLop
            // 
            this.colLop.Text = "Lớp";
            // 
            // colSDT
            // 
            this.colSDT.Text = "Số điện thoại";
            // 
            // colEmail
            // 
            this.colEmail.Text = "Email";
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            // 
            // colHinh
            // 
            this.colHinh.Text = "Hình";
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 429);
            this.Controls.Add(this.gbDSSinhVien);
            this.Controls.Add(this.gbThongTinSV);
            this.Controls.Add(this.pbHinh);
            this.Name = "frmSinhVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin sinh viên khoa CNTT";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.gbThongTinSV.ResumeLayout(false);
            this.gbThongTinSV.PerformLayout();
            this.gbDSSinhVien.ResumeLayout(false);
            this.gbDSSinhVien.PerformLayout();
            this.statusStripTongSV.ResumeLayout(false);
            this.statusStripTongSV.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.Label lblMSSV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHinh;
        private System.Windows.Forms.GroupBox gbThongTinSV;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblPhai;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.ComboBox cbbLop;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.GroupBox gbDSSinhVien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colPhai;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colLop;
        private System.Windows.Forms.ColumnHeader colSDT;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colHinh;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.StatusStrip statusStripTongSV;
        private System.Windows.Forms.ToolStripStatusLabel tsslTongSV;
        private System.Windows.Forms.Label lblThongBao;
    }
}

