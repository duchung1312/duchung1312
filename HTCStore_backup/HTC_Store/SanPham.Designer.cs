
namespace HTC_Store
{
    partial class SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Label();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.lbBanHang = new System.Windows.Forms.Label();
            this.lbThongKe = new System.Windows.Forms.Label();
            this.labelKH = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picDangXuat = new System.Windows.Forms.PictureBox();
            this.giabansp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtchatlieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtthuonghieu = new Guna.UI2.WinForms.Guna2TextBox();
            this.thuonghieusp = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txttensp = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtmasp = new Guna.UI2.WinForms.Guna2TextBox();
            this.timkiemsp = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtsanpham = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.butdelete = new Guna.UI2.WinForms.Guna2Button();
            this.butupdate = new Guna.UI2.WinForms.Guna2Button();
            this.butadd = new Guna.UI2.WinForms.Guna2Button();
            this.btnsearch = new System.Windows.Forms.PictureBox();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtsoluong = new Guna.UI.WinForms.GunaNumeric();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2Button1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(355, 63);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 10);
            this.panel2.TabIndex = 59;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(30, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 61);
            this.panel1.TabIndex = 58;
            // 
            // Main
            // 
            this.Main.AutoSize = true;
            this.Main.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.Location = new System.Drawing.Point(41, 22);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(324, 59);
            this.Main.TabIndex = 57;
            this.Main.Text = "SAM Manager ";
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSanPham.Location = new System.Drawing.Point(643, 44);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(96, 25);
            this.lbSanPham.TabIndex = 60;
            this.lbSanPham.Text = "Sản Phẩm";
            this.lbSanPham.Click += new System.EventHandler(this.lbSanPham_Click);
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.Location = new System.Drawing.Point(794, 44);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(101, 25);
            this.lbNhanVien.TabIndex = 61;
            this.lbNhanVien.Text = "Nhân Viên";
            this.lbNhanVien.Click += new System.EventHandler(this.lbNhanVien_Click);
            // 
            // lbBanHang
            // 
            this.lbBanHang.AutoSize = true;
            this.lbBanHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanHang.Location = new System.Drawing.Point(1112, 44);
            this.lbBanHang.Name = "lbBanHang";
            this.lbBanHang.Size = new System.Drawing.Size(94, 25);
            this.lbBanHang.TabIndex = 62;
            this.lbBanHang.Text = "Bán Hàng";
            this.lbBanHang.Click += new System.EventHandler(this.lbBanHang_Click);
            // 
            // lbThongKe
            // 
            this.lbThongKe.AutoSize = true;
            this.lbThongKe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKe.Location = new System.Drawing.Point(1245, 42);
            this.lbThongKe.Name = "lbThongKe";
            this.lbThongKe.Size = new System.Drawing.Size(92, 25);
            this.lbThongKe.TabIndex = 63;
            this.lbThongKe.Text = "Thống Kê";
            this.lbThongKe.Click += new System.EventHandler(this.lbThongKe_Click);
            // 
            // labelKH
            // 
            this.labelKH.AutoSize = true;
            this.labelKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKH.Location = new System.Drawing.Point(939, 44);
            this.labelKH.Name = "labelKH";
            this.labelKH.Size = new System.Drawing.Size(114, 25);
            this.labelKH.TabIndex = 64;
            this.labelKH.Text = "Khách Hàng";
            this.labelKH.Click += new System.EventHandler(this.labelKH_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(648, 72);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 3);
            this.panel3.TabIndex = 59;
            // 
            // picDangXuat
            // 
            this.picDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("picDangXuat.Image")));
            this.picDangXuat.Location = new System.Drawing.Point(1392, 33);
            this.picDangXuat.Name = "picDangXuat";
            this.picDangXuat.Size = new System.Drawing.Size(38, 36);
            this.picDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDangXuat.TabIndex = 66;
            this.picDangXuat.TabStop = false;
            this.picDangXuat.Click += new System.EventHandler(this.picDangXuat_Click);
            // 
            // giabansp
            // 
            this.giabansp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.giabansp.DefaultText = "";
            this.giabansp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.giabansp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.giabansp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.giabansp.DisabledState.Parent = this.giabansp;
            this.giabansp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.giabansp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.giabansp.FocusedState.Parent = this.giabansp;
            this.giabansp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.giabansp.HoverState.Parent = this.giabansp;
            this.giabansp.Location = new System.Drawing.Point(1055, 302);
            this.giabansp.Margin = new System.Windows.Forms.Padding(5);
            this.giabansp.Name = "giabansp";
            this.giabansp.PasswordChar = '\0';
            this.giabansp.PlaceholderText = "";
            this.giabansp.SelectedText = "";
            this.giabansp.ShadowDecoration.Parent = this.giabansp;
            this.giabansp.Size = new System.Drawing.Size(225, 34);
            this.giabansp.TabIndex = 73;
            // 
            // txtchatlieu
            // 
            this.txtchatlieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtchatlieu.DefaultText = "";
            this.txtchatlieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtchatlieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtchatlieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchatlieu.DisabledState.Parent = this.txtchatlieu;
            this.txtchatlieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtchatlieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchatlieu.FocusedState.Parent = this.txtchatlieu;
            this.txtchatlieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtchatlieu.HoverState.Parent = this.txtchatlieu;
            this.txtchatlieu.Location = new System.Drawing.Point(689, 199);
            this.txtchatlieu.Margin = new System.Windows.Forms.Padding(5);
            this.txtchatlieu.Name = "txtchatlieu";
            this.txtchatlieu.PasswordChar = '\0';
            this.txtchatlieu.PlaceholderText = "";
            this.txtchatlieu.SelectedText = "";
            this.txtchatlieu.ShadowDecoration.Parent = this.txtchatlieu;
            this.txtchatlieu.Size = new System.Drawing.Size(149, 44);
            this.txtchatlieu.TabIndex = 72;
            // 
            // txtthuonghieu
            // 
            this.txtthuonghieu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtthuonghieu.DefaultText = "";
            this.txtthuonghieu.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtthuonghieu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtthuonghieu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtthuonghieu.DisabledState.Parent = this.txtthuonghieu;
            this.txtthuonghieu.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtthuonghieu.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtthuonghieu.FocusedState.Parent = this.txtthuonghieu;
            this.txtthuonghieu.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtthuonghieu.HoverState.Parent = this.txtthuonghieu;
            this.txtthuonghieu.Location = new System.Drawing.Point(1055, 255);
            this.txtthuonghieu.Margin = new System.Windows.Forms.Padding(5);
            this.txtthuonghieu.Name = "txtthuonghieu";
            this.txtthuonghieu.PasswordChar = '\0';
            this.txtthuonghieu.PlaceholderText = "";
            this.txtthuonghieu.SelectedText = "";
            this.txtthuonghieu.ShadowDecoration.Parent = this.txtthuonghieu;
            this.txtthuonghieu.Size = new System.Drawing.Size(191, 38);
            this.txtthuonghieu.TabIndex = 71;
            // 
            // thuonghieusp
            // 
            this.thuonghieusp.BackColor = System.Drawing.Color.Transparent;
            this.thuonghieusp.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.thuonghieusp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thuonghieusp.FocusedColor = System.Drawing.Color.Empty;
            this.thuonghieusp.FocusedState.Parent = this.thuonghieusp;
            this.thuonghieusp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.thuonghieusp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.thuonghieusp.FormattingEnabled = true;
            this.thuonghieusp.HoverState.Parent = this.thuonghieusp;
            this.thuonghieusp.ItemHeight = 30;
            this.thuonghieusp.ItemsAppearance.Parent = this.thuonghieusp;
            this.thuonghieusp.Location = new System.Drawing.Point(1055, 199);
            this.thuonghieusp.Margin = new System.Windows.Forms.Padding(4);
            this.thuonghieusp.Name = "thuonghieusp";
            this.thuonghieusp.ShadowDecoration.Parent = this.thuonghieusp;
            this.thuonghieusp.Size = new System.Drawing.Size(185, 36);
            this.thuonghieusp.TabIndex = 69;
            this.thuonghieusp.SelectedIndexChanged += new System.EventHandler(this.thuonghieusp_SelectedIndexChanged);
            // 
            // txttensp
            // 
            this.txttensp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttensp.DefaultText = "";
            this.txttensp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttensp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttensp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttensp.DisabledState.Parent = this.txttensp;
            this.txttensp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttensp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttensp.FocusedState.Parent = this.txttensp;
            this.txttensp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttensp.HoverState.Parent = this.txttensp;
            this.txttensp.Location = new System.Drawing.Point(228, 302);
            this.txttensp.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txttensp.Name = "txttensp";
            this.txttensp.PasswordChar = '\0';
            this.txttensp.PlaceholderText = "";
            this.txttensp.SelectedText = "";
            this.txttensp.ShadowDecoration.Parent = this.txttensp;
            this.txttensp.Size = new System.Drawing.Size(265, 34);
            this.txttensp.TabIndex = 68;
            // 
            // txtmasp
            // 
            this.txtmasp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmasp.DefaultText = "";
            this.txtmasp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmasp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmasp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmasp.DisabledState.Parent = this.txtmasp;
            this.txtmasp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmasp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmasp.FocusedState.Parent = this.txtmasp;
            this.txtmasp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmasp.HoverState.Parent = this.txtmasp;
            this.txtmasp.Location = new System.Drawing.Point(228, 207);
            this.txtmasp.Margin = new System.Windows.Forms.Padding(5);
            this.txtmasp.Name = "txtmasp";
            this.txtmasp.PasswordChar = '\0';
            this.txtmasp.PlaceholderText = "";
            this.txtmasp.SelectedText = "";
            this.txtmasp.ShadowDecoration.Parent = this.txtmasp;
            this.txtmasp.Size = new System.Drawing.Size(265, 41);
            this.txtmasp.TabIndex = 67;
            // 
            // timkiemsp
            // 
            this.timkiemsp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.timkiemsp.DefaultText = "";
            this.timkiemsp.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.timkiemsp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.timkiemsp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timkiemsp.DisabledState.Parent = this.timkiemsp;
            this.timkiemsp.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.timkiemsp.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timkiemsp.FocusedState.Parent = this.timkiemsp;
            this.timkiemsp.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.timkiemsp.HoverState.Parent = this.timkiemsp;
            this.timkiemsp.Location = new System.Drawing.Point(144, 825);
            this.timkiemsp.Margin = new System.Windows.Forms.Padding(5);
            this.timkiemsp.Name = "timkiemsp";
            this.timkiemsp.PasswordChar = '\0';
            this.timkiemsp.PlaceholderText = "";
            this.timkiemsp.SelectedText = "";
            this.timkiemsp.ShadowDecoration.Parent = this.timkiemsp;
            this.timkiemsp.Size = new System.Drawing.Size(161, 31);
            this.timkiemsp.TabIndex = 70;
            // 
            // dtsanpham
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dtsanpham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtsanpham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtsanpham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtsanpham.BackgroundColor = System.Drawing.Color.White;
            this.dtsanpham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtsanpham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtsanpham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtsanpham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtsanpham.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtsanpham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtsanpham.EnableHeadersVisualStyles = false;
            this.dtsanpham.Location = new System.Drawing.Point(30, 528);
            this.dtsanpham.Name = "dtsanpham";
            this.dtsanpham.RowHeadersVisible = false;
            this.dtsanpham.RowHeadersWidth = 51;
            this.dtsanpham.RowTemplate.Height = 40;
            this.dtsanpham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtsanpham.Size = new System.Drawing.Size(1421, 289);
            this.dtsanpham.TabIndex = 145;
            this.dtsanpham.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dtsanpham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtsanpham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtsanpham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtsanpham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dtsanpham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtsanpham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtsanpham.ThemeStyle.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dtsanpham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtsanpham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtsanpham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dtsanpham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtsanpham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtsanpham.ThemeStyle.HeaderStyle.Height = 40;
            this.dtsanpham.ThemeStyle.ReadOnly = false;
            this.dtsanpham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtsanpham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtsanpham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtsanpham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtsanpham.ThemeStyle.RowsStyle.Height = 40;
            this.dtsanpham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dtsanpham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtsanpham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtsanpham_CellClick);
            this.dtsanpham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtsanpham_CellContentClick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.Location = new System.Drawing.Point(967, 416);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(39, 40);
            this.guna2Button1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2Button1.TabIndex = 152;
            this.guna2Button1.TabStop = false;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // butdelete
            // 
            this.butdelete.BorderColor = System.Drawing.Color.Red;
            this.butdelete.BorderRadius = 5;
            this.butdelete.BorderThickness = 2;
            this.butdelete.CheckedState.Parent = this.butdelete;
            this.butdelete.CustomImages.Parent = this.butdelete;
            this.butdelete.FillColor = System.Drawing.Color.White;
            this.butdelete.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelete.ForeColor = System.Drawing.Color.Red;
            this.butdelete.HoverState.BorderColor = System.Drawing.Color.Red;
            this.butdelete.HoverState.FillColor = System.Drawing.Color.Red;
            this.butdelete.HoverState.ForeColor = System.Drawing.Color.White;
            this.butdelete.HoverState.Parent = this.butdelete;
            this.butdelete.Location = new System.Drawing.Point(781, 410);
            this.butdelete.Name = "butdelete";
            this.butdelete.PressedColor = System.Drawing.Color.Red;
            this.butdelete.ShadowDecoration.Parent = this.butdelete;
            this.butdelete.Size = new System.Drawing.Size(135, 51);
            this.butdelete.TabIndex = 151;
            this.butdelete.Text = "Xóa";
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butupdate
            // 
            this.butupdate.BorderRadius = 5;
            this.butupdate.CheckedState.Parent = this.butupdate;
            this.butupdate.CustomImages.Parent = this.butupdate;
            this.butupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.butupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butupdate.ForeColor = System.Drawing.Color.White;
            this.butupdate.HoverState.Parent = this.butupdate;
            this.butupdate.Location = new System.Drawing.Point(582, 410);
            this.butupdate.Name = "butupdate";
            this.butupdate.ShadowDecoration.Parent = this.butupdate;
            this.butupdate.Size = new System.Drawing.Size(135, 51);
            this.butupdate.TabIndex = 150;
            this.butupdate.Text = "Cập nhật";
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // butadd
            // 
            this.butadd.BorderRadius = 5;
            this.butadd.CheckedState.Parent = this.butadd;
            this.butadd.CustomImages.Parent = this.butadd;
            this.butadd.FillColor = System.Drawing.Color.DodgerBlue;
            this.butadd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.ForeColor = System.Drawing.Color.White;
            this.butadd.HoverState.Parent = this.butadd;
            this.butadd.Location = new System.Drawing.Point(383, 410);
            this.butadd.Name = "butadd";
            this.butadd.ShadowDecoration.Parent = this.butadd;
            this.butadd.Size = new System.Drawing.Size(135, 51);
            this.butadd.TabIndex = 149;
            this.butadd.Text = "Thêm";
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Image = ((System.Drawing.Image)(resources.GetObject("btnsearch.Image")));
            this.btnsearch.Location = new System.Drawing.Point(1370, 414);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(35, 40);
            this.btnsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnsearch.TabIndex = 155;
            this.btnsearch.TabStop = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.BorderRadius = 2;
            this.txtsearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsearch.DefaultText = "";
            this.txtsearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.DisabledState.Parent = this.txtsearch;
            this.txtsearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.FocusedState.Parent = this.txtsearch;
            this.txtsearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsearch.HoverState.Parent = this.txtsearch;
            this.txtsearch.Location = new System.Drawing.Point(1143, 414);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "";
            this.txtsearch.SelectedText = "";
            this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
            this.txtsearch.Size = new System.Drawing.Size(220, 42);
            this.txtsearch.TabIndex = 154;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1175, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 28);
            this.label6.TabIndex = 153;
            this.label6.Text = "Tên sản phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(528, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 28);
            this.label1.TabIndex = 156;
            this.label1.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(893, 302);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 28);
            this.label3.TabIndex = 158;
            this.label3.Text = "Giá bán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(893, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 28);
            this.label4.TabIndex = 159;
            this.label4.Text = "Thương hiệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(56, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 28);
            this.label5.TabIndex = 160;
            this.label5.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(528, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 28);
            this.label7.TabIndex = 161;
            this.label7.Text = "Chất liệu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(56, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 28);
            this.label8.TabIndex = 162;
            this.label8.Text = "Mã sản phẩm";
            // 
            // txtsoluong
            // 
            this.txtsoluong.BaseColor = System.Drawing.Color.White;
            this.txtsoluong.BorderColor = System.Drawing.Color.Silver;
            this.txtsoluong.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtsoluong.ButtonForeColor = System.Drawing.Color.White;
            this.txtsoluong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtsoluong.ForeColor = System.Drawing.Color.Black;
            this.txtsoluong.Location = new System.Drawing.Point(689, 306);
            this.txtsoluong.Maximum = ((long)(9999999));
            this.txtsoluong.Minimum = ((long)(0));
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(99, 30);
            this.txtsoluong.TabIndex = 163;
            this.txtsoluong.Value = ((long)(0));
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1487, 853);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butupdate);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.dtsanpham);
            this.Controls.Add(this.giabansp);
            this.Controls.Add(this.txtchatlieu);
            this.Controls.Add(this.txtthuonghieu);
            this.Controls.Add(this.thuonghieusp);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmasp);
            this.Controls.Add(this.timkiemsp);
            this.Controls.Add(this.picDangXuat);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.labelKH);
            this.Controls.Add(this.lbThongKe);
            this.Controls.Add(this.lbBanHang);
            this.Controls.Add(this.lbNhanVien);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAM Manager | Sản phẩm";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtsanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2Button1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Main;
        private System.Windows.Forms.Label lbSanPham;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.Label lbBanHang;
        private System.Windows.Forms.Label lbThongKe;
        private System.Windows.Forms.Label labelKH;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox picDangXuat;
        private Guna.UI2.WinForms.Guna2TextBox giabansp;
        private Guna.UI2.WinForms.Guna2TextBox txtchatlieu;
        private Guna.UI2.WinForms.Guna2TextBox txtthuonghieu;
        private Guna.UI2.WinForms.Guna2ComboBox thuonghieusp;
        private Guna.UI2.WinForms.Guna2TextBox txttensp;
        private Guna.UI2.WinForms.Guna2TextBox txtmasp;
        private Guna.UI2.WinForms.Guna2TextBox timkiemsp;
        private Guna.UI2.WinForms.Guna2DataGridView dtsanpham;
        private Guna.UI2.WinForms.Guna2PictureBox guna2Button1;
        private Guna.UI2.WinForms.Guna2Button butdelete;
        private Guna.UI2.WinForms.Guna2Button butupdate;
        private Guna.UI2.WinForms.Guna2Button butadd;
        private System.Windows.Forms.PictureBox btnsearch;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaNumeric txtsoluong;
    }
}