
namespace QuanLyBanThuoc
{
    partial class HDNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DcNB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdHDNhap = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdHDNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Image = global::QuanLyBanThuoc.Properties.Resources.Trống;
            this.label1.Location = new System.Drawing.Point(245, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "DANH SÁCH HÓA ĐƠN NHẬP KHO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(357, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Thêm hóa đơn";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.TongTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.TongTien.HeaderText = "Tổng Tiền";
            this.TongTien.Name = "TongTien";
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.Name = "NgayNhap";
            // 
            // SDTNB
            // 
            this.SDTNB.DataPropertyName = "SDTNB";
            this.SDTNB.HeaderText = "Số điện thoại";
            this.SDTNB.Name = "SDTNB";
            // 
            // DcNB
            // 
            this.DcNB.DataPropertyName = "DcNB";
            this.DcNB.HeaderText = "Địa chỉ";
            this.DcNB.Name = "DcNB";
            this.DcNB.Width = 200;
            // 
            // TenNB
            // 
            this.TenNB.DataPropertyName = "TenNB";
            this.TenNB.HeaderText = "Tên nhà cung cấp";
            this.TenNB.Name = "TenNB";
            this.TenNB.Width = 120;
            // 
            // MaHDNhap
            // 
            this.MaHDNhap.DataPropertyName = "MaHDNhap";
            this.MaHDNhap.HeaderText = "Mã hóa đơn";
            this.MaHDNhap.Name = "MaHDNhap";
            // 
            // grdHDNhap
            // 
            this.grdHDNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdHDNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHDNhap,
            this.TenNB,
            this.DcNB,
            this.SDTNB,
            this.NgayNhap,
            this.TongTien});
            this.grdHDNhap.Location = new System.Drawing.Point(32, 82);
            this.grdHDNhap.Name = "grdHDNhap";
            this.grdHDNhap.Size = new System.Drawing.Size(765, 375);
            this.grdHDNhap.TabIndex = 0;
            this.grdHDNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHDNhap_CellContentClick);
            // 
            // HDNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyBanThuoc.Properties.Resources.BG15;
            this.ClientSize = new System.Drawing.Size(836, 545);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdHDNhap);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "HDNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HDNhap";
            this.Load += new System.EventHandler(this.HDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdHDNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNB;
        private System.Windows.Forms.DataGridViewTextBoxColumn DcNB;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNB;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDNhap;
        private System.Windows.Forms.DataGridView grdHDNhap;
    }
}