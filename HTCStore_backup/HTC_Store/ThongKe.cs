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

namespace HTC_Store
{
    public partial class ThongKe : Form
    {
        public ThongKe()
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
            string query = "select * from banhang";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(query, "banhang");
            dgvhoadon.DataSource = ds.Tables["banhang"];
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            Getdata();
            //Thống kê doanh thu
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True";
                string query = "Select SUM(banhang.[Tổng tiền]) as Tongtien from banhang";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Doanhthu = reader.GetFieldValue<int>(0);
                            //MessageBox.Show("Tổng tiền thu là " + Doanhthu + " ", "Thống kê ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbDoanhThu.Text = Doanhthu.ToString()+" VNĐ";
                        }

                        reader.Close();
                    }

                    con.Close();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            //Thống kê số lượng khách hàng
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True";
                string query = "Select count(*) as Soluong from khachhang ";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int Doanhthu = reader.GetFieldValue<int>(0);
                            //MessageBox.Show("Tổng tiền thu là " + Doanhthu + " ", "Thống kê ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbKH.Text = Doanhthu.ToString()+"          👤";
                        }

                        reader.Close();
                    }

                    con.Close();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            //SP Bán chạy
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True";
                string query = "Select Top 1 banhang.[Tên sản phẩm], SUM(banhang.[Số lượng]) as Tongsoluong from sanpham, banhang " +
                        "group by banhang.[Tên sản phẩm]" +
                    "order by Tongsoluong desc";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string BanChay = reader.GetFieldValue<string>(0);
                            //MessageBox.Show("Tổng tiền thu là " + Doanhthu + " ", "Thống kê ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbBanChay.Text = BanChay.ToString() + "";
                        }

                        reader.Close();
                    }

                    con.Close();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }

            //Tổng tiền nhập Hàng
            try
            {
                string connectionString = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QLNT;Integrated Security=True";
                string query = "Select SUM(nhaphang.[Tổng tiền]) as Tongtien from nhaphang";

                using (SqlConnection con = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int NhapHang = reader.GetFieldValue<int>(0);
                            //MessageBox.Show("Tổng tiền thu là " + Doanhthu + " ", "Thống kê ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lbNhap.Text = NhapHang.ToString() + "   đ";
                        }

                        reader.Close();
                    }

                    con.Close();
                }
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dtBatDau.Value = DateTime.Today;
            Getdata();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            dtKetThuc.Value = DateTime.Today;
            Getdata();
        }

        private void dgvhoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvhoadon.Rows[e.RowIndex];
                dtBatDau.Text = row.Cells[5].Value.ToString(); 
                dtKetThuc.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dgvhoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvhoadon.Rows[e.RowIndex];
                dtBatDau.Text = row.Cells[5].Value.ToString();
                dtKetThuc.Text = row.Cells[5].Value.ToString();
            }
        }

        private void dtBatDau_ValueChanged(object sender, EventArgs e)
        {
            DateTime batdau = dtBatDau.Value;
            DateTime ketthuc = dtKetThuc.Value;
            string sql = "select * from banhang where [Ngày bán] between '" + batdau + "' and '" + ketthuc + "'";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(sql, "banhang");
            dgvhoadon.DataSource = ds.Tables["banhang"];
        }

        private void dtKetThuc_ValueChanged(object sender, EventArgs e)
        {
            DateTime batdau = dtBatDau.Value;
            DateTime ketthuc = dtKetThuc.Value;
            string sql = "select * from banhang where [Ngày bán] between '" + batdau + "' and '" + ketthuc + "'";
            DataSet ds = new DataSet();
            Ketnoi cn = new Ketnoi();
            ds = cn.laydulieu(sql, "banhang");
            dgvhoadon.DataSource = ds.Tables["banhang"];
        }

        private void picDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            frm.Show();
            this.Hide();
        }
    }
}
