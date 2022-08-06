using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NhanVien;
using DAL_NhanVien;

namespace BUS_NhanVien
{
   public class NhanVien_BUS
    {
        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_Dao.ThemNhanVien(nv);
        }
        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_Dao.SuaNhanVien(nv);
        }
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_Dao.XoaNhanVien(nv);
        }
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            return NhanVien_Dao.TimNhanVienTheoMa(ma);
        }
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string holot, string ten)
        {
            return NhanVien_Dao.TimNhanVienTheoTen(holot, ten);
        }
        public static List<NhanVien_DTO> LayNhanVien()
        {
            return NhanVien_Dao.LayNhanVien();
        }
        public static List<NhanVien_DTO> LayTenCV()
        {
            return NhanVien_Dao.LayTenCV();
        }
    }
}
