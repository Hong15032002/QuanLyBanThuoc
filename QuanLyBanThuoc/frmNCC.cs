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
    public partial class frmNCC : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        DataTable dtcom = new DataTable();
        SqlCommand cmd;
        string sql, connstr;
        int i;
        Boolean AddNewFlag = false;
        string tTenNCC, tDiaChi, tSDT;

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmNCC()
        {
            InitializeComponent();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdNCC.CurrentCell = grdNCC[0, 0]; //ô hiện thời chuyển về vị trí cột 0 dòng 0
            NapCT();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            i = grdNCC.CurrentRow.Index;
            if (i > 0)
                grdNCC.CurrentCell = grdNCC[0, i - 1];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdNCC.CurrentRow.Index;
            if (i < grdNCC.RowCount - 1)
                grdNCC.CurrentCell = grdNCC[0, i + 1];
            NapCT();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdNCC.CurrentCell = grdNCC[0, grdNCC.RowCount - 1];
            NapCT();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From tblNCC where MaNCC='" + txtMaNCC.Text + "'";
                grdNCC.Rows.RemoveAt(grdNCC.CurrentRow.Index);//xóa dòng hiện thiowf của ô lưới
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();//thực hiện câu lệnh sql
            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            grdNCC.CurrentCell = grdNCC[0, grdNCC.RowCount - 1];
            NapCT();
            AddNewFlag = true;
            txtMaNCC.Focus();
            btnUpdate.Enabled = true;
        }
        private void frmQLKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{Tab}");
            }


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
            grdNCC.Enabled = true;
            grdNCC.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (AddNewFlag)
            {
                sql = "Insert  into tblNCC (MaNCC, TenNCC, DiaChiNCC, SDTNCC) Values ('" + txtMaNCC.Text + "',N'" + txtTenNCC.Text + "',N'" + txtDiaChi.Text + "','" + txtSDT.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();//thực hiện câu lệnh sql
                MessageBox.Show("Đã thêm mới thành công");
                AddNewFlag = false;
                btnUpdate.Enabled = false;
                i = grdNCC.CurrentRow.Index;//i lấy stt của dòng hiện thời trong ô lưới
                grdNCC[0, i].Value = txtMaNCC.Text;
                grdNCC[1, i].Value = txtTenNCC.Text;
                grdNCC[2, i].Value = txtDiaChi.Text;
                grdNCC[3, i].Value = txtSDT.Text;

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
                for (i = 0; i < grdNCC.RowCount - 1; i++)
                {
                    tTenNCC = grdNCC[1, i].Value.ToString();
                    tDiaChi = grdNCC[2, i].Value.ToString();
                    tSDT = grdNCC[3, i].Value.ToString();
                    sql = "Update tblKhach set TenKhach=N'" + txtTenNCC.Text + "',DiaChi=N'" + txtDiaChi.Text + "',SDT='" + txtSDT.Text + "' where MaKhach='" + grdNCC[1, i].Value.ToString() + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();//thực hiện câu lệnh sql
                }
                MessageBox.Show("Đã cập nhật sửa chữa thành công!", "Thông báo");
                btnUpdate.Enabled = false;
                grdNCC.Enabled = false;

            }
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            connstr = @"Data Source=DESKTOP-Q3538V7\SQLEXPRESS;Initial Catalog=QLBT1;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "select * from tblNCC order by MaNCC";
            da = new SqlDataAdapter(sql, conn);  //thực hiên câu lệnh truy vấn csdl 
            da.Fill(dt); //đổ dữ liệu vào bảng dt 
            grdNCC.DataSource = dt;
            grdNCC.Refresh();
            sql = "Select MaNCC From tblNCC";
            da = new SqlDataAdapter(sql, conn);
            dtcom.Clear();
            da.Fill(dtcom);
            txtMaNCC.DataSource = dtcom;
            txtMaNCC.DisplayMember = "MaNCC";

            NapCT();
        }
        private void grdKH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        public void NapCT()
        {
            i = grdNCC.CurrentRow.Index;//i lấy stt của dòng hiện thời trong ô lưới
            txtMaNCC.Text = grdNCC[0, i].Value.ToString();
            txtTenNCC.Text = grdNCC[1, i].Value.ToString();
            txtDiaChi.Text = grdNCC[2, i].Value.ToString();
            txtSDT.Text = grdNCC[3, i].Value.ToString();
        }

    }
}
