namespace MainProgram.Forms
{
    partial class frmThemPhong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaphong = new System.Windows.Forms.TextBox();
            this.btnEscape = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.txtDodac = new System.Windows.Forms.TextBox();
            this.lblDodac = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblGia = new System.Windows.Forms.Label();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.lblTinhtrang = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.lblLoai = new System.Windows.Forms.Label();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.lblDientich = new System.Windows.Forms.Label();
            this.lblMaphong = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtMaphong);
            this.panel1.Controls.Add(this.btnEscape);
            this.panel1.Controls.Add(this.btnSignup);
            this.panel1.Controls.Add(this.txtDodac);
            this.panel1.Controls.Add(this.lblDodac);
            this.panel1.Controls.Add(this.txtGia);
            this.panel1.Controls.Add(this.lblGia);
            this.panel1.Controls.Add(this.txtTinhTrang);
            this.panel1.Controls.Add(this.lblTinhtrang);
            this.panel1.Controls.Add(this.txtLoaiPhong);
            this.panel1.Controls.Add(this.lblLoai);
            this.panel1.Controls.Add(this.txtDienTich);
            this.panel1.Controls.Add(this.lblDientich);
            this.panel1.Controls.Add(this.lblMaphong);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 351);
            this.panel1.TabIndex = 0;
            // 
            // txtMaphong
            // 
            this.txtMaphong.Location = new System.Drawing.Point(190, 39);
            this.txtMaphong.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaphong.Name = "txtMaphong";
            this.txtMaphong.Size = new System.Drawing.Size(247, 22);
            this.txtMaphong.TabIndex = 26;
            // 
            // btnEscape
            // 
            this.btnEscape.Location = new System.Drawing.Point(446, 275);
            this.btnEscape.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(213, 38);
            this.btnEscape.TabIndex = 25;
            this.btnEscape.Text = "Thoát";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(190, 275);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(209, 38);
            this.btnSignup.TabIndex = 24;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // txtDodac
            // 
            this.txtDodac.Location = new System.Drawing.Point(190, 171);
            this.txtDodac.Margin = new System.Windows.Forms.Padding(4);
            this.txtDodac.Multiline = true;
            this.txtDodac.Name = "txtDodac";
            this.txtDodac.Size = new System.Drawing.Size(469, 59);
            this.txtDodac.TabIndex = 23;
            // 
            // lblDodac
            // 
            this.lblDodac.AutoSize = true;
            this.lblDodac.Location = new System.Drawing.Point(52, 176);
            this.lblDodac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDodac.Name = "lblDodac";
            this.lblDodac.Size = new System.Drawing.Size(107, 17);
            this.lblDodac.TabIndex = 22;
            this.lblDodac.Text = "Đồ đạc có sẵn: ";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(190, 140);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(247, 22);
            this.txtGia.TabIndex = 21;
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Location = new System.Drawing.Point(52, 142);
            this.lblGia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(125, 17);
            this.lblGia.TabIndex = 20;
            this.lblGia.Text = "Giá phòng (VNĐ): ";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.Location = new System.Drawing.Point(190, 104);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Size = new System.Drawing.Size(247, 22);
            this.txtTinhTrang.TabIndex = 19;
            // 
            // lblTinhtrang
            // 
            this.lblTinhtrang.AutoSize = true;
            this.lblTinhtrang.Location = new System.Drawing.Point(52, 109);
            this.lblTinhtrang.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTinhtrang.Name = "lblTinhtrang";
            this.lblTinhtrang.Size = new System.Drawing.Size(81, 17);
            this.lblTinhtrang.TabIndex = 18;
            this.lblTinhtrang.Text = "Tình trạng: ";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.Location = new System.Drawing.Point(446, 71);
            this.txtLoaiPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.Size = new System.Drawing.Size(213, 22);
            this.txtLoaiPhong.TabIndex = 17;
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Location = new System.Drawing.Point(354, 76);
            this.lblLoai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(83, 17);
            this.lblLoai.TabIndex = 16;
            this.lblLoai.Text = "Loại phòng:";
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(190, 71);
            this.txtDienTich.Margin = new System.Windows.Forms.Padding(4);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(155, 22);
            this.txtDienTich.TabIndex = 15;
            // 
            // lblDientich
            // 
            this.lblDientich.AutoSize = true;
            this.lblDientich.Location = new System.Drawing.Point(52, 76);
            this.lblDientich.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDientich.Name = "lblDientich";
            this.lblDientich.Size = new System.Drawing.Size(104, 17);
            this.lblDientich.TabIndex = 14;
            this.lblDientich.Text = "Diện tích (m2): ";
            // 
            // lblMaphong
            // 
            this.lblMaphong.AutoSize = true;
            this.lblMaphong.Location = new System.Drawing.Point(52, 44);
            this.lblMaphong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaphong.Name = "lblMaphong";
            this.lblMaphong.Size = new System.Drawing.Size(79, 17);
            this.lblMaphong.TabIndex = 12;
            this.lblMaphong.Text = "Mã phòng: ";
            // 
            // frmThemPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 351);
            this.Controls.Add(this.panel1);
            this.Name = "frmThemPhong";
            this.Text = "ThemPhong";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDodac;
        private System.Windows.Forms.Label lblDodac;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.TextBox txtTinhTrang;
        private System.Windows.Forms.Label lblTinhtrang;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Label lblDientich;
        private System.Windows.Forms.Label lblMaphong;
        private System.Windows.Forms.TextBox txtMaphong;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Button btnSignup;
    }
}