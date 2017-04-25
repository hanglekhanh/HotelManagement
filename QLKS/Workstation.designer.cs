namespace QLKS
{
    partial class Workstation
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
            this.DSPhongBT = new DevComponents.DotNetBar.ButtonX();
            this.TimKhachBT = new DevComponents.DotNetBar.ButtonX();
            this.ThongKeBT = new DevComponents.DotNetBar.ButtonX();
            this.QLNVBT = new DevComponents.DotNetBar.ButtonX();
            this.DoiMKBT = new DevComponents.DotNetBar.ButtonX();
            this.DangXuatBT = new DevComponents.DotNetBar.ButtonX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.lbName = new DevComponents.DotNetBar.LabelX();
            this.btQLPhong = new DevComponents.DotNetBar.ButtonX();
            this.btPhuThu = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // DSPhongBT
            // 
            this.DSPhongBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DSPhongBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DSPhongBT.Location = new System.Drawing.Point(64, 95);
            this.DSPhongBT.Name = "DSPhongBT";
            this.DSPhongBT.Size = new System.Drawing.Size(124, 46);
            this.DSPhongBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DSPhongBT.TabIndex = 1;
            this.DSPhongBT.Text = "DS PHÒNG";
            this.DSPhongBT.Click += new System.EventHandler(this.DSPhongBT_Click);
            // 
            // TimKhachBT
            // 
            this.TimKhachBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.TimKhachBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.TimKhachBT.Location = new System.Drawing.Point(64, 201);
            this.TimKhachBT.Name = "TimKhachBT";
            this.TimKhachBT.Size = new System.Drawing.Size(124, 46);
            this.TimKhachBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.TimKhachBT.TabIndex = 2;
            this.TimKhachBT.Text = "TÌM KHÁCH";
            this.TimKhachBT.Click += new System.EventHandler(this.TimKhachBT_Click);
            // 
            // ThongKeBT
            // 
            this.ThongKeBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ThongKeBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ThongKeBT.Location = new System.Drawing.Point(498, 201);
            this.ThongKeBT.Name = "ThongKeBT";
            this.ThongKeBT.Size = new System.Drawing.Size(124, 46);
            this.ThongKeBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ThongKeBT.TabIndex = 3;
            this.ThongKeBT.Text = "THỐNG KÊ";
            this.ThongKeBT.Click += new System.EventHandler(this.ThongKeBT_Click);
            // 
            // QLNVBT
            // 
            this.QLNVBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.QLNVBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.QLNVBT.Location = new System.Drawing.Point(280, 201);
            this.QLNVBT.Name = "QLNVBT";
            this.QLNVBT.Size = new System.Drawing.Size(124, 46);
            this.QLNVBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.QLNVBT.TabIndex = 4;
            this.QLNVBT.Text = "QUẢN LÝ NV";
            this.QLNVBT.Click += new System.EventHandler(this.QLNVBT_Click);
            // 
            // DoiMKBT
            // 
            this.DoiMKBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DoiMKBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DoiMKBT.Location = new System.Drawing.Point(498, 13);
            this.DoiMKBT.Name = "DoiMKBT";
            this.DoiMKBT.Size = new System.Drawing.Size(124, 46);
            this.DoiMKBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DoiMKBT.TabIndex = 5;
            this.DoiMKBT.Text = "ĐỔI MẬT KHẨU";
            this.DoiMKBT.Click += new System.EventHandler(this.DoiMKBT_Click);
            // 
            // DangXuatBT
            // 
            this.DangXuatBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DangXuatBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.DangXuatBT.Location = new System.Drawing.Point(498, 283);
            this.DangXuatBT.Name = "DangXuatBT";
            this.DangXuatBT.Size = new System.Drawing.Size(124, 46);
            this.DangXuatBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.DangXuatBT.TabIndex = 6;
            this.DangXuatBT.Text = "ĐĂNG XUẤT";
            this.DangXuatBT.Click += new System.EventHandler(this.DangXuatBT_Click);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            // 
            // 
            // 
            this.lbName.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.Navy;
            this.lbName.Location = new System.Drawing.Point(49, 10);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(90, 26);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "Xin chào: ";
            // 
            // btQLPhong
            // 
            this.btQLPhong.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btQLPhong.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btQLPhong.Location = new System.Drawing.Point(280, 95);
            this.btQLPhong.Name = "btQLPhong";
            this.btQLPhong.Size = new System.Drawing.Size(124, 46);
            this.btQLPhong.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btQLPhong.TabIndex = 8;
            this.btQLPhong.Text = "QUẢN LÝ PHÒNG";
            this.btQLPhong.Click += new System.EventHandler(this.btQLPhong_Click);
            // 
            // btPhuThu
            // 
            this.btPhuThu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btPhuThu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btPhuThu.Location = new System.Drawing.Point(498, 95);
            this.btPhuThu.Name = "btPhuThu";
            this.btPhuThu.Size = new System.Drawing.Size(124, 46);
            this.btPhuThu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btPhuThu.TabIndex = 9;
            this.btPhuThu.Text = "ĐIỀU CHỈNH SP PHỤ THU";
            this.btPhuThu.Click += new System.EventHandler(this.btPhuThu_Click);
            // 
            // Workstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(704, 341);
            this.Controls.Add(this.btPhuThu);
            this.Controls.Add(this.btQLPhong);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.DangXuatBT);
            this.Controls.Add(this.DoiMKBT);
            this.Controls.Add(this.QLNVBT);
            this.Controls.Add(this.ThongKeBT);
            this.Controls.Add(this.TimKhachBT);
            this.Controls.Add(this.DSPhongBT);
            this.Name = "Workstation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workstation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Workstation_FormClosed);
            this.Load += new System.EventHandler(this.Workstation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX DSPhongBT;
        private DevComponents.DotNetBar.ButtonX TimKhachBT;
        private DevComponents.DotNetBar.ButtonX ThongKeBT;
        private DevComponents.DotNetBar.ButtonX QLNVBT;
        private DevComponents.DotNetBar.ButtonX DoiMKBT;
        private DevComponents.DotNetBar.ButtonX DangXuatBT;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.LabelX lbName;
        private DevComponents.DotNetBar.ButtonX btQLPhong;
        private DevComponents.DotNetBar.ButtonX btPhuThu;
    }
}