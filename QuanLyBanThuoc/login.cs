using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanThuoc
{
    public partial class frmLogin : Form

    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string sql, connstr;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{Tab}");
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmLogin_Leave(object sender, EventArgs e)
        {
            btnLogin.Focus();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sql = "Select * From tblDN where Username='" + txtUser.Text + "'and Password='" + txtPass.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt.Clear();
            da.Fill(dt);
            if (dt.Rows.Count == 1)
            {

                MessageBox.Show("Đăng nhập thành công");
                frmMain f = new frmMain();
                f.Show();
            }

            
            else
                MessageBox.Show("Đăng nhập thất bại");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            connstr = @"Data Source=ADMIN;Initial Catalog=QLBThuoc;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();
        }
    }
}
