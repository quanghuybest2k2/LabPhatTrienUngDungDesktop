
namespace Lab5
{
    partial class frmMain
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
            this.btnXemJsonFile = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTuoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTonGiao = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXemJsonFile
            // 
            this.btnXemJsonFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXemJsonFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnXemJsonFile.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemJsonFile.ForeColor = System.Drawing.Color.Black;
            this.btnXemJsonFile.Location = new System.Drawing.Point(302, 12);
            this.btnXemJsonFile.Name = "btnXemJsonFile";
            this.btnXemJsonFile.Size = new System.Drawing.Size(177, 74);
            this.btnXemJsonFile.TabIndex = 0;
            this.btnXemJsonFile.Text = "Xem thông tin Sinh viên";
            this.btnXemJsonFile.UseVisualStyleBackColor = false;
            this.btnXemJsonFile.Click += new System.EventHandler(this.btnXemJsonFile_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnXemJsonFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 103);
            this.panel1.TabIndex = 1;
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMSSV,
            this.colHoTen,
            this.colTuoi,
            this.colDiem,
            this.colTonGiao});
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvSinhVien.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(0, 260);
            this.lvSinhVien.MultiSelect = false;
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(800, 190);
            this.lvSinhVien.TabIndex = 2;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            this.colMSSV.Width = 130;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ và tên";
            this.colHoTen.Width = 230;
            // 
            // colTuoi
            // 
            this.colTuoi.Text = "Tuổi";
            this.colTuoi.Width = 130;
            // 
            // colDiem
            // 
            this.colDiem.Text = "Điểm";
            this.colDiem.Width = 130;
            // 
            // colTonGiao
            // 
            this.colTonGiao.Text = "Tôn Giáo";
            this.colTonGiao.Width = 150;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvSinhVien);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sinh viên";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnXemJsonFile;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvSinhVien;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colTuoi;
        private System.Windows.Forms.ColumnHeader colDiem;
        private System.Windows.Forms.ColumnHeader colTonGiao;
    }
}

