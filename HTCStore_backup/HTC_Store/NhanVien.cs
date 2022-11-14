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
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void Main_Click(object sender, EventArgs e)
        {
            HeThong frm = new HeThong();
            frm.Show();
            this.Hide();
        }

        private void lbSanPham_Click(object sender, EventArgs e)
        {
            SanPham frm = new SanPham();
            frm.Show();
            this.Hide();
        }

        private void labelKH_Click(object sender, EventArgs e)
        {
            KhachHang frm = new KhachHang();
            frm.Show();
            this.Hide();
        }

        private void lbBanHang_Click(object sender, EventArgs e)
        {
            BanHang frm = new BanHang();
            frm.Show();
            this.Hide();
        }

        private void lbNhapHang_Click(object sender, EventArgs e)
        {
            NhapHang frm = new NhapHang();
            frm.Show();
            this.Hide();
        }

        private void lbThongKe_Click(object sender, EventArgs e)
        {
            ThongKe frm = new ThongKe();
            frm.Show();
            this.Hide();
        }

        public void Getdata()
        {
            string query = "select * from nhanvien";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(query, "nhanvien");
            dtnhanvien.DataSource = ds.Tables["nhanvien"];

        }
        private void NhanVien_Load(object sender, EventArgs e)
        {
            Getdata();
           /* butupdate.Enabled = false;
            butdelete.Enabled = false;
            butadd.Enabled = false;*/
        }

        private void butadd_Click(object sender, EventArgs e)
        {
            string manv = txtmanv.Text;
            string tennv = txttennv.Text;
            string chucvu = cbchucvu.Text;
            string gioitinh = txtgioitinh.Text;
            DateTime date = ngaysinh.Value;
            string luong = luongcung.Text;
            string sdt = txtsdt.Text;
            string diachi = txtdiachi.Text;
            string sql = "insert into nhanvien ([Mã nhân viên],[Tên nhân viên],[Giới tính],[Ngày sinh],[Chức vụ],[Số điện thoại],[Địa chỉ],[Lương])VALUES('" + manv + "',N'" + tennv + "',N'" + gioitinh + "','" + date + "',N'" + chucvu + "','" + sdt + "',N'" + diachi + "','" + luong + "')";
            Ketnoi cn = new Ketnoi();
            bool kt = cn.thucthi(sql);
            if (kt == true)
            {
                MessageBox.Show("Thêm thông tin nhân viên thành công !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm nhân viên ! ");
            }
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            DateTime date = ngaysinh.Value;
            string sql = "update nhanvien set [Mã nhân viên]='" + txtmanv.Text + "',[Tên nhân viên]=N'" + txttennv.Text + "',[Giới tính]=N'" + txtgioitinh.Text + "',[Ngày sinh]='" + date + "',[Chức vụ]=N'" + cbchucvu.Text + "',[Số điện thoại]='" + txtsdt.Text + "',[Địa chỉ]=N'" + txtdiachi.Text + "',[Lương] ='" + luongcung.Text + "' where [Mã nhân viên]='" + txtmanv.Text + "' ";
            Ketnoi cn = new Ketnoi();
            bool kt = cn.thucthi(sql);
            if (kt == true)
            {
                MessageBox.Show("Sửa thành công ! ");
                Getdata();
            }
            else
            {
                MessageBox.Show("Lỗi ! ");
            }
        }

        private void butdelete_Click(object sender, EventArgs e)
        {
            string sql = "delete from nhanvien  where [Mã nhân viên]='" + txtmanv.Text + "' ";
            Ketnoi cn = new Ketnoi();
            bool kt = cn.thucthi(sql);
            if (kt == true)
            {
                MessageBox.Show("Xóa thành công!");
                Getdata();
            }
            else
            {
                MessageBox.Show("Lỗi !");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            txtgioitinh.Enabled = true;
            cbchucvu.Enabled = true;
            txtmanv.Text = "";
            txttennv.Text = "";
            txtdiachi.Text = "";
            luongcung.Text = "";
            timkiemnv.Text = "";
            txtsdt.Text = "";
            Getdata();
            butupdate.Enabled = false;
            butdelete.Enabled = false;
            butadd.Enabled = true;
        }

        private void timkiemnv_TextChanged(object sender, EventArgs e)
        {
            string search = timkiemnv.Text;
            string query = "select * from nhanvien where [Tên nhân viên] like N'%" + search + "%'";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(query, "nhanvien");
            dtnhanvien.DataSource = ds.Tables["nhanvien"];
            butupdate.Enabled = true;
            butdelete.Enabled = true;
        }

        private void buttk_Click(object sender, EventArgs e)
        {
            string search = timkiemnv.Text;
            string query = "select * from nhanvien where [Tên nhân viên] like N'%" + search + "%'";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(query, "nhanvien");
            dtnhanvien.DataSource = ds.Tables["nhanvien"];
        }

        private void dtnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dtnhanvien.Rows[e.RowIndex];
                txtmanv.Text = row.Cells[0].Value.ToString();
                txttennv.Text = row.Cells[1].Value.ToString();
                txtgioitinh.Text = row.Cells[2].Value.ToString();
                ngaysinh.Text = row.Cells[3].Value.ToString();

                cbchucvu.Text = row.Cells[4].Value.ToString();
                txtsdt.Text = row.Cells[5].Value.ToString();
                txtdiachi.Text = row.Cells[6].Value.ToString();
                luongcung.Text = row.Cells[7].Value.ToString();
            }
            butupdate.Enabled = true;
            butdelete.Enabled = true;
            butadd.Enabled = false;
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.Show();
            this.Hide();
        }
    }
}
