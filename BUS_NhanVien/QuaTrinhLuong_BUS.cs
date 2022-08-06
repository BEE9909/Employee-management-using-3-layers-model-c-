using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NhanVien;
using DAL_NhanVien;

namespace BUS_NhanVien
{
   public class QuaTrinhLuong_BUS
    {
        public static List<QuaTrinhLuong_DTO> LayQTLuong()
        {
            return QuaTringLuong_Dao.layQTLuong();
        }
        public static List<QuaTrinhLuong_DTO> TimTheoNgay(string ngaybd, string ngaykt)
        {
            return QuaTringLuong_Dao.TimTheoNgay(ngaybd, ngaykt);
        }
    }
}
