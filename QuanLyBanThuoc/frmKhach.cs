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
    public partial class frmQLKH : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtcom = new DataTable();
        SqlCommand cmd;
        string sql, connstr;
        int i;
        Boolean AddNewFlag = false;
        string tTenKhach, tDiaChi, tSDT;
        public frmQLKH()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            connstr = @"Data Source=DESKTOP-Q3538V7\SQLEXPRESS;Initial Catalog=QLBT1;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();
            sql="select * from tblKhach order by MaKhach";
            da = new SqlDataAdapter(sql, conn);  //thực hiên câu lệnh truy vấn csdl 
            da.Fill(dt); //đổ dữ liệu vào bảng dt 
            grdKH.DataSource = dt;
            grdKH.Refresh();
            sql = "Select MaKhach From tblKhach";
            da = new SqlDataAdapter(sql, conn);
            dtcom.Clear();
            da.Fill(dtcom);
            txtMaKhach.DataSource = dtcom;
            txtMaKhach.DisplayMember = "MaKhach";

            NapCT();
        }

        private void grdKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdKH.CurrentCell = grdKH[0, 0]; //ô hiện thời chuyển về vị trí cột 0 dòng 0
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdKH.CurrentRow.Index;
            if(i>0)
            grdKH.CurrentCell = grdKH[0, i-1];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdKH.CurrentRow.Index;
            if (i < grdKH.RowCount-1)
                grdKH.CurrentCell = grdKH[0, i + 1];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdKH.CurrentCell = grdKH[0, grdKH.RowCount-1];
            NapCT();
        }

        private void btnDlt_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?","Xác nhận yêu cầu",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==DialogResult.Yes)
            {
                sql = "Delete From tblKhach where MaKhach='" + txtMaKhach.Text + "'";
                grdKH.Rows.RemoveAt(grdKH.CurrentRow.Index);//xóa dòng hiện thiowf của ô lưới
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();//thực hiện câu lệnh sql
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            grdKH.CurrentCell = grdKH[0, grdKH.RowCount - 1];
            NapCT();
            AddNewFlag = true;
            txtMaKhach.Focus();
            btnUpdate.Enabled = true;
            
        }

        private void frmQLKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }
                

        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {           


        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //txtTenKhach.Focus();
            AddNewFlag = false;
            btnUpdate.Enabled = true;
            grdKH.Enabled = true;
            grdKH.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(AddNewFlag)
            {
                sql = "Insert  into tblKhach (MaKhach, TenKhach, DiaChi, SDT) Values ('" + txtMaKhach.Text + "',N'" + txtTenKhach.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();//thực hiện câu lệnh sql
                MessageBox.Show("Đã thêm mới thành công");
                AddNewFlag = false;
                btnUpdate.Enabled = false;
                i = grdKH.CurrentRow.Index;//i lấy stt của dòng hiện thời trong ô lưới
                grdKH[0, i].Value = txtMaKhach.Text;
                grdKH[1, i].Value = txtTenKhach.Text;
                grdKH[2, i].Value = txtDiaChi.Text;
                grdKH[3, i].Value = txtSDT.Text;

                //cập nhật thêm mới
            }
            else
            {
                //cập nhật sửa chữa 
                /*sql = "Update tblKhach set TenKhach=N'" + txtTenKhach.Text + "',DiaChi=N'" + txtDiaChi.Text + "', SDT ='" + txtSDT.Text +"' where MaKhach='" + txtMaKhach.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();//thực hiện câu lệnh sql
                MessageBox.Show("Đã cập nhật sửa chữa thành công!", "Thông báo");
                btnUpdate.Enabled = false;
                sql = "select * from tblKhach order by MaKhach";
                da = new SqlDataAdapter(sql, conn);  //thực hiên câu lệnh truy vấn csdl 
                dt.Clear();
                da.Fill(dt); //đổ dữ liệu vào bảng dt 
                grdKH.DataSource = dt;
                grdKH.Refresh();
                NapCT();*/
                for(i=0; i < grdKH.RowCount-1; i++)
                {
                    tTenKhach = grdKH[1, i].Value.ToString();
                    tDiaChi = grdKH[2, i].Value.ToString();
                    tSDT = grdKH[3, i].Value.ToString();
                    sql = "Update tblKhach set TenKhach=N'" + txtTenKhach.Text + "',DiaChi=N'" + txtDiaChi.Text + "',SDT='" + txtSDT.Text + "' where MaKhach='" + grdKH[1, i].Value.ToString() + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();//thực hiện câu lệnh sql
                }
                MessageBox.Show("Đã cập nhật sửa chữa thành công!", "Thông báo");
                btnUpdate.Enabled = false;
                grdKH.Enabled = false;

            }
        }

        public void NapCT()
        {
            i = grdKH.CurrentRow.Index;//i lấy stt của dòng hiện thời trong ô lưới
            txtMaKhach.Text = grdKH[0, i].Value.ToString();
            txtTenKhach.Text = grdKH[1, i].Value.ToString();
            txtDiaChi.Text = grdKH[2, i].Value.ToString();
            txtSDT.Text = grdKH[3, i].Value.ToString();
        }
    }
}
