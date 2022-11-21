using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiCuaHang.DataTransferObject
{
    internal class Ban
    {
        public string MaHDB { get; set; }
        public string MaNV { get; set; }
        public string MaKH { get; set; }
        public DateTime NgayBH { get; set; }
        public decimal TongTien { get; set; }
    }
}
