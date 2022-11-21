using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLiCuaHang.DataTransferObject;

namespace QuanLiCuaHang.DataAccessLayer
{
    internal class DAL_HangHoa
    {
        private static DAL_HangHoa instance;
        public static DAL_HangHoa Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DAL_HangHoa();
                }
                return instance;
            }
            private set { }
        }
        public List<HangHoa> GetAllHangHoa()
        {
            List<HangHoa> data = new List<HangHoa>();
            string query = "select * from HangHoa";
            foreach (DataRow i in ConnectDatabase.Instance.GetRecord(query).Rows)
            {
                data.Add(GetHangHoaByDataRow(i));
            }
            return data;
        }
        public HangHoa GetHangHoaByDataRow(DataRow i)
        {
            return new HangHoa
            {
                MaMH = i["MaMH"].ToString(),
                TenMH = i["TenMH"].ToString(),
                DonGiaBan = Convert.ToDecimal(i["DonGiaBan"].ToString()),
                DonGiaMua = Convert.ToDecimal(i["DonGiaMua"].ToString()),
                SL = Convert.ToInt32(i["SL"].ToString()),
            };
        }
        public void UpdateHangHoa(HangHoa HangHoaCapNhat)
        {
            string query = "select * from HangHoa";
        }
        public void DeleteHangHoa(string MaHH)
        {
            string query = "select * from HangHoa";
        }
        public void CreateHangHoa(HangHoa HangHoaMoi)
        {
            string query = "select * from HangHoa";
        }
    }
}
