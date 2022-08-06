using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;


namespace DAL_NhanVien
{
    public class DataProvider
    {
       
        public static SqlConnection MoKetNoi()
        {
           

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["kn"].ConnectionString.ToString();
          
            cn.Open();
            return cn;
          
        }
       
        public static void DongKetNoi(SqlConnection cn)
        {
            cn.Close();
        }
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {   
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        
        public static bool TruyVanKhongLayDulieu(string sTruyVan, SqlConnection KetNoi)
        {
            try
            {
                
                SqlCommand cm = new SqlCommand(sTruyVan, KetNoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
