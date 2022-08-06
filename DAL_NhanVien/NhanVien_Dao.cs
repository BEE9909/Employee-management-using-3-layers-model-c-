using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NhanVien;
using System.Data.SqlClient;
using System.Data;

namespace DAL_NhanVien
{
   public class NhanVien_Dao
    {
        private static SqlConnection con;
        public static bool ThemNhanVien( NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"INSERT INTO nhanvien(manv,holot,ten,phai,ngaysinh,macv) VALUES(N'{0}',N'{1}',N'{2}',N'{3}','{4}',N'{5}')", nv.Manv, nv.Holot, nv.Ten, nv.Phai, nv.Ngaysinh, nv.Macv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDulieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format("UPDATE nhanvien set holot=N'{0}', ten = N'{1}',phai = N'{2}',ngaysinh = '{3}', macv = N'{4}' where manv = N'{5}'", nv.Holot, nv.Ten, nv.Phai, nv.Ngaysinh, nv.Macv, nv.Manv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDulieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format(@"DELETE nhanvien where manv=N'{0}'",nv.Manv);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDulieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        //Lay thong tin nhan co ma, tra vè null nếu không thấy
        public static NhanVien_DTO TimNhanVienTheoMa(string ma)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where manv = N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = dt.Rows[0]["manv"].ToString();
            nv.Holot = dt.Rows[0]["holot"].ToString();
            nv.Ten = dt.Rows[0]["tennv"].ToString();
            nv.Phai = dt.Rows[0]["phai"].ToString();
            nv.Ngaysinh = DateTime.Parse(dt.Rows[0]["ngaysinh"].ToString());
            nv.Macv = dt.Rows[0]["macv"].ToString();
            DataProvider.DongKetNoi(con);
            return nv;
        }
        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = @"Select n.*, c.tencv from nhanvien n, chucvu c where n.macv=c.macv";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Holot = dt.Rows[i]["holot"].ToString();
                nv.Ten = dt.Rows[i]["ten"].ToString();
                nv.Phai = dt.Rows[i]["phai"].ToString();
                nv.Ngaysinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.Macv = dt.Rows[i]["macv"].ToString();
                nv.Tencv = dt.Rows[i]["tencv"].ToString();
                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }
        public static List<NhanVien_DTO> LayTenCV()
        {

            string sTruyVan1 = "Select * from chucvu";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan1, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> layChucVu = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO cv = new NhanVien_DTO();
                cv.Macv = dt.Rows[i]["macv"].ToString();
                cv.Tencv = dt.Rows[i]["tencv"].ToString();
                layChucVu.Add(cv);
            }
            return layChucVu;
        }
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string holot, string ten)
        {
            string sTruyVan = string.Format(@"Select * from nhanvien where holot = N'{0}' or ten = N'{1}'", holot, ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Holot = dt.Rows[i]["holot"].ToString();
                nv.Ten = dt.Rows[i]["ten"].ToString();
                nv.Phai = dt.Rows[i]["phai"].ToString();
                nv.Ngaysinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.Macv = dt.Rows[i]["macv"].ToString();
                lstNhanVien.Add(nv);
            }
            DataProvider.DongKetNoi(con);
            return lstNhanVien;
        }
    }
}
