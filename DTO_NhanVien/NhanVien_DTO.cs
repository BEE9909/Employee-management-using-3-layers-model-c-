using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_NhanVien
{
  public class NhanVien_DTO
    {
        private string manv;
        private string holot;
        private string ten;
        private string phai;
        private DateTime ngaysinh;
        private string macv;
        private string tencv;

        public string Manv
        {
            get
            {
                return manv;
            }

            set
            {
                manv = value;
            }
        }

        public string Holot
        {
            get
            {
                return holot;
            }

            set
            {
                holot = value;
            }
        }

        public string Ten
        {
            get
            {
                return ten;
            }

            set
            {
                ten = value;
            }
        }

        public string Phai
        {
            get
            {
                return phai;
            }

            set
            {
                phai = value;
            }
        }

        public DateTime Ngaysinh
        {
            get
            {
                return ngaysinh;
            }

            set
            {
                ngaysinh = value;
            }
        }

        public string Macv
        {
            get
            {
                return macv;
            }

            set
            {
                macv = value;
            }
        }

        public string Tencv
        {
            get
            {
                return tencv;
            }

            set
            {
                tencv = value;
            }
        }
    }
}
