using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_NhanVien
{
    public class ChucVu_DTO
    {
        private string maCV;
        private string tenCV;
        private float phuCap;

        public string MaCV
        {
            get
            {
                return maCV;
            }

            set
            {
                maCV = value;
            }
        }

        public string TenCV
        {
            get
            {
                return tenCV;
            }

            set
            {
                tenCV = value;
            }
        }

        public float PhuCap
        {
            get
            {
                return phuCap;
            }

            set
            {
                phuCap = value;
            }
        }
    }
}
