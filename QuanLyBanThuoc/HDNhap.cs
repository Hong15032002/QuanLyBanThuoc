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
    public partial class HDNhap : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable HDNhapHang = new DataTable();
        string sql, constr;
        int i;
        public HDNhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHDNhap f = new frmHDNhap();
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void grdHDNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void HDNhap_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-Q3538V7\\SQLEXPRESS;Initial Catalog=QLBT1;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select MaHDNhap,TenNB,DcNB,SDTNB,NgayNhap,TongTien from tblNhap1 order by MaHDNhap";
            da = new SqlDataAdapter(sql, conn);
            HDNhapHang = new DataTable();
            da.Fill(HDNhapHang); //dữ liệu từ da đổ vào bảng dt
            grdHDNhap.DataSource = HDNhapHang;
        }
    }
}
