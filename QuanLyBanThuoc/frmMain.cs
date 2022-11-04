using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanThuoc
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void danhMụcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            status1.Text = "Danh mục loại thuốc";
            frmThuoc f = new frmThuoc();
            f.ShowDialog();
            status1.Text = "Ready";
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void danhMụcHóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Danh mục Hóa đơn nhập";
            frmHDNhap f = new frmHDNhap();
            f.ShowDialog();
            status1.Text = "Ready";
        }

        private void danhMụcHóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Danh mục Hóa đơn bán";
            Banhanghoa bh = new Banhanghoa();
            bh.ShowDialog();
            status1.Text = "Ready";
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Danh mục Khách hàng";
            frmQLKH f = new frmQLKH();
            f.ShowDialog();
            status1.Text = "Ready";
        }

        private void danhMụcTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            status1.Text = "Danh mục Tồn";
            frmTon f = new frmTon();
            f.ShowDialog();
            status1.Text = "Ready";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void danhMụcNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

		private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void danhMụcThuốcSắpHếtHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

		private void hỗTrợToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

        private void danhMụcToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
