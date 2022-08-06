using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_NhanVien;
using System.Data;
using System.Data.SqlClient;

namespace DAL_NhanVien
{
   public class NguoiDung_Dao
    {
        private static SqlConnection con;

        public static NguoiDung_DTO DangNhap(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"Select * from nguoidung where ten like '{0}' and matkhau like '{1}'", ten, matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.Ten = dt.Rows[0]["ten"].ToString();
                nd.Matkhau = dt.Rows[0]["matkhau"].ToString();
                nd.Quyen = byte.Parse(dt.Rows[0]["quyen"].ToString());
                DataProvider.DongKetNoi(con);
                return nd;
            }
        }
        public static List<NguoiDung_DTO> LayND()
        {
            string sTruyVan = "select ten,matkhau,quyen from nguoidung";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<NguoiDung_DTO> lstND = new List<NguoiDung_DTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.Ten = dt.Rows[i]["ten"].ToString();
                nd.Matkhau = dt.Rows[i]["matkhau"].ToString();
                nd.Quyen = byte.Parse(dt.Rows[i]["quyen"].ToString());
                lstND.Add(nd);
            }
            return lstND;
        }
        public static NguoiDung_DTO TimMK(string mkct, string ten)
        {
            string sTruyVan = string.Format(@"Select matkhau from nguoidung where matkhau like '{0}' and ten = '{1}'", mkct, ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.Matkhau = dt.Rows[0]["matkhau"].ToString();
                DataProvider.DongKetNoi(con);
                return nd;
            }
        }
        public static bool DoiMk(string ten, string mk)
        {
            string sTruyVan = string.Format(@"Update  nguoidung set matkhau = '{0}' where ten like '{1}'", mk, ten);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDulieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }
        public static bool ThemND(int quyen, string ten, string mk)
        {
            string sTruyVan = string.Format(@"insert into nguoidung(ten,matkhau,quyen) values('{0}','{1}',{2})", ten, mk, quyen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDulieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
        public static bool CapNhat(int quyen, string ten, string mk)
        {
            string sTruyVan = string.Format(@"update nguoidung set quyen ='{0}', matkhau = '{1}' where ten = '{2}'",quyen,mk,ten);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDulieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }

        public static bool xoaNguoiDung(string ten)
        {
            string sTruyVan = string.Format(@"Delete nguoidung where ten = '{0}'", ten);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDulieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;

        }
        public static NguoiDung_DTO TimTen(string ten)
        {
            string sTruyVan = string.Format(@"select ten from nguoidung where ten like '{0}'", ten);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.Matkhau = dt.Rows[0]["ten"].ToString();
                DataProvider.DongKetNoi(con);
                return nd;
            }
        }
    }
}
