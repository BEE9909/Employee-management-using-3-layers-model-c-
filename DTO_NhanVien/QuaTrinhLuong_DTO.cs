using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_NhanVien
{
    public class QuaTrinhLuong_DTO
    {
        private string manv;
        private DateTime ngaybd;
        private float hsluong;
        private bool ghichu;

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

        public DateTime Ngaybd
        {
            get
            {
                return ngaybd;
            }

            set
            {
                ngaybd = value;
            }
        }

        public float Hsluong
        {
            get
            {
                return hsluong;
            }

            set
            {
                hsluong = value;
            }
        }

        public bool Ghichu
        {
            get
            {
                return ghichu;
            }

            set
            {
                ghichu = value;
            }
        }
    }
}
