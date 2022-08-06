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
    public partial class frm_TaoMoi : Form
    {
        public frm_TaoMoi()
        {
            InitializeComponent();
            loaddata();
        }
        public void loaddata()
        {
            List<NguoiDung_DTO> lstND = NguoiDung_BUS.layND();
            dataGridView1.DataSource = lstND;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtTenTK.Text = row.Cells[0].Value.ToString();
                txtMK.Text = row.Cells[1].Value.ToString();
                txtQuyen.Text = row.Cells[2].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int a = Int32.Parse(txtQuyen.Text);
            if(txtTenTK.Text == "" || txtMK.Text == "" || txtQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if(NguoiDung_BUS.timTen(txtTenTK.Text) != null)
            {
                MessageBox.Show("Tên dùng đã tồn tại");
                return;
            }
            if(NguoiDung_BUS.ThemND(txtTenTK.Text,txtMK.Text,a) == false)
            {
                MessageBox.Show("Khong the them");
                return;
            }
            else
            {
                MessageBox.Show("them Thanh Cong");
                loaddata();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtQuyen.Text);
            if (txtTenTK.Text == "" || txtQuyen.Text == "" || txtMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            if (NguoiDung_BUS.timTen(txtTenTK.Text) == null)
            {
                MessageBox.Show("Không có tài khoản cần sửa");
                return;
            }
            if (NguoiDung_BUS.CapNhat(a, txtTenTK.Text, txtMK.Text) == false)
            {
                MessageBox.Show("Cập nhật thất bại");
                return;
            }
            else
            {
                MessageBox.Show("Cập nhật thành công");
                loaddata();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "")
            {
                MessageBox.Show("Vui long nhap nguoi dung can xoa");
            }
            if (NguoiDung_BUS.timTen(txtTenTK.Text) == null)
            {
                MessageBox.Show("Không có tên tài khoản này");
                return;
            }
            if (NguoiDung_BUS.xoaNguoiDung(txtTenTK.Text) == false)
            {
                MessageBox.Show("Khong the xoa ");
                return;
            }
            else
            {
                MessageBox.Show("Xoa thanh cong");
                loaddata();
            }
        }
    }
}
