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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        public static string ten = "";
        public bool bDangNhap;
        public NguoiDung_DTO NguoiDung;
        frm_htDangNhap fDN;
        frmDoiMatKhau dmk;

        private void HienThiMenu()
        {
            //Hien thi thong tin dang nhap len thanh trang thai
            if(bDangNhap == true)
            {
                tDangXuat.Enabled = true;
                tDoiMatKhau.Enabled = true;
                tDangNhap.Enabled = false;
                sttNguoiDung.Text = "Người dùng: " + NguoiDung.Ten;
                sttThoiGian.Text = "Thời điểm đăng nhập: " + DateTime.Now;
                // Hiển thị menu theo quyền, ví dụ: 
                // 1. quantri: sử dụng tất cả menu
                // 2. nhanvien: không sử dụng các menu: Danh mục, Nghiệp vụ 
                int iQuyen;
                if(NguoiDung == null)
                {
                    iQuyen = 0;
                }
                else
                {
                    iQuyen = int.Parse(NguoiDung.Quyen.ToString());
                }
                switch(iQuyen)
                {
                    case 1:
                        tChuongTrinh.Enabled = true;
                        tDanhMuc.Enabled = true;
                        tNghiepVu.Enabled = true;
                        tBaoCao.Enabled = true;
                        tHeThong.Enabled = true;
                        tGiupDo.Enabled = true;
                        break;
                    case 2:
                        tChuongTrinh.Enabled = true;
                        tBaoCao.Enabled = true;
                        break;
                    default:
                        MessageBox.Show("Chua Dang Nhap");
                        break;
                }
            }
            else
            {
                sttNguoiDung.Text = "Chua dang nhap";
                sttThoiGian.Text = " ";
            }
        }

        private void tChucVu_Click(object sender, EventArgs e)
        {
            frm_dmChucVu f = new frm_dmChucVu();
            f.ShowDialog();
        }

        private void tNhanVien_Click(object sender, EventArgs e)
        {
            frm_dmNhanVien nv = new frm_dmNhanVien();
            nv.ShowDialog();
        }

        private void tQuaTrinhLuong_Click(object sender, EventArgs e)
        {
            fr_nvQuaTrinhLuong f = new fr_nvQuaTrinhLuong();
            f.ShowDialog();
        }

        private void tDangNhap_Click(object sender, EventArgs e)
        {
            fDN = new frm_htDangNhap();
        
            if (fDN.ShowDialog() == DialogResult.OK)
            {
                string sten = fDN.txtTen.Text;
                string sMatKhau = fDN.txtMatKhau.Text;
                NguoiDung = new NguoiDung_DTO();
                NguoiDung = NguoiDung_BUS.DangNhap(sten, sMatKhau);
                if(NguoiDung != null)
                {
                    bDangNhap = true;
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");

                    bDangNhap = false;

                }
                HienThiMenu();

           }
           
        }

      
        private void enable()
        {
            tChuongTrinh.Enabled = false;
            tDanhMuc.Enabled = false;
            tNghiepVu.Enabled = false;
            tBaoCao.Enabled = false;
            tGiupDo.Enabled = false;
            tDoiMatKhau.Enabled = false;
            tDangNhap.Enabled = true;
            tTao.Enabled = false;
            tDangXuat.Enabled = false;
        }
        

        private void tDangXuat_Click(object sender, EventArgs e)
        {
            frmMain f = new frmMain();
            f.Close();
            bDangNhap = false;
            enable();
            HienThiMenu();
        }
        private void hienthi()
        {
            dmk = new frmDoiMatKhau();
            if (bDangNhap == true)
            {
                dmk.ten = NguoiDung.Ten;
               
            }
        }
        private void tDoiMatKhau_Click(object sender, EventArgs e)
        {
            hienthi();
            if (bDangNhap == true)
            {
                if (dmk.ShowDialog() == DialogResult.OK)
                {
                    if (NguoiDung_BUS.timMK(dmk.txt_mkcu.Text, dmk.txtTenDN.Text) == null)
                    {
                        MessageBox.Show("Mat khau cu khong dung");
                    }
                    else
                    {
                        string mkm = dmk.txt_mkMoi.Text;
                        string ten = dmk.txtTenDN.Text;
                        if (NguoiDung_BUS.DoiMk(ten, mkm) == false)
                        {
                            MessageBox.Show("Doi mat khau that bai");
                        }
                        else
                        {
                            MessageBox.Show("Doi thanh cong");
                        }
                    }
                }
            }
        }

        private void tThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tTao_Click(object sender, EventArgs e)
        {
            frm_TaoMoi tm = new frm_TaoMoi();
            tm.ShowDialog();
        }
    }
}
