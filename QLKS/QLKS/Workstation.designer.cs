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
            this.label1 = new System.Windows.Forms.Label();
            this.NameLB = new System.Windows.Forms.Label();
            this.DSPhongBT = new DevComponents.DotNetBar.ButtonX();
            this.TimKhachBT = new DevComponents.DotNetBar.ButtonX();
            this.ThongKeBT = new DevComponents.DotNetBar.ButtonX();
            this.QLNVBT = new DevComponents.DotNetBar.ButtonX();
            this.DoiMKBT = new DevComponents.DotNetBar.ButtonX();
            this.DangXuatBT = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xin Chào";
            // 
            // NameLB
            // 
            this.NameLB.AutoSize = true;
            this.NameLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NameLB.Location = new System.Drawing.Point(144, 13);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(0, 26);
            this.NameLB.TabIndex = 0;
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
            this.DSPhongBT.Text = "DS Phòng";
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
            this.TimKhachBT.Text = "Tìm Khách";
            // 
            // ThongKeBT
            // 
            this.ThongKeBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ThongKeBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ThongKeBT.Location = new System.Drawing.Point(313, 95);
            this.ThongKeBT.Name = "ThongKeBT";
            this.ThongKeBT.Size = new System.Drawing.Size(124, 46);
            this.ThongKeBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ThongKeBT.TabIndex = 3;
            this.ThongKeBT.Text = "Thống Kê";
            // 
            // QLNVBT
            // 
            this.QLNVBT.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.QLNVBT.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.QLNVBT.Location = new System.Drawing.Point(313, 201);
            this.QLNVBT.Name = "QLNVBT";
            this.QLNVBT.Size = new System.Drawing.Size(124, 46);
            this.QLNVBT.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.QLNVBT.TabIndex = 4;
            this.QLNVBT.Text = "Quản Lí NV";
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
            this.DoiMKBT.Text = "Đổi Mật Khẩu";
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
            this.DangXuatBT.Text = "Đăng Xuất";
            this.DangXuatBT.Click += new System.EventHandler(this.DangXuatBT_Click);
            // 
            // Workstation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 341);
            this.Controls.Add(this.DangXuatBT);
            this.Controls.Add(this.DoiMKBT);
            this.Controls.Add(this.QLNVBT);
            this.Controls.Add(this.ThongKeBT);
            this.Controls.Add(this.TimKhachBT);
            this.Controls.Add(this.DSPhongBT);
            this.Controls.Add(this.NameLB);
            this.Controls.Add(this.label1);
            this.Name = "Workstation";
            this.Text = "Workstation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Workstation_FormClosed);
            this.Load += new System.EventHandler(this.Workstation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLB;
        private DevComponents.DotNetBar.ButtonX DSPhongBT;
        private DevComponents.DotNetBar.ButtonX TimKhachBT;
        private DevComponents.DotNetBar.ButtonX ThongKeBT;
        private DevComponents.DotNetBar.ButtonX QLNVBT;
        private DevComponents.DotNetBar.ButtonX DoiMKBT;
        private DevComponents.DotNetBar.ButtonX DangXuatBT;
    }
}