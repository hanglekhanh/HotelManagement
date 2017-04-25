namespace QLKS
{
    partial class frmTraTien
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
            this.BTOK = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.TBTongTien = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.TBTienKhach = new System.Windows.Forms.MaskedTextBox();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(99, 39);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(160, 28);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Tổng Tiền :";
            // 
            // BTOK
            // 
            this.BTOK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BTOK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.BTOK.Location = new System.Drawing.Point(226, 132);
            this.BTOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BTOK.Name = "BTOK";
            this.BTOK.Size = new System.Drawing.Size(100, 28);
            this.BTOK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.BTOK.TabIndex = 3;
            this.BTOK.Text = "OK";
            this.BTOK.Click += new System.EventHandler(this.BTOK_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX3.Location = new System.Drawing.Point(99, 75);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(160, 28);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Tiền Khách Đưa : ";
            // 
            // TBTongTien
            // 
            // 
            // 
            // 
            this.TBTongTien.Border.Class = "TextBoxBorder";
            this.TBTongTien.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TBTongTien.Location = new System.Drawing.Point(268, 39);
            this.TBTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBTongTien.Name = "TBTongTien";
            this.TBTongTien.ReadOnly = true;
            this.TBTongTien.Size = new System.Drawing.Size(185, 22);
            this.TBTongTien.TabIndex = 1;
            // 
            // TBTienKhach
            // 
            this.TBTienKhach.Location = new System.Drawing.Point(268, 79);
            this.TBTienKhach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TBTienKhach.Name = "TBTienKhach";
            this.TBTienKhach.Size = new System.Drawing.Size(184, 22);
            this.TBTienKhach.TabIndex = 5;
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // frmTraTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(569, 172);
            this.Controls.Add(this.TBTienKhach);
            this.Controls.Add(this.BTOK);
            this.Controls.Add(this.TBTongTien);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmTraTien";
            this.Text = "Trả Tiền";
            this.Load += new System.EventHandler(this.frmTraTien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX BTOK;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX TBTongTien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MaskedTextBox TBTienKhach;
        private DevComponents.DotNetBar.StyleManager styleManager1;
    }
}