using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BUS_NhanVien;
using DTO_NhanVien;

namespace GUI_NhanVien
{
    public partial class frm_dmChucVu : Form
    {
        public frm_dmChucVu()
        {
            InitializeComponent();
        }

        private void frm_dmChucVu_Load(object sender, EventArgs e)
        {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            dataGridView1.DataSource = lstChucVu;
        }
    }
}
