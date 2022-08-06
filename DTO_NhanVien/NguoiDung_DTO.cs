using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_NhanVien
{
   public class NguoiDung_DTO
    {
        private string ten;
        private string matkhau;
        private byte quyen;

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

        public string Matkhau
        {
            get
            {
                return matkhau;
            }

            set
            {
                matkhau = value;
            }
        }

        public byte Quyen
        {
            get
            {
                return quyen;
            }

            set
            {
                quyen = value;
            }
        }
    }
}
