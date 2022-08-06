using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_NhanVien;
using BUS_NhanVien;

namespace GUI_NhanVien
{
    public partial class fr_nvQuaTrinhLuong : Form
    {
        public fr_nvQuaTrinhLuong()
        {
            InitializeComponent();
        }

        private void fr_nvQuaTrinhLuong_Load(object sender, EventArgs e)
        {
            List<QuaTrinhLuong_DTO> lstquatrinh = QuaTrinhLuong_BUS.LayQTLuong();
            dataGridView1.DataSource = lstquatrinh;
        }

        private void rdHienTai_MouseClick(object sender, MouseEventArgs e)
        {
            dtpDenNgay.Enabled = false;
        }

        private void rdDenNgay_MouseClick(object sender, MouseEventArgs e)
        {
            dtpDenNgay.Enabled = true;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ngaybd = dtpNgay.Value.ToString("yyyy/MM/dd");
            try
            {
                if (rdDenNgay.Checked == false && rdHienTai.Checked == false)
                {
                    MessageBox.Show("vui lòng chọn thời gian cần tìm");
                    return;
                }
                else if (rdHienTai.Checked == true)
                {
                    DateTime dt = DateTime.Now;
                    string ngayhientai = dt.ToString("yyyy/MM/dd");
                    List<QuaTrinhLuong_DTO> lstngay = QuaTrinhLuong_BUS.TimTheoNgay(ngaybd, ngayhientai);
                    dataGridView1.DataSource = lstngay;
                    return;
                }
                else if (rdDenNgay.Checked == true)
                {
                    string denngay = dtpDenNgay.Value.ToString("yyyy/MM/dd");
                    List<QuaTrinhLuong_DTO> lstngay = QuaTrinhLuong_BUS.TimTheoNgay(ngaybd, denngay);
                    dataGridView1.DataSource = lstngay;
                    return;
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tìm thất bại");
            }
        }
    }
}
