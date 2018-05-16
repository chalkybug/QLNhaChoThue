namespace MainProgram.UCs
{
    partial class ucAdmin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAdmin));
            this.toolStripAdmin = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnThanhToan = new System.Windows.Forms.ToolStripButton();
            this.tsbtnHelp = new System.Windows.Forms.ToolStripButton();
            this.tbpPhong = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tbpKhach = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControlAdmin = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripAdmin.SuspendLayout();
            this.tbpPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tbpKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlAdmin.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripAdmin
            // 
            this.toolStripAdmin.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton4,
            this.tsbtnThanhToan,
            this.tsbtnHelp,
            this.toolStripButton5});
            this.toolStripAdmin.Location = new System.Drawing.Point(0, 0);
            this.toolStripAdmin.Name = "toolStripAdmin";
            this.toolStripAdmin.Size = new System.Drawing.Size(1199, 27);
            this.toolStripAdmin.TabIndex = 0;
            this.toolStripAdmin.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(124, 24);
            this.toolStripButton1.Text = "AddCustomer";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = global::MainProgram.Properties.Resources.icons8_restart_30;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(59, 24);
            this.toolStripButton3.Text = "Edit";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::MainProgram.Properties.Resources.icons8_plus_50;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(101, 24);
            this.toolStripButton2.Text = "AddRoom";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::MainProgram.Properties.Resources.icons8_close_window_30;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(77, 24);
            this.toolStripButton4.Text = "Delete";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // tsbtnThanhToan
            // 
            this.tsbtnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnThanhToan.Image")));
            this.tsbtnThanhToan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnThanhToan.Name = "tsbtnThanhToan";
            this.tsbtnThanhToan.Size = new System.Drawing.Size(149, 24);
            this.tsbtnThanhToan.Text = "Thanh toán tháng";
            this.tsbtnThanhToan.Click += new System.EventHandler(this.tsbtnThanhToan_Click);
            // 
            // tsbtnHelp
            // 
            this.tsbtnHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnHelp.Image = global::MainProgram.Properties.Resources.icons8_help_30;
            this.tsbtnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnHelp.Name = "tsbtnHelp";
            this.tsbtnHelp.Size = new System.Drawing.Size(88, 24);
            this.tsbtnHelp.Text = "Trợ giúp";
            this.tsbtnHelp.Click += new System.EventHandler(this.tsbtnHelp_Click);
            // 
            // tbpPhong
            // 
            this.tbpPhong.Controls.Add(this.dataGridView2);
            this.tbpPhong.Location = new System.Drawing.Point(4, 25);
            this.tbpPhong.Margin = new System.Windows.Forms.Padding(4);
            this.tbpPhong.Name = "tbpPhong";
            this.tbpPhong.Padding = new System.Windows.Forms.Padding(4);
            this.tbpPhong.Size = new System.Drawing.Size(1191, 476);
            this.tbpPhong.TabIndex = 1;
            this.tbpPhong.Text = "Phong";
            this.tbpPhong.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(4, 4);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1183, 468);
            this.dataGridView2.TabIndex = 0;
            // 
            // tbpKhach
            // 
            this.tbpKhach.Controls.Add(this.dataGridView1);
            this.tbpKhach.Location = new System.Drawing.Point(4, 25);
            this.tbpKhach.Margin = new System.Windows.Forms.Padding(4);
            this.tbpKhach.Name = "tbpKhach";
            this.tbpKhach.Padding = new System.Windows.Forms.Padding(4);
            this.tbpKhach.Size = new System.Drawing.Size(1191, 476);
            this.tbpKhach.TabIndex = 0;
            this.tbpKhach.Text = "Khach";
            this.tbpKhach.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 4);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1183, 468);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabControlAdmin
            // 
            this.tabControlAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlAdmin.Controls.Add(this.tbpKhach);
            this.tabControlAdmin.Controls.Add(this.tbpPhong);
            this.tabControlAdmin.Controls.Add(this.tabPage1);
            this.tabControlAdmin.Location = new System.Drawing.Point(0, 46);
            this.tabControlAdmin.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlAdmin.Name = "tabControlAdmin";
            this.tabControlAdmin.SelectedIndex = 0;
            this.tabControlAdmin.Size = new System.Drawing.Size(1199, 505);
            this.tabControlAdmin.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(1191, 476);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "DangKyPhong";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 2);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1185, 472);
            this.dataGridView3.TabIndex = 0;
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(96, 24);
            this.toolStripButton5.Text = "Tìm Kiếm";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // ucAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControlAdmin);
            this.Controls.Add(this.toolStripAdmin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucAdmin";
            this.Size = new System.Drawing.Size(1199, 551);
            this.Load += new System.EventHandler(this.ucAdmin_Load);
            this.toolStripAdmin.ResumeLayout(false);
            this.toolStripAdmin.PerformLayout();
            this.tbpPhong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tbpKhach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlAdmin.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripAdmin;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbtnThanhToan;
        private System.Windows.Forms.TabPage tbpPhong;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tbpKhach;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabControlAdmin;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ToolStripButton tsbtnHelp;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
    }
}
