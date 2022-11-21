using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLiCuaHang.DataAccessLayer
{
    public class ConnectDatabase
    {
        private static ConnectDatabase _Instance;
        private SqlConnection cnn;
        private ConnectDatabase(string s)
        {
            cnn = new SqlConnection(s);
        }
        public static ConnectDatabase Instance
        {
            get
            {
                if (_Instance == null)
                {
                    string cnnstr = @"Data Source=QQUAN0147\SQLEXPRESS;Initial Catalog=QLBH_HOI;Integrated Security=True";
                    _Instance = new ConnectDatabase(cnnstr);
                }
                return _Instance;
            }
            private set { }
        }
        public DataTable GetRecord(string query)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, cnn);
            cnn.Open();
            da.Fill(dt);
            cnn.Close();
            return dt;

        }
        public void ExcuteDB(string query)
        {
            SqlCommand cmd = new SqlCommand(query, cnn);
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
