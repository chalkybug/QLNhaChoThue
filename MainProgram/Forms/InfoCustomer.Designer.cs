namespace MainProgram.Forms
{
    partial class frmInfoCustomer
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
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtQuequan = new System.Windows.Forms.TextBox();
            this.lblQuequan = new System.Windows.Forms.Label();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.grbGioitinh = new System.Windows.Forms.GroupBox();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.lblGioitinh = new System.Windows.Forms.Label();
            this.txtNamsinh = new System.Windows.Forms.TextBox();
            this.lblNamsinh = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.lblHoten = new System.Windows.Forms.Label();
            this.txtMakhach = new System.Windows.Forms.TextBox();
            this.lblMaKhach = new System.Windows.Forms.Label();
            this.btnEscape = new System.Windows.Forms.Button();
            this.btnSignup = new System.Windows.Forms.Button();
            this.grbGioitinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(233, 241);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(280, 22);
            this.txtSDT.TabIndex = 27;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(60, 244);
            this.lblSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(99, 17);
            this.lblSDT.TabIndex = 26;
            this.lblSDT.Text = "Số điện thoại: ";
            // 
            // txtQuequan
            // 
            this.txtQuequan.Location = new System.Drawing.Point(233, 207);
            this.txtQuequan.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuequan.Name = "txtQuequan";
            this.txtQuequan.Size = new System.Drawing.Size(280, 22);
            this.txtQuequan.TabIndex = 25;
            // 
            // lblQuequan
            // 
            this.lblQuequan.AutoSize = true;
            this.lblQuequan.Location = new System.Drawing.Point(60, 211);
            this.lblQuequan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuequan.Name = "lblQuequan";
            this.lblQuequan.Size = new System.Drawing.Size(79, 17);
            this.lblQuequan.TabIndex = 24;
            this.lblQuequan.Text = "Quê quán: ";
            // 
            // txtCMND
            // 
            this.txtCMND.Location = new System.Drawing.Point(233, 173);
            this.txtCMND.Margin = new System.Windows.Forms.Padding(4);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(280, 22);
            this.txtCMND.TabIndex = 23;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(60, 177);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(77, 17);
            this.lblCMND.TabIndex = 22;
            this.lblCMND.Text = "Số CMND: ";
            // 
            // grbGioitinh
            // 
            this.grbGioitinh.Controls.Add(this.rdbNu);
            this.grbGioitinh.Controls.Add(this.rdbNam);
            this.grbGioitinh.Location = new System.Drawing.Point(233, 138);
            this.grbGioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.grbGioitinh.Name = "grbGioitinh";
            this.grbGioitinh.Padding = new System.Windows.Forms.Padding(4);
            this.grbGioitinh.Size = new System.Drawing.Size(281, 30);
            this.grbGioitinh.TabIndex = 21;
            this.grbGioitinh.TabStop = false;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Location = new System.Drawing.Point(116, 2);
            this.rdbNu.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(47, 21);
            this.rdbNu.TabIndex = 1;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Checked = true;
            this.rdbNam.Location = new System.Drawing.Point(0, 2);
            this.rdbNam.Margin = new System.Windows.Forms.Padding(4);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(58, 21);
            this.rdbNam.TabIndex = 0;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            // 
            // lblGioitinh
            // 
            this.lblGioitinh.AutoSize = true;
            this.lblGioitinh.Location = new System.Drawing.Point(60, 143);
            this.lblGioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGioitinh.Name = "lblGioitinh";
            this.lblGioitinh.Size = new System.Drawing.Size(68, 17);
            this.lblGioitinh.TabIndex = 20;
            this.lblGioitinh.Text = "Giới tính: ";
            // 
            // txtNamsinh
            // 
            this.txtNamsinh.Location = new System.Drawing.Point(233, 106);
            this.txtNamsinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtNamsinh.Name = "txtNamsinh";
            this.txtNamsinh.Size = new System.Drawing.Size(123, 22);
            this.txtNamsinh.TabIndex = 19;
            // 
            // lblNamsinh
            // 
            this.lblNamsinh.AutoSize = true;
            this.lblNamsinh.Location = new System.Drawing.Point(60, 110);
            this.lblNamsinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNamsinh.Name = "lblNamsinh";
            this.lblNamsinh.Size = new System.Drawing.Size(75, 17);
            this.lblNamsinh.TabIndex = 18;
            this.lblNamsinh.Text = "Năm sinh: ";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(233, 73);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(4);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(360, 22);
            this.txtHoten.TabIndex = 17;
            // 
            // lblHoten
            // 
            this.lblHoten.AutoSize = true;
            this.lblHoten.Location = new System.Drawing.Point(60, 77);
            this.lblHoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHoten.Name = "lblHoten";
            this.lblHoten.Size = new System.Drawing.Size(73, 17);
            this.lblHoten.TabIndex = 16;
            this.lblHoten.Text = "Họ và tên:";
            // 
            // txtMakhach
            // 
            this.txtMakhach.Location = new System.Drawing.Point(233, 41);
            this.txtMakhach.Margin = new System.Windows.Forms.Padding(4);
            this.txtMakhach.Name = "txtMakhach";
            this.txtMakhach.Size = new System.Drawing.Size(360, 22);
            this.txtMakhach.TabIndex = 15;
            // 
            // lblMaKhach
            // 
            this.lblMaKhach.AutoSize = true;
            this.lblMaKhach.Location = new System.Drawing.Point(60, 45);
            this.lblMaKhach.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMaKhach.Name = "lblMaKhach";
            this.lblMaKhach.Size = new System.Drawing.Size(160, 17);
            this.lblMaKhach.TabIndex = 14;
            this.lblMaKhach.Text = "Mã khách thuê:         KH";
            // 
            // btnEscape
            // 
            this.btnEscape.Location = new System.Drawing.Point(380, 314);
            this.btnEscape.Margin = new System.Windows.Forms.Padding(4);
            this.btnEscape.Name = "btnEscape";
            this.btnEscape.Size = new System.Drawing.Size(213, 38);
            this.btnEscape.TabIndex = 29;
            this.btnEscape.Text = "Thoát";
            this.btnEscape.UseVisualStyleBackColor = true;
            this.btnEscape.Click += new System.EventHandler(this.btnEscape_Click);
            // 
            // btnSignup
            // 
            this.btnSignup.Location = new System.Drawing.Point(125, 314);
            this.btnSignup.Margin = new System.Windows.Forms.Padding(4);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(209, 38);
            this.btnSignup.TabIndex = 28;
            this.btnSignup.Text = "Đăng ký";
            this.btnSignup.UseVisualStyleBackColor = true;
            // 
            // frmInfoCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 383);
            this.Controls.Add(this.btnEscape);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtQuequan);
            this.Controls.Add(this.lblQuequan);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.grbGioitinh);
            this.Controls.Add(this.lblGioitinh);
            this.Controls.Add(this.txtNamsinh);
            this.Controls.Add(this.lblNamsinh);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.lblHoten);
            this.Controls.Add(this.txtMakhach);
            this.Controls.Add(this.lblMaKhach);
            this.Name = "frmInfoCustomer";
            this.Text = "InfoCustomer";
            this.grbGioitinh.ResumeLayout(false);
            this.grbGioitinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtQuequan;
        private System.Windows.Forms.Label lblQuequan;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.GroupBox grbGioitinh;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label lblGioitinh;
        private System.Windows.Forms.TextBox txtNamsinh;
        private System.Windows.Forms.Label lblNamsinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label lblHoten;
        private System.Windows.Forms.TextBox txtMakhach;
        private System.Windows.Forms.Label lblMaKhach;
        private System.Windows.Forms.Button btnEscape;
        private System.Windows.Forms.Button btnSignup;
    }
}