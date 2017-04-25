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
            this.label1.Location = new System.Drawing.Point(430, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(430, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật Khẩu:";
            // 
            // UserNametb
            // 
            this.UserNametb.Location = new System.Drawing.Point(518, 64);
            this.UserNametb.Multiline = true;
            this.UserNametb.Name = "UserNametb";
            this.UserNametb.Size = new System.Drawing.Size(148, 21);
            this.UserNametb.TabIndex = 1;
            // 
            // PassTB
            // 
            this.PassTB.Location = new System.Drawing.Point(518, 105);
            this.PassTB.Multiline = true;
            this.PassTB.Name = "PassTB";
            this.PassTB.PasswordChar = '*';
            this.PassTB.Size = new System.Drawing.Size(148, 21);
            this.PassTB.TabIndex = 2;
            this.PassTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmLogin_KeyPress);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // LoginBT
            // 
            this.LoginBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LoginBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.LoginBT.Location = new System.Drawing.Point(450, 178);
            this.LoginBT.Name = "LoginBT";
            this.LoginBT.Size = new System.Drawing.Size(75, 23);
            this.LoginBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.LoginBT.TabIndex = 3;
            this.LoginBT.Text = "Đăng Nhập";
            this.LoginBT.Click += new System.EventHandler(this.LoginBT_Click);
            // 
            // ExitBT
            // 
            this.ExitBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ExitBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ExitBT.Location = new System.Drawing.Point(580, 178);
            this.ExitBT.Name = "ExitBT";
            this.ExitBT.Size = new System.Drawing.Size(75, 23);
            this.ExitBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ExitBT.TabIndex = 5;
            this.ExitBT.Text = "Thoát";
            this.ExitBT.Click += new System.EventHandler(this.ExitBT_Click);
            // 
            // InfoBT
            // 
            this.InfoBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.InfoBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.InfoBT.Location = new System.Drawing.Point(37, 243);
            this.InfoBT.Name = "InfoBT";
            this.InfoBT.Size = new System.Drawing.Size(372, 23);
            this.InfoBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.InfoBT.TabIndex = 6;
            this.InfoBT.Text = "Thông Tin";
            this.InfoBT.Click += new System.EventHandler(this.InfoBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 225);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 348);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InfoBT);
            this.Controls.Add(this.ExitBT);
            this.Controls.Add(this.LoginBT);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UserNametb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLogin";
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
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.ButtonX LoginBT;
        private DevComponents.DotNetBar.ButtonX ExitBT;
        private DevComponents.DotNetBar.ButtonX InfoBT;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox PassTB;
    }
}

