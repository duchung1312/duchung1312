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
    public partial class SanPham : Form
    {
        public SanPham()
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

        private void lbNhanVien_Click(object sender, EventArgs e)
        {
            NhanVien frm = new NhanVien();
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
            string query = "select * from sanpham";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(query, "sanpham");
            dtsanpham.DataSource = ds.Tables["sanpham"];

        }
        public void getmath()
        {
            string query = "select * from thuonghieu";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(query, "thuonghieu");
            thuonghieusp.DataSource = ds.Tables["thuonghieu"];
            thuonghieusp.DisplayMember = "Mã thương hiệu";
            thuonghieusp.ValueMember = "Tên thương hiệu";
            txtthuonghieu.Text = "";
        }
        private void butadd_Click(object sender, EventArgs e)
        {
            string masp = txtmasp.Text;
            string tensp = txttensp.Text;
            string chatlieu = txtchatlieu.Text;
            int soluong = Convert.ToInt32(txtsoluong.Value.ToString());
            string giaban = giabansp.Text;
            string math = txtthuonghieu.Text;
            string thuonghieu = thuonghieusp.Text;
            string sql = "insert into sanpham ([Mã sản phẩm],[Tên sản phẩm],[Chất liệu],[Số lượng],[Giá bán],[Mã thương hiệu],[Tên Thương Hiệu])" +
                "VALUES" +
                "('" + masp + "',N'" + tensp + "',N'" + chatlieu + "','" + soluong + "','" + giaban + "','" + math + "','" + thuonghieu + "')";
            Ketnoi cn = new Ketnoi();
            bool kt = cn.thucthi(sql);
            if (kt == true)
            {
                MessageBox.Show("Thêm thành công sản phẩm !");
                Getdata();
            }
            else
            {
                MessageBox.Show("Lỗi khi thêm sản phẩm ! ");
            }
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            Getdata();
            getmath();
           butupdate.Enabled = false;
           butdelete.Enabled = false;
           //butadd.Enabled = false;
        }

        private void butupdate_Click(object sender, EventArgs e)
        {
            //int soluong = Convert.ToInt32(txtsoluong.Value.ToString());
            string sql = "update sanpham set [Mã sản phẩm]='" + txtmasp.Text + "',[Tên sản phẩm]=N'" + txttensp.Text + "',[Chất liệu]=N'" + txtchatlieu.Text + "',[Số lượng]='" + Convert.ToInt32(txtsoluong.Value.ToString()) + "',[Giá bán]='" + giabansp.Text + "',[Mã thương hiệu]='" + thuonghieusp.Text + "',[Tên Thương Hiệu]='"+txtthuonghieu.Text+"' where [Mã sản phẩm]='" + txtmasp.Text + "' ";
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
            string sql = "delete from sanpham  where [Mã sản phẩm]='" + txtmasp.Text + "' ";
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
            thuonghieusp.Enabled = true;
            txtmasp.Text = "";
            txtchatlieu.Text = "";
            txttensp.Text = "";
            giabansp.Text = "";
            timkiemsp.Text = "";
            txtsoluong.Value = default;
            Getdata();
            butupdate.Enabled = false;
            butdelete.Enabled = false;
            butadd.Enabled = true;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string search = txtsearch.Text;
            string query = "select * from sanpham where [Tên sản phẩm] like N'%" + search + "%'";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(query, "sanpham");
            dtsanpham.DataSource = ds.Tables["sanpham"];
           // Getdata();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtsearch.Text;
            string query = "select * from sanpham where [Tên sản phẩm] like N'%" + search + "%'";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(query, "sanpham");
            dtsanpham.DataSource = ds.Tables["sanpham"];
           // Getdata();
        }

        private void dtsanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dtsanpham.Rows[e.RowIndex];
                txtmasp.Text = row.Cells[0].Value.ToString();
                txttensp.Text = row.Cells[1].Value.ToString();
                txtchatlieu.Text = row.Cells[2].Value.ToString();
                txtsoluong.Value = int.Parse(row.Cells[3].Value.ToString());
                giabansp.Text = row.Cells[4].Value.ToString();
                thuonghieusp.Text = row.Cells[5].Value.ToString();
                txtthuonghieu.Text = row.Cells[6].Value.ToString();
            }
            butupdate.Enabled = true;
            butdelete.Enabled = true;
            butadd.Enabled = false;
        }

        private void dtsanpham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dtsanpham.Rows[e.RowIndex];
                txtmasp.Text = row.Cells[0].Value.ToString();
                txttensp.Text = row.Cells[1].Value.ToString();
                txtchatlieu.Text = row.Cells[2].Value.ToString();
                txtsoluong.Value = int.Parse(row.Cells[3].Value.ToString());
                giabansp.Text = row.Cells[4].Value.ToString();
                thuonghieusp.Text = row.Cells[5].Value.ToString();
                txtthuonghieu.Text = row.Cells[6].Value.ToString();
            }
            butupdate.Enabled = true;
            butdelete.Enabled = true;
            butadd.Enabled = false;
        }

        private void thuonghieusp_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtthuonghieu.Text = thuonghieusp.SelectedValue.ToString();
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.Show();
            this.Hide();
        }
    }
}
