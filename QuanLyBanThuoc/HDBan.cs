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
    public partial class HDBan : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable HDBanHang = new DataTable();
        string sql, constr;
        int i;
        public HDBan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Banhanghoa f = new Banhanghoa();
            f.Show();
        }

        private void HDBan_Load(object sender, EventArgs e)
        {
            constr = "Data Source=DESKTOP-Q3538V7\\SQLEXPRESS;Initial Catalog=QLBT1;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "Select MaHDBan,NgayBan,MaKhach,TongTien from tblBan1 order by MaHDBan";
            da = new SqlDataAdapter(sql, conn);
            HDBanHang = new DataTable();
            da.Fill(HDBanHang); //dữ liệu từ da đổ vào bảng dt
            grdHDBan.DataSource = HDBanHang;
        }
    }
}
