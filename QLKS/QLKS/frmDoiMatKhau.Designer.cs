namespace QLKS
{
    partial class frmDoiMatKhau
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.MatKhauOldTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.MatKhauNewTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.MatKhauCfTB = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.DoiMKBT = new DevComponents.DotNetBar.ButtonX();
            this.CancelBT = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(26, 58);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(104, 23);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mật Khẩu Cũ :";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(26, 101);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(104, 23);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Mật Khẩu Mới :";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(26, 150);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(104, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Xác Nhận Lại:";
            // 
            // MatKhauOldTB
            // 
            // 
            // 
            // 
            this.MatKhauOldTB.Border.Class = "TextBoxBorder";
            this.MatKhauOldTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MatKhauOldTB.Location = new System.Drawing.Point(101, 58);
            this.MatKhauOldTB.Name = "MatKhauOldTB";
            this.MatKhauOldTB.Size = new System.Drawing.Size(100, 20);
            this.MatKhauOldTB.TabIndex = 1;
            // 
            // MatKhauNewTB
            // 
            // 
            // 
            // 
            this.MatKhauNewTB.Border.Class = "TextBoxBorder";
            this.MatKhauNewTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MatKhauNewTB.Location = new System.Drawing.Point(101, 104);
            this.MatKhauNewTB.Name = "MatKhauNewTB";
            this.MatKhauNewTB.Size = new System.Drawing.Size(100, 20);
            this.MatKhauNewTB.TabIndex = 2;
            // 
            // MatKhauCfTB
            // 
            // 
            // 
            // 
            this.MatKhauCfTB.Border.Class = "TextBoxBorder";
            this.MatKhauCfTB.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.MatKhauCfTB.Location = new System.Drawing.Point(101, 150);
            this.MatKhauCfTB.Name = "MatKhauCfTB";
            this.MatKhauCfTB.Size = new System.Drawing.Size(100, 20);
            this.MatKhauCfTB.TabIndex = 3;
            // 
            // DoiMKBT
            // 
            this.DoiMKBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DoiMKBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DoiMKBT.Location = new System.Drawing.Point(54, 237);
            this.DoiMKBT.Name = "DoiMKBT";
            this.DoiMKBT.Size = new System.Drawing.Size(75, 23);
            this.DoiMKBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DoiMKBT.TabIndex = 4;
            this.DoiMKBT.Text = "Đổi";
            this.DoiMKBT.Click += new System.EventHandler(this.DoiMKBT_Click);
            // 
            // CancelBT
            // 
            this.CancelBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.CancelBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.CancelBT.Location = new System.Drawing.Point(204, 237);
            this.CancelBT.Name = "CancelBT";
            this.CancelBT.Size = new System.Drawing.Size(75, 23);
            this.CancelBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.CancelBT.TabIndex = 5;
            this.CancelBT.Text = "Huỷ bỏ";
            this.CancelBT.Click += new System.EventHandler(this.CancelBT_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Black;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 363);
            this.Controls.Add(this.CancelBT);
            this.Controls.Add(this.DoiMKBT);
            this.Controls.Add(this.MatKhauCfTB);
            this.Controls.Add(this.MatKhauNewTB);
            this.Controls.Add(this.MatKhauOldTB);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "frmDoiMatKhau";
            this.Text = "frmDoiMatKhau";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX MatKhauOldTB;
        private DevComponents.DotNetBar.Controls.TextBoxX MatKhauNewTB;
        private DevComponents.DotNetBar.Controls.TextBoxX MatKhauCfTB;
        private DevComponents.DotNetBar.ButtonX DoiMKBT;
        private DevComponents.DotNetBar.ButtonX CancelBT;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}