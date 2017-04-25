namespace QLKS
{
    partial class frmLogin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserNametb = new System.Windows.Forms.TextBox();
            this.PassTB = new System.Windows.Forms.TextBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.LoginBT = new DevComponents.DotNetBar.ButtonX();
            this.ExitBT = new DevComponents.DotNetBar.ButtonX();
            this.InfoBT = new DevComponents.DotNetBar.ButtonX();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(573, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(573, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // UserNametb
            // 
            this.UserNametb.Location = new System.Drawing.Point(691, 79);
            this.UserNametb.Margin = new System.Windows.Forms.Padding(4);
            this.UserNametb.Multiline = true;
            this.UserNametb.Name = "UserNametb";
            this.UserNametb.Size = new System.Drawing.Size(196, 25);
            this.UserNametb.TabIndex = 1;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(691, 129);
            this.PassTB.Margin = new System.Windows.Forms.Padding(4);
            this.PassTB.Multiline = true;
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(196, 25);
            this.PassTB.TabIndex = 2;
            this.PassTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // LoginBT
            // 
            this.LoginBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LoginBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.LoginBT.Location = new System.Drawing.Point(600, 219);
            this.LoginBT.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(100, 28);
            this.LoginBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LoginBT.TabIndex = 3;
            this.LoginBT.Text = "Đăng Nhập";
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // ExitBT
            // 
            this.ExitBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ExitBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ExitBT.Location = new System.Drawing.Point(773, 219);
            this.ExitBT.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(100, 28);
            this.ExitBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ExitBT.TabIndex = 5;
            this.ExitBT.Text = "Thoát";
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // InfoBT
            // 
            this.InfoBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.InfoBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.InfoBT.Location = new System.Drawing.Point(49, 299);
            this.InfoBT.Margin = new System.Windows.Forms.Padding(4);
            this.InfoBT.Name = "InfoBT";
            this.InfoBT.Size = new System.Drawing.Size(496, 28);
            this.InfoBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.InfoBT.TabIndex = 6;
            this.InfoBT.Text = "Thông Tin";
            this.InfoBT.Click += new System.EventHandler(this.InfoBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(49, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(496, 277);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(999, 428);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfoBT);
            this.Controls.Add(this.ExitBT);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UserNametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox UserNametb;
        private System.Windows.Forms.TextBox PassTB;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX LoginBT;
        private DevComponents.DotNetBar.ButtonX ExitBT;
        private DevComponents.DotNetBar.ButtonX InfoBT;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

