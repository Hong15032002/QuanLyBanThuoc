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
    public partial class frmHDNhap : Form
    {
        function fn = new function();
        string sql;
        double sl, slt;
        double tong = 0;
 

        public frmHDNhap()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }

        private void grdNhap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
          
        }
        private void ResetValues()
        {
            txtMaHD.Text = "";
            dtpNhap.Text = DateTime.Now.ToShortDateString();
            cbMT.Text = "";           
            txtTong.Text = "0";                    
            txtSL.Text = "";          
            txtTT.Text = "0";
            txtDC.Text = "";
            cboTenNB.Text = "";
            txtSDT.Text = "";
            txtTenThuoc.Text = "";
            txtDG.Text = "";
        }
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cbMaThuoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comMT_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtMaThuoc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }

        private void cbMT_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cbMT.GetItemText(cbMT.SelectedItem);
            cbMT.Text = name;
            sql= "Select TenThuoc,DGnhap from tblThuoc where MaThuoc='"+name+"'";
            DataTable dt1 = fn.getdt(sql);
            txtTenThuoc.Text = dt1.Rows[0][0].ToString();
            txtDG.Text = dt1.Rows[0][1].ToString();

        }
        private void Loadgrd()
        {
            sql = "SELECT a.MaThuoc, b.TenThuoc, a.SoLuong, b.DGnhap, a.ThanhTien FROM tblCTNhap AS a, tblThuoc AS b WHERE a.MaHDnhap = N'" + txtMaHD.Text + "' AND a.MaThuoc = b.MaThuoc";
            DataTable dt = fn.getdt(sql);
            grdNhap.DataSource = dt;
            grdNhap.Columns[0].HeaderText = "Mã thuốc";
            grdNhap.Columns[1].HeaderText = "Tên thuốc";
            grdNhap.Columns[2].HeaderText = "Đơn giá";
            grdNhap.Columns[3].HeaderText = "Số lượng";
            grdNhap.Columns[4].HeaderText = "Thành tiền";
        }
        private void LoadTTC()
        {
            sql = "Select TenNB from tblNhap1 where MaHDnhap=N'" + txtMaHD.Text + "'";
            cboTenNB.Text = fn.GetValues(sql);
            sql = "Select DcNB from tblNhap1 where MaHDnhap=N'" + txtMaHD.Text + "'";
            txtDC.Text = fn.GetValues(sql);
            sql = "Select SdtNB from tblNhap1 where MaHDnhap=N'" + txtMaHD.Text + "'";
            txtSDT.Text = fn.GetValues(sql);
            sql = "Select NgayNhap from tblNhap1 where MaHDnhap=N'" + txtMaHD.Text + "'";
            dtpNhap.Text = fn.GetValues(sql);
            sql = "Select TongTien from tblNhap1 where MaHDnhap=N'" + txtMaHD.Text + "'";
            txtTong.Text = fn.GetValues(sql);
        }
        private void frmHDNhap_Load(object sender, EventArgs e)
        {
            Loadgrd();
            sql = "Select MaThuoc from tblThuoc";
            DataTable dt1 = fn.getdt(sql);         
            cbMT.DisplayMember = "MaThuoc";
            cbMT.DataSource = dt1;
         
            sql = "Select TenNCC from tblNCC";
            DataTable dt2 = fn.getdt(sql);
            cboTenNB.DisplayMember = "TenNCC";
            cboTenNB.DataSource = dt2;

            if (txtMaHD.Text != "")
            {
                LoadTTC();
                btnDel.Enabled = true;
                btnPrint.Enabled = true;
                btnDelall.Enabled = true;
            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            
   
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
         
        }

        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtMaHD_TextChanged_1(object sender, EventArgs e)
        {
         
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            ResetValues();
            txtMaHD.Text = fn.CreateKey("HDN");
            /*int i;
            i = grdNhap.CurrentRow.Index;
            txtMaHD.Text = "HDN001" + i + 1;*/
            //txtMaHD.Text = "";
            Loadgrd();
            txtDC.Enabled = true;
            txtSDT.Enabled = true;
            txtSL.Enabled = true;
            dtpNhap.Enabled = true;
            cbMT.Enabled = true;
            cboTenNB.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            sql = "Select MaHDnhap from tblNhap1 where MaHDnhap='" + txtMaHD.Text + "'";
            if (!fn.CheckKey(sql))
            {
                sql = "Insert into tblNhap1(MaHDnhap,TenNB,DcNB,SdtNB,NgayNhap,TongTien) Values ('" + txtMaHD.Text + "',N'" + cboTenNB.Text + "',N'" + txtDC.Text + "','" + txtSDT.Text + "','" + dtpNhap.Text + "', " + tong + " )";
                fn.setdata(sql);
            }
            sql = "SELECT MaThuoc FROM tblCTnhap WHERE MaThuoc=N'" + cbMT.Text + "' AND MaHDnhap = N'" + txtMaHD.Text + "'";
            if (fn.CheckKey(sql))
            {
                MessageBox.Show("Thuốc này đã nhập trong hóa đơn, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetValuesThuoc();
                cbMT.Focus();
                return;
            }
            sql = "Select MaThuoc from tblthuoc where MaThuoc=N'" + cbMT.Text + "'";
            if (!fn.CheckKey(sql))
            {               
                double nhap = Convert.ToDouble(txtDG.Text);
                double ban = nhap * 0.5 + nhap;
                sql = "Insert into tblthuoc (Mathuoc,tenthuoc,dgnhap,dgban,hsd) Values ('" + cbMT.Text + "',N'" + txtTenThuoc.Text + "'," + nhap + "," + ban + ",'" + dtpHSD.Text + "')";
                fn.setdata(sql);
                sql = "Insert into tblTon(mathuoc,slton,tenthuoc,dg) values ('" + cbMT.Text + "','"+txtSL.Text+"',N'" + txtTenThuoc.Text + "'," + ban + ")";
                fn.setdata(sql);
                sql = "Insert into tblCTNhap (MaHDnhap,MaThuoc,TenThuoc,DGnhap,SoLuong,ThanhTien) Values ('" + txtMaHD.Text + "','" + cbMT.Text + "',N'" + txtTenThuoc.Text + "'," + nhap + "," + txtSL.Text + "," + txtTT.Text + ")";
                fn.setdata(sql);
                Loadgrd();                            
            }
            else
            {
                sql = "Insert into tblCTNhap (MaHDnhap,MaThuoc,TenThuoc,DGnhap,SoLuong,ThanhTien) Values ('" + txtMaHD.Text + "','" + cbMT.Text + "',N'" + txtTenThuoc.Text + "'," + txtDG.Text + "," + txtSL.Text + "," + txtTT.Text + ")";
                fn.setdata(sql);
                Loadgrd();
                sql = "Select SLTon from tblTon where MaThuoc='" + cbMT.Text + "'";
                sl = Double.Parse(fn.GetValues(sql));
                slt = sl + Double.Parse(txtSL.Text);
                sql = "Update tblTon set SLTon=" + slt + " where MaThuoc='" + cbMT.Text + "'";
                fn.setdata(sql);
            } 
            tong = tong + Convert.ToDouble(txtTT.Text);
            txtTong.Text = tong.ToString();
            sql = "Update tblNhap1 set TongTien= " + tong + " where MaHDnhap=N'" + txtMaHD.Text + "'";
            fn.setdata(sql);
            MessageBox.Show("Đã thêm mới thành công");   
            ResetValuesThuoc();
            btnDelall.Enabled = true;
            btnDel.Enabled = true;
            txtDC.Enabled = true;
            txtSDT.Enabled = true;
            txtSL.Enabled = true;
            dtpNhap.Enabled = true;
            cbMT.Enabled = true;
            cboTenNB.Enabled = true;
        }

        private void txtTT_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSL.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSL.Text);                     
            if (txtDG.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDG.Text);
            tt = sl * dg;
            txtTT.Text = tt.ToString();
        }

        private void txtTong_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa bản ghi hiện tại?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string MaThuocxoa;
                double ThanhTienxoa, SoLuongxoa, sl, slcon, tong1, tongmoi;              
                MaThuocxoa = grdNhap.CurrentRow.Cells["MaThuoc"].Value.ToString();
                SoLuongxoa = Convert.ToDouble(grdNhap.CurrentRow.Cells["SoLuong"].Value.ToString());
                ThanhTienxoa = Convert.ToDouble(grdNhap.CurrentRow.Cells["ThanhTien"].Value.ToString());
                sl = Convert.ToDouble(fn.GetValues("SELECT SLTon FROM tblTon WHERE MaThuoc = N'" + MaThuocxoa + "'"));
                slcon = sl - SoLuongxoa;
                sql = "UPDATE tblTon SET SLTon =" + slcon + " WHERE MaThuoc= N'" + MaThuocxoa + "'";
                fn.setdata(sql);       
                tong1 = Convert.ToDouble(txtTong.Text);
                tongmoi = tong1 - ThanhTienxoa;
                sql = "UPDATE tblNhap1 SET TongTien =" + tongmoi + " WHERE MaHDnhap = N'" + txtMaHD.Text + "'";
                fn.setdata(sql);
                txtTong.Text = tongmoi.ToString();
                sql = "DELETE tblCTNhap WHERE MaHDnhap=N'" + txtMaHD.Text + "' AND MaThuoc = N'" + MaThuocxoa + "'";
                fn.setdata(sql);
                grdNhap.Rows.RemoveAt(grdNhap.CurrentRow.Index);
                Loadgrd();
                txtDC.Enabled = true;
                txtSDT.Enabled = true;
                txtSL.Enabled = true;
                dtpNhap.Enabled = true;
                cbMT.Enabled = true;
                cboTenNB.Enabled = true;
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelall_Click(object sender, EventArgs e)
        {
            int i;
            double sl, slcon, slxoa;
            if (MessageBox.Show("Bạn có chắc muốn xóa Hóa đơn hiện tại?", "Xác nhận yêu cầu", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                string sql = "SELECT MaThuoc,SoLuong FROM tblctnhap WHERE MaHDnhap = N'" + txtMaHD.Text + "'";
                DataTable dt7 = fn.getdt(sql);
                for (i = 0; i <= dt7.Rows.Count - 1; i++)
                {
                    sl = Convert.ToDouble(fn.GetValues("SELECT Slton FROM tblton WHERE MaThuoc = N'" + dt7.Rows[i][0].ToString() + "'"));
                    slxoa = Convert.ToDouble(dt7.Rows[i][1].ToString());
                    slcon = sl - slxoa;
                    sql = "UPDATE tblton SET Slton =" + slcon + " WHERE MaThuoc= N'" + dt7.Rows[i][0].ToString() + "'";
                    fn.setdata(sql);
                }

                sql = "DELETE tblctnhap WHERE MaHDnhap=N'" + txtMaHD.Text + "'";
                fn.setdata(sql);

                sql = "DELETE tblnhap1 WHERE MaHDnhap=N'" + txtMaHD.Text + "'";
                fn.setdata(sql);
                ResetValues();
                Loadgrd();
                btnDelall.Enabled = false;
                
            }
        }

        private void cbMaHD_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (cbMaHD.Text == "")
            {
                MessageBox.Show("Bạn phải chọn một mã hóa đơn để tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cbMaHD.Focus();
            }
            txtMaHD.Text = cbMaHD.Text;
            LoadTTC();
            Loadgrd();
            btnDelall.Enabled = true;
            btnSave.Enabled = true;
            btnDel.Enabled = true;
            txtDC.Enabled = true;
            txtSDT.Enabled = true;
            txtSL.Enabled = true;
            dtpNhap.Enabled = true;
            cbMT.Enabled = true;
        }

        private void cbMaHD_DropDown(object sender, EventArgs e)
        {
            sql = "Select MaHDnhap from tblNhap1";
            DataTable dt8 = fn.getdt(sql);
            cbMaHD.DisplayMember = "MaHDnhap";
            cbMaHD.DataSource = dt8;          
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            sql = "Select tenthuoc,dgnhap,soluong,thanhtien from tblctnhap where mahdnhap='" + txtMaHD.Text + "'";
            DataTable dt11 = fn.getdt(sql);
            rptNhap rpt = new rptNhap();
            rpt.SetDataSource(dt11);
            rpt.DataDefinition.FormulaFields["mahd"].Text = "'" + txtMaHD.Text + "'";
            rpt.DataDefinition.FormulaFields["tennb"].Text = "'" + cboTenNB.Text + "'";
            rpt.DataDefinition.FormulaFields["diachi"].Text = "'" + txtDC.Text + "'";
            rpt.DataDefinition.FormulaFields["sdt"].Text = "'" + txtSDT.Text + "'";
            inHDnhap f = new inHDnhap(rpt);
            f.Show();
        }

        private void frmHDNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            ResetValues();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dt1 = dtp1.Value.ToString("dd-MM-yyyy");
            string dt2 = dtp2.Value.ToString("dd-MM-yyyy");
            string s = dtp1.Text;
            string[] t = s.Split('/');
            s = t[2].Substring(0, 4) + '-' + t[0] + '-' + t[1];

            string s2 = dtp2.Text;
            t = s2.Split('/');
            s2 = t[2].Substring(0, 4) + '-' + t[0] + '-' + t[1];
            sql = "Select MaHdnhap,tongtien,tenNB,dcnb from tblNhap1 where ngaynhap BETWEEN '" + s + "' AND '" + s2 + "'";
            DataTable dt10 = fn.getdt(sql);
            rptHDNhap rpt = new rptHDNhap();
            rpt.SetDataSource(dt10);
            rpt.DataDefinition.FormulaFields["tu"].Text = "'" + dt1 + "'";
            rpt.DataDefinition.FormulaFields["den"].Text = "'" + dt2 + "'";
            rptNhapprv f = new rptNhapprv(rpt);
            f.Show();
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cboTenNB_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = cboTenNB.GetItemText(cboTenNB.SelectedItem);
            cboTenNB.Text = name;
            sql = "Select DiachiNCC, SDTNCC from tblNCC where TenNCC='" + name + "'";
            DataTable dt2 = fn.getdt(sql);
            txtDC.Text = dt2.Rows[0][0].ToString();
            txtSDT.Text = dt2.Rows[0][1].ToString();
        }

        private void ResetValuesThuoc()
        {
            cbMT.Text = "";
            txtSL.Text = "";         
            txtTT.Text = "0";
            txtTenThuoc.Text = "";
            txtDG.Text = "";
        }
    }
}
