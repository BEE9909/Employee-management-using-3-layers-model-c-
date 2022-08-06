using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_NhanVien;
using DTO_NhanVien;

namespace BUS_NhanVien
{
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> LayChucVu()
        {
            return ChucVu_Dao.LayChucVu();
        }
    }
}
