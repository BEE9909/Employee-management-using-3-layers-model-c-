using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_NhanVien;
using System.Data;

namespace DAL_NhanVien
{
   public class ChucVu_Dao
    {
        static SqlConnection con;
        public static List<ChucVu_DTO> LayChucVu() {
            string sTruyVan = "select * from chucvu";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVu_DTO> lstChucVu = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.MaCV = dt.Rows[i]["macv"].ToString();
                cv.TenCV = dt.Rows[i]["tencv"].ToString();
                cv.PhuCap = float.Parse(dt.Rows[i]["hsphucap"].ToString());
                lstChucVu.Add(cv);
            }
            return lstChucVu;
        }
       
    }
}
