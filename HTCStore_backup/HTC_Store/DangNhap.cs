using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HTC_Store
{
    public partial class DangNhap : Form
    {
        public static string quyen = "";
        public DangNhap()
        {
            InitializeComponent();
            //this.ActiveControl = txtTaiKhoan;
           txtTaiKhoan.Focus();
        } 

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra đăng nhập hệ thống
            string tk = txtTaiKhoan.Text;
            string mk = txtMatKhau.Text;
             
            string query = "select * from nguoidung where [Tên người dùng] = '" + tk + "' and [Mật khẩu] = '" + mk + "'";
            Ketnoi cn = new Ketnoi();
            DataSet ds = cn.laydulieu(query, "nguoidung");
            if (tk == "" || mk == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ tài khoản và mật khẩu!");
            }
            else if ((int)ds.Tables["nguoidung"].Rows[0].ItemArray[0] > 0)
            {
                //quyen = ds.Tables["nguoidung"].Rows[0][3].ToString();
                HeThong frm = new HeThong();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                txtTaiKhoan.Text = "";
                txtMatKhau.Text = "";
                txtTaiKhoan.Focus();
            }
        }

        private void Checkboxmk_CheckedChanged(object sender, EventArgs e)
        {
            txtMatKhau.PasswordChar = Checkboxmk.Checked ? '\0' : '●';
        }

        private void txtTaiKhoan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap.PerformClick();
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
