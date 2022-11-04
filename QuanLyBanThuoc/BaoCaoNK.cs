﻿using System;
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
    public partial class BaoCaoNK : Form
    {
        function fn = new function();
        string sql;
        public BaoCaoNK()
        {
            InitializeComponent();
        }

        private void BaoCaoNK_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
