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
    public partial class frmHethan : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd;
        DataTable dt = new DataTable();
        DataTable dtcom = new DataTable();
        string sql, connstr;
        int i;
        Boolean AddNewFlag = false;
        public frmHethan()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void frmHethan_Load(object sender, EventArgs e)
        {
            connstr = @"Data Source=DESKTOP-Q3538V7\SQLEXPRESS;Initial Catalog=QLBT1;Integrated Security=True";
            conn.ConnectionString = connstr;

            conn.Open(); // mở kết nối với CSDL
            sql = "Select MaThuoc,TenThuoc,DG,HSD from tblHethan order by MaThuoc";
            da = new SqlDataAdapter(sql, conn); //thực hiện câu lệnh truy vấn CSDL
            da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt
            grdHethan.DataSource = dt; // khai báo nguồn dữ liệu của ô lưới 
            grdHethan.Refresh();
            sql = "Select MaThuoc from tblThuoc";
            SqlCommand cmd2 = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd2);
            DataTable dt3 = new DataTable();
            sda.Fill(dt3);
            cbMT.DisplayMember = "MaThuoc";
            cbMT.DataSource = dt3;
            NapCT();
        }
        public void NapCT()
        {

            i = grdHethan.CurrentRow.Index;// i lấy stt dòng hiện thời trong ô lưới 
            cbMT.Text = grdHethan[0, i].Value.ToString();
            txtTenThuoc.Text = grdHethan[1, i].Value.ToString();
            txtDG.Text = grdHethan[2, i].Value.ToString();
            txtHSD.Text = grdHethan[3, i].Value.ToString();
            //txtMaThuoc.Text = grdHethan[0, i].Value.ToString(); // lấy giá trị của cột 0 dòng i trong ô lưới 
            // txtTenThuoc.Text = grdHethan[1, i].Value.ToString();
            // txtDG.Text = grdHethan[2, i].Value.ToString();
            // txtHSD.Text = grdHethan[3, i].Value.ToString();

        }

        private void btnFisrt_Click(object sender, EventArgs e)
        {
            grdHethan.CurrentCell = grdHethan[0, 0]; // đưa về vị trí đầu tiên
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdHethan.CurrentRow.Index; // i lấy stt của dòng hiện thời trong ô lưới 
            if (i > 0)
            {
                grdHethan.CurrentCell = grdHethan[0, i - 1]; // ô hiện thời chuyển về vị trí cột 0 dòng i-1
                NapCT();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdHethan.CurrentRow.Index; // i lấy stt của dòng hiện thời trong ô lưới
            if (i < grdHethan.RowCount - 1)
            {
                grdHethan.CurrentCell = grdHethan[0, i + 1]; // ô hiện thời chuyển về vị trí cột 0 dòng i+1 
                NapCT();
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            grdHethan.CurrentCell = grdHethan[0, grdHethan.RowCount - 1];// ô hiện thời chuyển về vị trí cột 0 dòng cuối cùng
            NapCT();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi hiện thời?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                sql = "Delete From tblHethan where TenThuoc='" + txtTenThuoc.Text + "'";
                grdHethan.Rows.RemoveAt(grdHethan.CurrentRow.Index); // xóa dòng hiện thời của ô lưới 
                SqlCommand cmd = new SqlCommand(sql, conn); // khai báo 1 câu lệnh sql chuẩn bị thực hiện 
                cmd.ExecuteNonQuery(); //thực hiện câu lệnh sql không phải Seclect 
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (AddNewFlag)
            {
                //chỗ cập nhật thêm mới
                //sql = "Insert into tblThuoc(MaThuoc,TenThuoc,DGnhap,DGban)"
                sql = "Insert into tblHethan(MaThuoc,TenThuoc,DG,HSD) Values ('" + cbMT.Text + "', N'" + txtTenThuoc.Text + "','" + txtDG.Text + "','" + txtHSD.Text + "')";
                cmd = new SqlCommand(sql, conn);//khai báo 1 câu lệnh sql cb thực hiện 
                cmd.ExecuteNonQuery(); //thực hiện câu lệnh kp select 
                MessageBox.Show("Đã thêm mới thành công!");
                AddNewFlag = false;
                btnUpdate.Enabled = false;
                i = grdHethan.CurrentRow.Index;//i lấy stt của dòng hiện thời trong ô lưới
                grdHethan[0, i].Value = cbMT.Text;
                grdHethan[1, i].Value = txtTenThuoc.Text;
                grdHethan[2, i].Value = txtDG.Text;
                grdHethan[3, i].Value = txtHSD.Text;
              
            }
            else
            {
                //cập nhật sửa chữa
                sql = "Update tblHethan set TenThuoc=N'" + txtTenThuoc.Text + "',DG='" + txtDG.Text + "',Hsd='" + txtHSD.Text + "' Where MaThuoc ='" + cbMT.Text + "'";
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Đã cập nhật sửa chữa thành công!", "Thông báo");
                btnUpdate.Enabled = false;
                sql = "Select MaThuoc,TenThuoc,DG,HSD from tblHethan order by MaThuoc";
                da = new SqlDataAdapter(sql, conn); //thực hiện câu lệnh truy vấn CSDL
                dt.Clear();
                da.Fill(dt); // đổ dữ liệu vừa truy vấn được vào bảng dt
                grdHethan.DataSource = dt; // khai báo nguồn dữ liệu của ô lưới 
                grdHethan.Refresh();
                NapCT();

            }
        }

        private void comTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            grdHethan.CurrentCell = grdHethan[0, grdHethan.RowCount - 1];// ô hiện thời chuyển về vị trí cột 0 dòng cuối cùng
            NapCT();
            AddNewFlag = true;
            cbMT.Focus();
            btnUpdate.Enabled = true;
        }

        private void grdHethan_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void comGiaTri_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
           
        }

        private void cbMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbMT.GetItemText(cbMT.SelectedItem);
            cbMT.Text = name;
            sql = "Select TenThuoc,DGban,HSD from tblThuoc where MaThuoc='" + name + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt2 = new DataTable();
            sda.Fill(dt2);
            txtTenThuoc.Text = dt2.Rows[0][0].ToString();
            txtDG.Text = dt2.Rows[0][1].ToString();
            txtHSD.Text = dt2.Rows[0][2].ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtTenThuoc.Focus();
            AddNewFlag = false;
            btnUpdate.Enabled = true;
        }

        private void txtDG_KeyPress(object sender, KeyPressEventArgs e)
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

        private void grdHethan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // NapCT();
        }

        
    }
}
