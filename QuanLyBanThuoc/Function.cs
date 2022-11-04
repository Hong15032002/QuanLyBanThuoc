using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyBanThuoc
{
    class function
    {
        protected SqlConnection getconnect()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=ADMIN;Initial Catalog=QLBThuoc;Integrated Security=True";
            return conn;
        }

        public DataTable getdt(String query)
        {
            SqlConnection conn = getconnect();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt;
        }

        public void setdata(String query)
        {
            SqlConnection conn = getconnect();
            SqlCommand cmd = new SqlCommand(query, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public string ConvertTimeTo24(String hour)
        {
            
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        public string CreateKey (String tiento)
        {

            string key = tiento;
             string[] partsDay;
             partsDay = DateTime.Now.ToShortDateString().Split('/');         
             string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
             key = key + d;
             string[] partsTime;
             partsTime = DateTime.Now.ToLongTimeString().Split(':');          
             if (partsTime[2].Substring(3, 2) == "PM")
                 partsTime[0] = ConvertTimeTo24(partsTime[0]);
             if (partsTime[2].Substring(3, 2) == "AM")
                 if (partsTime[0].Length == 1)
                     partsTime[0] = "0" + partsTime[0];
             //Xóa ký tự trắng và PM hoặc AM
             partsTime[2] = partsTime[2].Remove(2, 3);
             string t;
             t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
             key = key + t;
             return key;
        }
        public string GetValues (String query)
        {
            SqlConnection conn = getconnect();
            string ma = "";
            SqlCommand cmd = new SqlCommand(query ,conn);
            conn.Open();
            SqlDataReader reader;          
            reader = cmd.ExecuteReader();           
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            return ma;
        }
        public bool CheckKey(string sql)
        {
            SqlConnection conn = getconnect();
            SqlDataAdapter dap = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            dap.Fill(table);
            if (table.Rows.Count > 0)
                return true;
            else return false;
        }

    }
}
