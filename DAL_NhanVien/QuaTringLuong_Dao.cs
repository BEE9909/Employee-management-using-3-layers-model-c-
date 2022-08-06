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
   public class QuaTringLuong_Dao
    {
        private static SqlConnection con;
        public static List<QuaTrinhLuong_DTO> layQTLuong()
        {
            string sTruyVan = "select * from quatrinhluong";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<QuaTrinhLuong_DTO> lstLuong = new List<QuaTrinhLuong_DTO>();
            for(int i = 0; i<dt.Rows.Count; i++)
            {
                QuaTrinhLuong_DTO qt = new QuaTrinhLuong_DTO();
                qt.Manv = dt.Rows[i]["manv"].ToString();
                qt.Ngaybd = DateTime.Parse(dt.Rows[i]["ngaybd"].ToString());
                qt.Hsluong = float.Parse(dt.Rows[i]["hsluong"].ToString());
                lstLuong.Add(qt);
            }
            return lstLuong;
        }
        public static List<QuaTrinhLuong_DTO> TimTheoNgay(string ngaybd, string ngaykt)
        {

            string sTruyVan = string.Format(@"select * from quatrinhluong where ngaybd>='{0}' and ngaybd <='{1}'", ngaybd,ngaykt);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<QuaTrinhLuong_DTO> lstLuong = new List<QuaTrinhLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuaTrinhLuong_DTO qt = new QuaTrinhLuong_DTO();
                qt.Manv = dt.Rows[i]["manv"].ToString();
                qt.Ngaybd = DateTime.Parse(dt.Rows[i]["ngaybd"].ToString());
                qt.Hsluong = float.Parse(dt.Rows[i]["hsluong"].ToString());
                lstLuong.Add(qt);
            }
            DataProvider.DongKetNoi(con);
            return lstLuong;
        }
    }
}
