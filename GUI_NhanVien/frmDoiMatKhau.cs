using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_NhanVien
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }
        public string ten = "";

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTenDN.ReadOnly = true;
            txtTenDN.Text = ten;
            txt_mkcu.UseSystemPasswordChar = true;
            txt_mkMoi.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                txt_mkcu.UseSystemPasswordChar = false;
                txt_mkMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txt_mkcu.UseSystemPasswordChar = true;
                txt_mkMoi.UseSystemPasswordChar = true;
            }
        }
    }
}
