using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_NhanVien;
using DTO_NhanVien;


namespace GUI_NhanVien

{
    public partial class frm_dmNhanVien : Form
    {
        public frm_dmNhanVien()
        {
            InitializeComponent();
            
        }
        public void HienThiComboBox()
        {
            List<NhanVien_DTO> lstChucVu = NhanVien_BUS.LayTenCV();
            cboChucVu.DataSource = lstChucVu;
            cboChucVu.DisplayMember = "tencv";
            cboChucVu.ValueMember = "macv";
        }
        public void HienThiDSNhanVienLenDatagrid()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            dataGridView1.DataSource = lstNhanVien;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 kí tự!");
                return;
            }
            if (NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtMaNV.Text;
            nv.Holot = txtHoLot.Text;
            nv.Ten = txtTen.Text;
            if (rdNam.Checked == true)
            {
                nv.Phai = "Nam";
            }
            else
            {
                nv.Phai = "Nữ";
            }
            nv.Ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.Macv = cboChucVu.SelectedValue.ToString();
            if (NhanVien_BUS.ThemNhanVien(nv) == false)
            {
                MessageBox.Show("Không thêm được");
                return;
            }
            else
            {
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã thêm nhân viên.");
            }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            txtMaNV.Text = row.Cells[0].Value.ToString();
            txtHoLot.Text = row.Cells[1].Value.ToString();
            txtTen.Text = row.Cells[2].Value.ToString();
            if (row.Cells[3].Value.ToString().Equals("Nam"))
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
            dtpNgaySinh.Text = row.Cells[4].Value.ToString();
            cboChucVu.SelectedValue = row.Cells[5].Value.ToString();
        }

        private void frm_dmNhanVien_Load(object sender, EventArgs e)
        {
            HienThiComboBox();
            HienThiDSNhanVienLenDatagrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtMaNV.Text;
            nv.Holot = txtHoLot.Text;
            nv.Ten = txtTen.Text;
            if (rdNam.Checked == true)
            {
                nv.Phai = "Nam";
            }
            else
            {
                nv.Phai = "Nữ";
            }
            nv.Ngaysinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.Macv = cboChucVu.SelectedValue.ToString();
            if (NhanVien_BUS.SuaNhanVien(nv) == false)
            {
                MessageBox.Show("Không sửa được");
                return;
            }
            else
            {
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("sửa thành công nhân viên.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.Manv = txtMaNV.Text;
            if (NhanVien_BUS.XoaNhanVien(nv) == false)
            {
                MessageBox.Show("Không xóa được");
                return;
            }
            else
            {
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Xóa thành công nhân viên.");
            }
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            string holot = txtTimHo.Text;
            string ten = txtTimTen.Text;
            List<NhanVien_DTO> lstnv = NhanVien_BUS.TimNhanVienTheoTen(holot, ten);
            if(holot == "" || ten == "")
            {
                MessageBox.Show("Vui long nhap thong tin de tim");
                return;

            }
            if(lstnv == null)
            {
                MessageBox.Show("Tim khong thay");
                return;
            }
            dataGridView1.DataSource = lstnv;
        }
    }
}
