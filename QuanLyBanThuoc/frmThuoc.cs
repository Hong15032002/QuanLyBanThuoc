using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanThuoc
{
    public partial class frmThuoc : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        string connstr, sql;
        int i;
        SqlCommand cmd;
        Boolean AddNewFlag = false;
        string tMT, tTT, tNhap, tBan, tHsd;
        float tt;
        public frmThuoc()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdThuoc.CurrentCell = grdThuoc[0, 0];
        }

        private void frmThuoc_Load(object sender, EventArgs e)
        {
            connstr = "Data Source=DESKTOP-Q3538V7\\SQLEXPRESS;Initial Catalog=QLBT1;Integrated Security=True";
            conn.ConnectionString = connstr;
            conn.Open();
            sql = "Select * From tblThuoc order by MaThuoc";
            da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            grdThuoc.DataSource = dt;
            grdThuoc.Refresh();
            NapCT();
        }
        public void NapCT()
        {
            i = grdThuoc.CurrentRow.Index;
            txtMT.Text = grdThuoc[0, i].Value.ToString();
            txtTT.Text = grdThuoc[1, i].Value.ToString();
            txtNhap.Text = grdThuoc[2, i].Value.ToString();
            txtBan.Text = grdThuoc[3, i].Value.ToString();
            txtHSD.Text = grdThuoc.Rows[i].Cells["HSD"].Value.ToString();     
        }

        private void grdThuoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            i = grdThuoc.CurrentRow.Index;
            if(i>0)
            {
                grdThuoc.CurrentCell = grdThuoc[0, i - 1];
                NapCT();
            }   
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdThuoc.CurrentRow.Index;
            if(i<grdThuoc.RowCount-1)
            {
                grdThuoc.CurrentCell = grdThuoc[0, i + 1];
                NapCT();
            }    
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdThuoc.CurrentCell = grdThuoc[0, grdThuoc.RowCount - 1];
            NapCT();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi hiện tại?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From tblThuoc where MaThuoc='" + txtMT.Text + "'";
                grdThuoc.Rows.RemoveAt(grdThuoc.CurrentRow.Index); 
                cmd = new SqlCommand(sql, conn); 
                cmd.ExecuteNonQuery();
            }
        }

        private void frmThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void txtMT_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNhap_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtBan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
        
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTT.Focus();
            AddNewFlag = false;
            btnUpdate.Enabled = true;
            grdThuoc.Enabled = true;
            grdThuoc.Focus();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (AddNewFlag)
            {
                sql = "Insert into tblThuoc (MaThuoc,TenThuoc,DGnhap,DGban,HSD) Values ('" + txtMT.Text + "',N'" + txtTT.Text + "'," + txtNhap.Text + "," + txtBan.Text + ",'" + txtHSD.Text + "')";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã thêm mới thành công");
                AddNewFlag = false;
                btnUpdate.Enabled = false;
                i = grdThuoc.CurrentRow.Index;
                grdThuoc[0, i].Value = txtMT.Text;
                grdThuoc[1, i].Value = txtTT.Text;
                grdThuoc[2, i].Value = txtNhap.Text;
                grdThuoc[3, i].Value = txtBan.Text;
                grdThuoc[4, i].Value = txtHSD.Text;                
                sql="Insert into tblTon(Mathuoc,slton,tenthuoc,dg) values ('"+txtMT.Text+"',"+0+",N'" + txtTT.Text + "'," + txtBan.Text + ")";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            else
            {
                for (i = 0; i < grdThuoc.RowCount - 1; i++)
                {
                    tTT = grdThuoc[1, i].Value.ToString();
                    tNhap = grdThuoc[2, i].Value.ToString();
                    tBan = grdThuoc[3, i].Value.ToString();
                    tHsd = grdThuoc[4, i].Value.ToString();                  
                    sql = "Update tblThuoc set TenThuoc=N'" + tTT + "', DGnhap='" + tNhap + "',DGban='" + tBan + "',HSD='" + tHsd + "' where MaThuoc='" + grdThuoc[0, i].Value.ToString() + "'";
                    cmd = new SqlCommand(sql, conn); 
                    cmd.ExecuteNonQuery();
                    sql = "Update tblton set tenthuoc=N'" + tTT + "',dg='" + tBan + "' where MaThuoc='" + grdThuoc[0, i].Value.ToString() + "'";
                    cmd = new SqlCommand(sql, conn);
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Đã cập nhật thành công", "Thông báo");
                btnUpdate.Enabled = false;
                grdThuoc.Enabled = false;

            }

        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            grdThuoc.CurrentCell = grdThuoc[0, grdThuoc.RowCount - 1];
            NapCT();
            AddNewFlag = true;
            txtMT.Focus();
            btnUpdate.Enabled = true;
        }

        private void dtpHSD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
