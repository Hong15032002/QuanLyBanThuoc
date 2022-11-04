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
    public partial class Banhanghoa : Form
    {
        function fn = new function();
        string sql;
        double sl, slt;
        double tong = 0;
        private void ResetValues()
        {
            txtMaHD.Text = "";
            dtpNgayBan.Text = DateTime.Now.ToShortDateString();
            cboMaThuoc.Text = "";
            txtTongtien.Text = "0";
            txtsoluong.Text = "";
            txtThanhtien.Text = "0";
            txtDiachi.Text = "";
            txtTenKhach.Text = "";
            txtDienthoai.Text = "";
            txtTenThuoc.Text = "";
            txtDongia.Text = "";
            txtMaKhach.Text = "";
        }
        private void LoadTTC()
        {
            sql = "Select MaKhach from tblBan1 where Mahdban =N'" + txtMaHD.Text + "'";
            txtMaKhach.Text = fn.GetValues(sql);
            sql = "Select NgayBan from tblBan1 where MaHDban=N'" + txtMaHD.Text + "'";
            dtpNgayBan.Text = fn.GetValues(sql);
            sql = "Select TongTien from tblBan1 where MaHDban=N'" + txtMaHD.Text + "'";
            txtTongtien.Text = fn.GetValues(sql);
        }
        public Banhanghoa()
        {
            InitializeComponent();
        }

        private void Banhanghoa_Load(object sender, EventArgs e)
        {
            Loadgrd();
            sql = "Select MaThuoc from tblThuoc";
            DataTable dt1 = fn.getdt(sql);
            cboMaThuoc.DisplayMember = "MaThuoc";
            cboMaThuoc.DataSource = dt1;
            sql = "Select MaKhach from tblKhach";
            DataTable dt9 = fn.getdt(sql);
            txtMaKhach.DisplayMember = "MaKhach";
            txtMaKhach.DataSource = dt9;
            if (txtMaHD.Text != "")
            {
                LoadTTC();
                btnDel.Enabled = true;
                btnDelall.Enabled = true;
            }
        }
        private void cboMaThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cboMaThuoc.GetItemText(cboMaThuoc.SelectedItem);
            cboMaThuoc.Text = name;
            sql = "Select TenThuoc,DGban from tblThuoc where MaThuoc='" + name + "'";
            DataTable dt2 = fn.getdt(sql);
            txtTenThuoc.Text = dt2.Rows[0][0].ToString();
            txtDongia.Text = dt2.Rows[0][1].ToString();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            ResetValues();
            //txtMaHD.Text = fn.CreateKey("HDB");
            txtMaHD.Text = "";
            Loadgrd();
            txtMaKhach.Enabled = true;
            txtsoluong.Enabled = true;
            dtpNgayBan.Enabled = true;
            cboMaThuoc.Enabled = true;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi hiện tại?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string MaThuocxoa;
                double ThanhTienxoa, SoLuongxoa, sl, slcon, tong, tongmoi;
                MaThuocxoa = dgvHH.CurrentRow.Cells["MaThuoc"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(dgvHH.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(dgvHH.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sl = Convert.ToDouble(fn.GetValues("SELECT SLTon FROM tblTon WHERE MaThuoc = N'" + MaThuocxoa + "'"));
                slcon = sl + SoLuongxoa;
                sql = "UPDATE tblTon SET SLTon =" + slcon + " WHERE MaThuoc= N'" + MaThuocxoa + "'";
                fn.setdata(sql);
                tong = Convert.ToDouble(fn.GetValues("SELECT TongTien FROM tblBan1 WHERE MaHDban = N'" + txtMaHD.Text + "'"));
                tongmoi = tong - ThanhTienxoa;
                sql = "UPDATE tblBan1 SET TongTien =" + tongmoi + " WHERE MaHDban = N'" + txtMaHD.Text + "'";
                fn.setdata(sql);
                txtTongtien.Text = tongmoi.ToString();
                sql = "DELETE tblCTBan WHERE MaHDban=N'" + txtMaHD.Text + "' AND MaThuoc = N'" + MaThuocxoa + "'";
                fn.setdata(sql);
                dgvHH.Rows.RemoveAt(dgvHH.CurrentRow.Index);
                Loadgrd();
                txtMaKhach.Enabled = true;
                txtsoluong.Enabled = true;
                dtpNgayBan.Enabled = true;
                cboMaThuoc.Enabled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql = "Select Makhach from tblkhach where Makhach=N'" + txtMaKhach.Text + "'";
            if (!fn.CheckKey(sql))
            {
                sql = "Insert into tblkhach(makhach,tenkhach,diachi,sdt) values ('" + txtMaKhach.Text + "',N'" + txtTenKhach.Text + "','" + txtDiachi.Text + "','" + txtDienthoai.Text + "')";
                fn.setdata(sql);
            }
            sql = "Select MaHDban from tblBan1 where MaHDban='" + txtMaHD.Text + "'";
            if (!fn.CheckKey(sql))
            {
                sql = "Insert into tblBan1(MaHDban, NgayBan, MaKhach, TongTien) Values ('" + txtMaHD.Text + "','" + dtpNgayBan.Text + "', '" + txtMaKhach.Text + "'," + tong + ")";
                fn.setdata(sql);
            }
            sql = "SELECT MaThuoc FROM tblCTban WHERE MaThuoc=N'" + cboMaThuoc.Text + "' AND MaHDBan = N'" + txtMaHD.Text + "'";
            if (fn.CheckKey(sql))
            {
                MessageBox.Show("Thuốc này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesThuoc();
                cboMaThuoc.Focus();
                return;
            }

            sl = Convert.ToDouble(fn.GetValues("SELECT slton FROM tblton WHERE Mathuoc = N'" + cboMaThuoc.Text + "'"));
            if (Convert.ToDouble(txtsoluong.Text) > sl)
            {
                MessageBox.Show("Số lượng mặt hàng này chỉ còn lại" + sl, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtsoluong.Text = "";
                txtsoluong.Focus();
                return;
            }
            sql = "Insert into tblCTBan (MaHDban,MaThuoc,TenThuoc,DGban,SoLuong,ThanhTien) Values ('" + txtMaHD.Text + "','" + cboMaThuoc.Text + "',N'" + txtTenThuoc.Text + "'," + txtDongia.Text + "," + txtsoluong.Text + "," + txtThanhtien.Text + ")";
            fn.setdata(sql);
            Loadgrd();
            tong = tong + Convert.ToDouble(txtThanhtien.Text);
            txtTongtien.Text = tong.ToString();
            sql = "Update tblBan1 set TongTien= " + tong + " where MaHDban=N'" + txtMaHD.Text + "'";
            fn.setdata(sql);
            MessageBox.Show("Đã thêm mới thành công");
            sql = "Select SLTon from tblTon where MaThuoc='" + cboMaThuoc.Text + "'";
            sl = Double.Parse(fn.GetValues(sql));
            slt = sl - Double.Parse(txtsoluong.Text);
            sql = "Update tblTon set SLTon=" + slt + " where MaThuoc='" + cboMaThuoc.Text + "'";
            fn.setdata(sql);
            ResetValuesThuoc();
            btnDelall.Enabled = true;
            btnDel.Enabled = true;
            txtMaKhach.Enabled = true;
            txtsoluong.Enabled = true;
            dtpNgayBan.Enabled = true;
            cboMaThuoc.Enabled = true;
        }
        private void txtsoluong_Leave(object sender, EventArgs e)
        {
            if (txtsoluong.Text != "")
            {
                double dg = Double.Parse(txtDongia.Text);
                double sl = Double.Parse(txtsoluong.Text);
                double tt = dg * sl;
                txtThanhtien.Text = tt.ToString();
            }
            else
            {
                txtThanhtien.Clear();
            }
        }

        private void Loadgrd()
        {
            sql = "SELECT a.MaThuoc, b.TenThuoc, a.SoLuong, b.DGban, a.ThanhTien FROM tblCTBan AS a, tblThuoc AS b WHERE a.MaHDban = N'" + txtMaHD.Text + "' AND a.MaThuoc = b.MaThuoc";
            DataTable dt = fn.getdt(sql);
            dgvHH.DataSource = dt;
            dgvHH.Columns[0].HeaderText = "Mã thuốc";
            dgvHH.Columns[1].HeaderText = "Tên thuốc";
            dgvHH.Columns[2].HeaderText = "Đơn giá";
            dgvHH.Columns[3].HeaderText = "Số lượng";
            dgvHH.Columns[4].HeaderText = "Thành tiền";
        }
        private void ResetValuesThuoc()
        {
            cboMaThuoc.Text = "";
            txtsoluong.Text = "";
            txtThanhtien.Text = "0";
        }

        private void btnDelall_Click(object sender, EventArgs e)
        {
            int i;
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc muốn xóa Hóa đơn hiện tại?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string sql = "SELECT MaThuoc,SoLuong FROM tblCTBan WHERE MaHDban = N'" + txtMaHD.Text + "'";
                DataTable dt7 = fn.getdt(sql);
                for (i = 0; i <= dt7.Rows.Count - 1; i++)
                {
                    sl = Convert.ToDouble(fn.GetValues("SELECT SlTon FROM tblTon WHERE MaThuoc = N'" + dt7.Rows[i][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(dt7.Rows[i][1].ToString());
                    slcon = sl + slxoa;
                    sql = "UPDATE tblton SET Slton =" + slcon + " WHERE MaThuoc= N'" + dt7.Rows[i][0].ToString() + "'";
                    fn.setdata(sql);
                }

                sql = "DELETE tblCTBan WHERE MaHDban=N'" + txtMaHD.Text + "'";
                fn.setdata(sql);

                sql = "DELETE tblBan1 WHERE MaHDban=N'" + txtMaHD.Text + "'";
                fn.setdata(sql);
                ResetValues();
                Loadgrd();
                btnDelall.Enabled = false;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                comMaHD.Focus();
                return;
            }
            txtMaHD.Text = comMaHD.Text;
            LoadTTC();
            Loadgrd();
            btnDelall.Enabled = true;
            btnSave.Enabled = true;
            btnDel.Enabled = true;
            comMaHD.SelectedIndex = -1;
        }
        private void txtMaKhach_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = txtMaKhach.GetItemText(txtMaKhach.SelectedItem);
            txtMaKhach.Text = name;
            sql = "Select Tenkhach,Diachi,sdt from tblkhach where Makhach='" + name + "'";
            DataTable dt2 = fn.getdt(sql);
            txtTenKhach.Text = dt2.Rows[0][0].ToString();
            txtDiachi.Text = dt2.Rows[0][1].ToString();
            txtDienthoai.Text = dt2.Rows[0][2].ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtsoluong_KeyPress(object sender, KeyPressEventArgs e)
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
        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
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
        private void Banhanghoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            
                sql = "Select tenthuoc,dgban,soluong,thanhtien from tblctban where mahdban='" + txtMaHD.Text + "'";
                DataTable dt11 = fn.getdt(sql);
                rptinHDban rpt = new rptinHDban();
                rpt.SetDataSource(dt11);
                rpt.DataDefinition.FormulaFields["mahd"].Text = "'" + txtMaHD.Text + "'";
                rpt.DataDefinition.FormulaFields["tenkhach"].Text = "'" + txtTenKhach.Text + "'";
                rpt.DataDefinition.FormulaFields["diachi"].Text = "'" + txtDiachi.Text + "'";
                rpt.DataDefinition.FormulaFields["sdt"].Text = "'" + txtDienthoai.Text + "'";
                inHDban f = new inHDban(rpt);
                f.Show();
            
        }
        private void comMaHD_DropDown(object sender, EventArgs e)
        {
            sql = "Select MaHDban from tblBan1";
            DataTable dt8 = fn.getdt(sql);
            comMaHD.DisplayMember = "MaHDban";
            comMaHD.DataSource = dt8;
        }

        private void txtMaKhach_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string name = txtMaKhach.GetItemText(txtMaKhach.SelectedItem);
            txtMaKhach.Text = name;
            sql = "Select Tenkhach,Diachi,sdt from tblkhach where Makhach='" + name + "'";
            DataTable dt2 = fn.getdt(sql);
            txtTenKhach.Text = dt2.Rows[0][0].ToString();
            txtDiachi.Text = dt2.Rows[0][1].ToString();
            txtDienthoai.Text = dt2.Rows[0][2].ToString();
        }

        private void cboMaThuoc_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string name = cboMaThuoc.GetItemText(cboMaThuoc.SelectedItem);
            cboMaThuoc.Text = name;
            sql = "Select TenThuoc,DGban from tblThuoc where MaThuoc='" + name + "'";
            DataTable dt2 = fn.getdt(sql);
            txtTenThuoc.Text = dt2.Rows[0][0].ToString();
            txtDongia.Text = dt2.Rows[0][1].ToString();
        }

        private void txtThanhtien_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMaThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void cboMaThuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtsoluong_TextChanged_1(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg;
            txtThanhtien.Text = tt.ToString();
        }

        private void txtsoluong_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtDienthoai_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dtpNgayBan_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTenKhach_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDiachi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDienthoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comMaHD_DropDown_1(object sender, EventArgs e)
        {
            sql = "Select MaHDban from tblBan1";
            DataTable dt8 = fn.getdt(sql);
            comMaHD.DisplayMember = "MaHDban";
            comMaHD.DataSource = dt8;
        }

        private void txtsoluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtsoluong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtsoluong.Text);
            if (txtDongia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDongia.Text);
            tt = sl * dg;
            txtThanhtien.Text = tt.ToString();
        }


    }
}
