using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyBanThuoc
{
    public partial class frmMain1 : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dtrpt = new DataTable();
        DataTable dtcom = new DataTable();
        string sql, connstr;
        public frmMain1()
        {
            InitializeComponent();
        }

        private void hóaĐơnBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDBan f = new HDBan();
            f.Show();
        }

        private void hóaĐơnNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HDNhap f = new HDNhap()
;
            f.Show();

        }

        private void báoCáoDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoDT f = new BaoCaoDT();
            f.Show();
        }

        private void báoCáoNhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BaoCaoNK f = new BaoCaoNK();
            f.Show();
        }

        private void báoCáoThuốcHếtHạnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMain1_Load(object sender, EventArgs e)
        {

        }

        private void danhMụcThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThuoc f = new frmThuoc();
            f.Show();
        }

        private void danhMụcKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQLKH f = new frmQLKH();
            f.Show();
        }

		private void danhMụcNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void danhMụcLoạiThuốcToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmThuoc f = new frmThuoc();
            f.ShowDialog();
        }

		private void danhMụcTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmTon f = new frmTon();
            f.ShowDialog();
        }

		private void danhMụcThuốcSắpHếtHạnToolStripMenuItem_Click(object sender, EventArgs e)
		{
            frmHethan f = new frmHethan();
            f.ShowDialog();
        }

        private void danhMụcThuốcToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmThuoc f = new frmThuoc();
            f.Show();
        }

        private void danhMụcNhàCungCấpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmNCC f = new frmNCC();
            f.Show();
        }

        private void danhMụcNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void báoCáoTồnKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
