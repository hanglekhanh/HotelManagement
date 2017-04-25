namespace QLKS
{
    partial class frmTimKhach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbTenKhach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.gvKhach = new DevComponents.DotNetBar.Controls.DataGridViewX();
            ((System.ComponentModel.ISupportInitialize)(this.gvKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // tbTenKhach
            // 
            // 
            // 
            // 
            this.tbTenKhach.Border.Class = "TextBoxBorder";
            this.tbTenKhach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbTenKhach.Location = new System.Drawing.Point(525, 12);
            this.tbTenKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTenKhach.Name = "tbTenKhach";
            this.tbTenKhach.Size = new System.Drawing.Size(171, 22);
            this.tbTenKhach.TabIndex = 0;
            this.tbTenKhach.WatermarkBehavior = DevComponents.DotNetBar.eWatermarkBehavior.HideNonEmpty;
            this.tbTenKhach.WatermarkText = "Nhập tên hoặc CMND";
            this.tbTenKhach.TextChanged += new System.EventHandler(this.tbTenKhach_TextChanged);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // gvKhach
            // 
            this.gvKhach.BackgroundColor = System.Drawing.Color.White;
            this.gvKhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvKhach.DefaultCellStyle = dataGridViewCellStyle1;
            this.gvKhach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.gvKhach.Location = new System.Drawing.Point(12, 57);
            this.gvKhach.Name = "gvKhach";
            this.gvKhach.ReadOnly = true;
            this.gvKhach.RowTemplate.Height = 24;
            this.gvKhach.Size = new System.Drawing.Size(779, 159);
            this.gvKhach.TabIndex = 1;
            // 
            // frmTimKhach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(221)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(803, 228);
            this.Controls.Add(this.gvKhach);
            this.Controls.Add(this.tbTenKhach);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTimKhach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm Khách";
            this.Load += new System.EventHandler(this.frmTimKhach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvKhach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbTenKhach;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private DevComponents.DotNetBar.Controls.DataGridViewX gvKhach;

    }
}