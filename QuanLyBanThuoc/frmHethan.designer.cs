namespace QuanLyBanThuoc
{
    partial class frmHethan
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHethan));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txtHSD = new System.Windows.Forms.DateTimePicker();
			this.label4 = new System.Windows.Forms.Label();
			this.txtDG = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTenThuoc = new System.Windows.Forms.TextBox();
			this.cbMT = new System.Windows.Forms.ComboBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnDel = new System.Windows.Forms.Button();
			this.btnEdit = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnAddnew = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnLast = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnFirst = new System.Windows.Forms.Button();
			this.grdHethan = new System.Windows.Forms.DataGridView();
			this.MaThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DG = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.grdHethan)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(393, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(316, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "QUẢN LÝ THUỐC HẾT HẠN";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txtHSD);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtDG);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtTenThuoc);
			this.groupBox1.Controls.Add(this.cbMT);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(9, 74);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox1.Size = new System.Drawing.Size(1006, 142);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Thông tin chung";
			// 
			// txtHSD
			// 
			this.txtHSD.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtHSD.Location = new System.Drawing.Point(628, 76);
			this.txtHSD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtHSD.Name = "txtHSD";
			this.txtHSD.Size = new System.Drawing.Size(181, 28);
			this.txtHSD.TabIndex = 8;
			this.txtHSD.Value = new System.DateTime(2021, 6, 17, 0, 0, 0, 0);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(551, 80);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 21);
			this.label4.TabIndex = 7;
			this.label4.Text = "HSD";
			// 
			// txtDG
			// 
			this.txtDG.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDG.Location = new System.Drawing.Point(628, 35);
			this.txtDG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtDG.Name = "txtDG";
			this.txtDG.Size = new System.Drawing.Size(185, 28);
			this.txtDG.TabIndex = 3;
			this.txtDG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDG_KeyPress);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(551, 38);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(65, 21);
			this.label8.TabIndex = 5;
			this.label8.Text = "Đơn giá";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(44, 76);
			this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(81, 21);
			this.label7.TabIndex = 4;
			this.label7.Text = "Tên Thuốc";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(44, 38);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 21);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mã Thuốc";
			// 
			// txtTenThuoc
			// 
			this.txtTenThuoc.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTenThuoc.Location = new System.Drawing.Point(132, 72);
			this.txtTenThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.txtTenThuoc.Name = "txtTenThuoc";
			this.txtTenThuoc.Size = new System.Drawing.Size(185, 28);
			this.txtTenThuoc.TabIndex = 2;
			// 
			// cbMT
			// 
			this.cbMT.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMT.FormattingEnabled = true;
			this.cbMT.Location = new System.Drawing.Point(132, 32);
			this.cbMT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.cbMT.Name = "cbMT";
			this.cbMT.Size = new System.Drawing.Size(185, 29);
			this.cbMT.TabIndex = 1;
			this.cbMT.SelectedIndexChanged += new System.EventHandler(this.cbMT_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnDel);
			this.groupBox2.Controls.Add(this.btnEdit);
			this.groupBox2.Controls.Add(this.btnUpdate);
			this.groupBox2.Controls.Add(this.btnAddnew);
			this.groupBox2.Controls.Add(this.btnExit);
			this.groupBox2.Controls.Add(this.btnLast);
			this.groupBox2.Controls.Add(this.btnNext);
			this.groupBox2.Controls.Add(this.btnPrevious);
			this.groupBox2.Controls.Add(this.btnFirst);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(9, 370);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.groupBox2.Size = new System.Drawing.Size(1006, 92);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Chức năng";
			// 
			// btnDel
			// 
			this.btnDel.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnDel.Image = global::QuanLyBanThuoc.Properties.Resources.delete_delete_exit_15771;
			this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnDel.Location = new System.Drawing.Point(628, 34);
			this.btnDel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnDel.Name = "btnDel";
			this.btnDel.Size = new System.Drawing.Size(74, 41);
			this.btnDel.TabIndex = 35;
			this.btnDel.Text = "Xóa";
			this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnDel.UseVisualStyleBackColor = false;
			this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
			// 
			// btnEdit
			// 
			this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEdit.Image = global::QuanLyBanThuoc.Properties.Resources.edit_icon_icons_com_66118;
			this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnEdit.Location = new System.Drawing.Point(550, 34);
			this.btnEdit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnEdit.Name = "btnEdit";
			this.btnEdit.Size = new System.Drawing.Size(74, 41);
			this.btnEdit.TabIndex = 34;
			this.btnEdit.Text = "Sửa";
			this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnEdit.UseVisualStyleBackColor = false;
			this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnUpdate.Enabled = false;
			this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnUpdate.Image = global::QuanLyBanThuoc.Properties.Resources.twocirclingarrows1_120592;
			this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUpdate.Location = new System.Drawing.Point(706, 34);
			this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(95, 41);
			this.btnUpdate.TabIndex = 33;
			this.btnUpdate.Text = "Cập nhật";
			this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnAddnew
			// 
			this.btnAddnew.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAddnew.Image = global::QuanLyBanThuoc.Properties.Resources.add_icon_icons_com_74429;
			this.btnAddnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAddnew.Location = new System.Drawing.Point(445, 34);
			this.btnAddnew.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnAddnew.Name = "btnAddnew";
			this.btnAddnew.Size = new System.Drawing.Size(100, 41);
			this.btnAddnew.TabIndex = 32;
			this.btnAddnew.Text = "Thêm mới";
			this.btnAddnew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnAddnew.UseVisualStyleBackColor = false;
			this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
			// 
			// btnExit
			// 
			this.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Image = global::QuanLyBanThuoc.Properties.Resources.shutdown_off_close_exit_15253;
			this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnExit.Location = new System.Drawing.Point(884, 34);
			this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(94, 41);
			this.btnExit.TabIndex = 31;
			this.btnExit.Text = "Kết thúc";
			this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnExit.UseVisualStyleBackColor = false;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnLast
			// 
			this.btnLast.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLast.Image = global::QuanLyBanThuoc.Properties.Resources.lasttrackoutlinedbutton_81084;
			this.btnLast.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnLast.Location = new System.Drawing.Point(290, 34);
			this.btnLast.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(79, 41);
			this.btnLast.TabIndex = 30;
			this.btnLast.Text = "Cuối";
			this.btnLast.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnLast.UseVisualStyleBackColor = false;
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Image = global::QuanLyBanThuoc.Properties.Resources.Next_arrow_15591;
			this.btnNext.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNext.Location = new System.Drawing.Point(215, 34);
			this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(70, 41);
			this.btnNext.TabIndex = 29;
			this.btnNext.Text = "Sau";
			this.btnNext.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPrevious.Image = global::QuanLyBanThuoc.Properties.Resources.button_previous_149991;
			this.btnPrevious.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnPrevious.Location = new System.Drawing.Point(132, 34);
			this.btnPrevious.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(79, 41);
			this.btnPrevious.TabIndex = 28;
			this.btnPrevious.Text = "Trước";
			this.btnPrevious.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnPrevious.UseVisualStyleBackColor = false;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrv_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFirst.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnFirst.Location = new System.Drawing.Point(52, 34);
			this.btnFirst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnFirst.Size = new System.Drawing.Size(76, 41);
			this.btnFirst.TabIndex = 27;
			this.btnFirst.Text = "Đầu";
			this.btnFirst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnFirst.UseMnemonic = false;
			this.btnFirst.UseVisualStyleBackColor = false;
			this.btnFirst.Click += new System.EventHandler(this.btnFisrt_Click);
			// 
			// grdHethan
			// 
			this.grdHethan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.grdHethan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaThuoc,
            this.TenThuoc,
            this.DG,
            this.HSD});
			this.grdHethan.Location = new System.Drawing.Point(9, 210);
			this.grdHethan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.grdHethan.Name = "grdHethan";
			this.grdHethan.RowHeadersWidth = 51;
			this.grdHethan.RowTemplate.Height = 24;
			this.grdHethan.Size = new System.Drawing.Size(1006, 160);
			this.grdHethan.TabIndex = 17;
			this.grdHethan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdHethan_CellContentClick_1);
			// 
			// MaThuoc
			// 
			this.MaThuoc.DataPropertyName = "MaThuoc";
			this.MaThuoc.HeaderText = "Mã Thuốc";
			this.MaThuoc.MinimumWidth = 6;
			this.MaThuoc.Name = "MaThuoc";
			this.MaThuoc.Width = 125;
			// 
			// TenThuoc
			// 
			this.TenThuoc.DataPropertyName = "TenThuoc";
			this.TenThuoc.HeaderText = "Tên Thuốc";
			this.TenThuoc.MinimumWidth = 6;
			this.TenThuoc.Name = "TenThuoc";
			this.TenThuoc.Width = 125;
			// 
			// DG
			// 
			this.DG.DataPropertyName = "DG";
			this.DG.HeaderText = "Đơn giá";
			this.DG.MinimumWidth = 6;
			this.DG.Name = "DG";
			this.DG.Width = 125;
			// 
			// HSD
			// 
			this.HSD.DataPropertyName = "HSD";
			this.HSD.HeaderText = "HSD";
			this.HSD.MinimumWidth = 6;
			this.HSD.Name = "HSD";
			this.HSD.Width = 125;
			// 
			// frmHethan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(1028, 481);
			this.Controls.Add(this.grdHethan);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "frmHethan";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmHethan";
			this.Load += new System.EventHandler(this.frmHethan_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.grdHethan)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDG;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenThuoc;
        private System.Windows.Forms.ComboBox cbMT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView grdHethan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DateTimePicker txtHSD;
    }
}

