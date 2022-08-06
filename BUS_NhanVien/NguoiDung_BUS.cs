using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NhanVien;
using DAL_NhanVien;
using System.Security.Cryptography;

namespace BUS_NhanVien
{
  public class NguoiDung_BUS
    {
        public static NguoiDung_DTO DangNhap(string ten, string matkhau)
        {
            MD5 md5Hash = MD5.Create();
            string matkhauMH = NguoiDung_BUS.GetMd5Hash(md5Hash, matkhau);
            return NguoiDung_Dao.DangNhap(ten, matkhauMH);
        }
        // Hàm mã hóa
        // Tham khảo tạihttps://msdn.microsoft.com/enus/library/system.security.cryptography.md5.aspx 

        public static string GetMd5Hash(MD5 md5Hash, string input)
        {
            // Chuyển đổi chuỗi đầu vào thành một mảng byte và tính toán băm
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            //Tạo một Stringbuilder mới để thu thập các byte
            // và tạo một chuỗi 

            StringBuilder sBuilder = new StringBuilder();
            //  Lặp lại từng byte dữ liệu được băm
            //và định dạng từng cái dưới dạng chuỗi thập lục phân

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            //Trả về chuỗi thập lục phân.
            return sBuilder.ToString();
        }
        public static List<NguoiDung_DTO> layND()
        {
            return NguoiDung_Dao.LayND();
        }
        public static NguoiDung_DTO timMK(string mkct, string ten)
        {
            MD5 md5h = MD5.Create();
            string mkCT = NguoiDung_BUS.GetMd5Hash(md5h, mkct);
            return NguoiDung_Dao.TimMK(mkCT, ten);
        }

        public static bool DoiMk(string ten, string mk)
        {
            MD5 md5 = MD5.Create();
            string mkbm = NguoiDung_BUS.GetMd5Hash(md5, mk);
            return NguoiDung_Dao.DoiMk(ten, mkbm);
        }
        public static NguoiDung_DTO timTen(string ten)
        {
            return NguoiDung_Dao.TimTen(ten);
        }
        public static bool ThemND(string ten, string mk, int quyen)
        {
            MD5 md5 = MD5.Create();
            string mkbm = NguoiDung_BUS.GetMd5Hash(md5, mk);
            return NguoiDung_Dao.ThemND(quyen, ten, mkbm);
        }

        public static bool CapNhat(int quyen, string ten, string mk)
        {
            MD5 md5 = MD5.Create();
            string mkm = NguoiDung_BUS.GetMd5Hash(md5, mk);
            return NguoiDung_Dao.CapNhat(quyen, ten, mkm);
        }

        public static bool xoaNguoiDung(string ten)
        {
            return NguoiDung_Dao.xoaNguoiDung(ten);
        }
    }
}
