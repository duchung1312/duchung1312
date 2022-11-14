
namespace HTC_Store
{
    partial class KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhachHang));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.picDangXuat = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelKH = new System.Windows.Forms.Label();
            this.lbThongKe = new System.Windows.Forms.Label();
            this.lbBanHang = new System.Windows.Forms.Label();
            this.lbNhanVien = new System.Windows.Forms.Label();
            this.lbSanPham = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Main = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmakh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttenkh = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtsdt = new Guna.UI2.WinForms.Guna2TextBox();
            this.diachi = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvkh = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.btnupdate = new Guna.UI2.WinForms.Guna2Button();
            this.btndel = new Guna.UI2.WinForms.Guna2Button();
            this.picsearch = new System.Windows.Forms.PictureBox();
            this.txtsearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.gioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picDangXuat
            // 
            this.picDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("picDangXuat.Image")));
            this.picDangXuat.Location = new System.Drawing.Point(1392, 34);
            this.picDangXuat.Name = "picDangXuat";
            this.picDangXuat.Size = new System.Drawing.Size(38, 36);
            this.picDangXuat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDangXuat.TabIndex = 88;
            this.picDangXuat.TabStop = false;
            this.picDangXuat.Click += new System.EventHandler(this.picDangXuat_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(945, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(80, 3);
            this.panel3.TabIndex = 80;
            // 
            // labelKH
            // 
            this.labelKH.AutoSize = true;
            this.labelKH.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKH.Location = new System.Drawing.Point(936, 45);
            this.labelKH.Name = "labelKH";
            this.labelKH.Size = new System.Drawing.Size(114, 25);
            this.labelKH.TabIndex = 86;
            this.labelKH.Text = "Khách Hàng";
            this.labelKH.Click += new System.EventHandler(this.labelKH_Click);
            // 
            // lbThongKe
            // 
            this.lbThongKe.AutoSize = true;
            this.lbThongKe.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbThongKe.Location = new System.Drawing.Point(1245, 43);
            this.lbThongKe.Name = "lbThongKe";
            this.lbThongKe.Size = new System.Drawing.Size(92, 25);
            this.lbThongKe.TabIndex = 85;
            this.lbThongKe.Text = "Thống Kê";
            this.lbThongKe.Click += new System.EventHandler(this.lbThongKe_Click);
            // 
            // lbBanHang
            // 
            this.lbBanHang.AutoSize = true;
            this.lbBanHang.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBanHang.Location = new System.Drawing.Point(1109, 45);
            this.lbBanHang.Name = "lbBanHang";
            this.lbBanHang.Size = new System.Drawing.Size(94, 25);
            this.lbBanHang.TabIndex = 84;
            this.lbBanHang.Text = "Bán Hàng";
            this.lbBanHang.Click += new System.EventHandler(this.lbBanHang_Click);
            // 
            // lbNhanVien
            // 
            this.lbNhanVien.AutoSize = true;
            this.lbNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhanVien.Location = new System.Drawing.Point(791, 45);
            this.lbNhanVien.Name = "lbNhanVien";
            this.lbNhanVien.Size = new System.Drawing.Size(101, 25);
            this.lbNhanVien.TabIndex = 83;
            this.lbNhanVien.Text = "Nhân Viên";
            this.lbNhanVien.Click += new System.EventHandler(this.lbNhanVien_Click);
            // 
            // lbSanPham
            // 
            this.lbSanPham.AutoSize = true;
            this.lbSanPham.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSanPham.Location = new System.Drawing.Point(640, 45);
            this.lbSanPham.Name = "lbSanPham";
            this.lbSanPham.Size = new System.Drawing.Size(96, 25);
            this.lbSanPham.TabIndex = 82;
            this.lbSanPham.Text = "Sản Phẩm";
            this.lbSanPham.Click += new System.EventHandler(this.lbSanPham_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(355, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 10);
            this.panel2.TabIndex = 81;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(30, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 61);
            this.panel1.TabIndex = 79;
            // 
            // Main
            // 
            this.Main.AutoSize = true;
            this.Main.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Main.Location = new System.Drawing.Point(41, 23);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(324, 59);
            this.Main.TabIndex = 78;
            this.Main.Text = "SAM Manager ";
            this.Main.Click += new System.EventHandler(this.Main_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 28);
            this.label1.TabIndex = 89;
            this.label1.Text = "Mã khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(97, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 28);
            this.label2.TabIndex = 90;
            this.label2.Text = "Tên khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(616, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 28);
            this.label3.TabIndex = 91;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(616, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 28);
            this.label4.TabIndex = 92;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(97, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 28);
            this.label5.TabIndex = 93;
            this.label5.Text = "Địa chỉ";
            // 
            // txtmakh
            // 
            this.txtmakh.BorderRadius = 2;
            this.txtmakh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmakh.DefaultText = "";
            this.txtmakh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmakh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmakh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmakh.DisabledState.Parent = this.txtmakh;
            this.txtmakh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmakh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmakh.FocusedState.Parent = this.txtmakh;
            this.txtmakh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmakh.HoverState.Parent = this.txtmakh;
            this.txtmakh.Location = new System.Drawing.Point(289, 154);
            this.txtmakh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmakh.Name = "txtmakh";
            this.txtmakh.PasswordChar = '\0';
            this.txtmakh.PlaceholderText = "";
            this.txtmakh.SelectedText = "";
            this.txtmakh.ShadowDecoration.Parent = this.txtmakh;
            this.txtmakh.Size = new System.Drawing.Size(220, 42);
            this.txtmakh.TabIndex = 94;
            // 
            // txttenkh
            // 
            this.txttenkh.BorderRadius = 2;
            this.txttenkh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttenkh.DefaultText = "";
            this.txttenkh.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttenkh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttenkh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenkh.DisabledState.Parent = this.txttenkh;
            this.txttenkh.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttenkh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenkh.FocusedState.Parent = this.txttenkh;
            this.txttenkh.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttenkh.HoverState.Parent = this.txttenkh;
            this.txttenkh.Location = new System.Drawing.Point(289, 235);
            this.txttenkh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttenkh.Name = "txttenkh";
            this.txttenkh.PasswordChar = '\0';
            this.txttenkh.PlaceholderText = "";
            this.txttenkh.SelectedText = "";
            this.txttenkh.ShadowDecoration.Parent = this.txttenkh;
            this.txttenkh.Size = new System.Drawing.Size(220, 42);
            this.txttenkh.TabIndex = 95;
            // 
            // txtsdt
            // 
            this.txtsdt.BorderRadius = 2;
            this.txtsdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtsdt.DefaultText = "";
            this.txtsdt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtsdt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtsdt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsdt.DisabledState.Parent = this.txtsdt;
            this.txtsdt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtsdt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsdt.FocusedState.Parent = this.txtsdt;
            this.txtsdt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtsdt.HoverState.Parent = this.txtsdt;
            this.txtsdt.Location = new System.Drawing.Point(774, 149);
            this.txtsdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.PasswordChar = '\0';
            this.txtsdt.PlaceholderText = "";
            this.txtsdt.SelectedText = "";
            this.txtsdt.ShadowDecoration.Parent = this.txtsdt;
            this.txtsdt.Size = new System.Drawing.Size(220, 42);
            this.txtsdt.TabIndex = 96;
            // 
            // diachi
            // 
            this.diachi.BorderRadius = 2;
            this.diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.diachi.DefaultText = "";
            this.diachi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.diachi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.diachi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.diachi.DisabledState.Parent = this.diachi;
            this.diachi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.diachi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diachi.FocusedState.Parent = this.diachi;
            this.diachi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.diachi.HoverState.Parent = this.diachi;
            this.diachi.Location = new System.Drawing.Point(289, 310);
            this.diachi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.diachi.Name = "diachi";
            this.diachi.PasswordChar = '\0';
            this.diachi.PlaceholderText = "";
            this.diachi.SelectedText = "";
            this.diachi.ShadowDecoration.Parent = this.diachi;
            this.diachi.Size = new System.Drawing.Size(220, 42);
            this.diachi.TabIndex = 98;
            // 
            // dgvkh
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            this.dgvkh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvkh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvkh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvkh.BackgroundColor = System.Drawing.Color.White;
            this.dgvkh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvkh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvkh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvkh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvkh.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvkh.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvkh.EnableHeadersVisualStyles = false;
            this.dgvkh.Location = new System.Drawing.Point(30, 527);
            this.dgvkh.Name = "dgvkh";
            this.dgvkh.RowHeadersVisible = false;
            this.dgvkh.RowHeadersWidth = 51;
            this.dgvkh.RowTemplate.Height = 40;
            this.dgvkh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvkh.Size = new System.Drawing.Size(1400, 306);
            this.dgvkh.TabIndex = 99;
            this.dgvkh.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvkh.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvkh.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvkh.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvkh.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvkh.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvkh.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvkh.ThemeStyle.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dgvkh.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvkh.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvkh.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvkh.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvkh.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvkh.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvkh.ThemeStyle.ReadOnly = false;
            this.dgvkh.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvkh.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvkh.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvkh.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvkh.ThemeStyle.RowsStyle.Height = 40;
            this.dgvkh.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvkh.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvkh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkh_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1177, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 28);
            this.label6.TabIndex = 95;
            this.label6.Text = "Tên khách hàng";
            // 
            // btnthem
            // 
            this.btnthem.BorderRadius = 5;
            this.btnthem.CheckedState.Parent = this.btnthem;
            this.btnthem.CustomImages.Parent = this.btnthem;
            this.btnthem.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnthem.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.HoverState.Parent = this.btnthem;
            this.btnthem.Location = new System.Drawing.Point(421, 412);
            this.btnthem.Name = "btnthem";
            this.btnthem.ShadowDecoration.Parent = this.btnthem;
            this.btnthem.Size = new System.Drawing.Size(135, 51);
            this.btnthem.TabIndex = 101;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BorderRadius = 5;
            this.btnupdate.CheckedState.Parent = this.btnupdate;
            this.btnupdate.CustomImages.Parent = this.btnupdate;
            this.btnupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnupdate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.Color.White;
            this.btnupdate.HoverState.Parent = this.btnupdate;
            this.btnupdate.Location = new System.Drawing.Point(625, 412);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.ShadowDecoration.Parent = this.btnupdate;
            this.btnupdate.Size = new System.Drawing.Size(135, 51);
            this.btnupdate.TabIndex = 102;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndel
            // 
            this.btndel.BorderColor = System.Drawing.Color.Red;
            this.btndel.BorderRadius = 5;
            this.btndel.BorderThickness = 2;
            this.btndel.CheckedState.Parent = this.btndel;
            this.btndel.CustomImages.Parent = this.btndel;
            this.btndel.FillColor = System.Drawing.Color.White;
            this.btndel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.Color.Red;
            this.btndel.HoverState.BorderColor = System.Drawing.Color.Red;
            this.btndel.HoverState.FillColor = System.Drawing.Color.Red;
            this.btndel.HoverState.ForeColor = System.Drawing.Color.White;
            this.btndel.HoverState.Parent = this.btndel;
            this.btndel.Location = new System.Drawing.Point(824, 412);
            this.btndel.Name = "btndel";
            this.btndel.PressedColor = System.Drawing.Color.Red;
            this.btndel.ShadowDecoration.Parent = this.btndel;
            this.btndel.Size = new System.Drawing.Size(135, 51);
            this.btndel.TabIndex = 103;
            this.btndel.Text = "Xóa";
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // picsearch
            // 
            this.picsearch.Image = ((System.Drawing.Image)(resources.GetObject("picsearch.Image")));
            this.picsearch.Location = new System.Drawing.Point(1372, 163);
            this.picsearch.Name = "picsearch";
            this.picsearch.Size = new System.Drawing.Size(35, 40);
            this.picsearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsearch.TabIndex = 106;
            this.picsearch.TabStop = false;
            this.picsearch.Click += new System.EventHandler(this.picsearch_Click);
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
            this.txtsearch.Location = new System.Drawing.Point(1145, 163);
            this.txtsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.PasswordChar = '\0';
            this.txtsearch.PlaceholderText = "";
            this.txtsearch.SelectedText = "";
            this.txtsearch.ShadowDecoration.Parent = this.txtsearch;
            this.txtsearch.Size = new System.Drawing.Size(220, 42);
            this.txtsearch.TabIndex = 96;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(1037, 416);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(39, 40);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 107;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // gioitinh
            // 
            this.gioitinh.BackColor = System.Drawing.Color.Transparent;
            this.gioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gioitinh.FocusedColor = System.Drawing.Color.Empty;
            this.gioitinh.FocusedState.Parent = this.gioitinh;
            this.gioitinh.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gioitinh.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gioitinh.FormattingEnabled = true;
            this.gioitinh.HoverState.Parent = this.gioitinh;
            this.gioitinh.ItemHeight = 30;
            this.gioitinh.Items.AddRange(new object[] {
            "Nam ",
            "Nữ",
            "Khác"});
            this.gioitinh.ItemsAppearance.Parent = this.gioitinh;
            this.gioitinh.Location = new System.Drawing.Point(774, 235);
            this.gioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.ShadowDecoration.Parent = this.gioitinh;
            this.gioitinh.Size = new System.Drawing.Size(128, 36);
            this.gioitinh.TabIndex = 108;
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1470, 845);
            this.Controls.Add(this.gioitinh);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.dgvkh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picsearch);
            this.Controls.Add(this.picDangXuat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelKH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbThongKe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbBanHang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbNhanVien);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.lbSanPham);
            this.Controls.Add(this.txtmakh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttenkh);
            this.Controls.Add(this.Main);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.diachi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAM Manager | Khách hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDangXuat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picsearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picDangXuat;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelKH;
        private System.Windows.Forms.Label lbThongKe;
        private System.Windows.Forms.Label lbBanHang;
        private System.Windows.Forms.Label lbNhanVien;
        private System.Windows.Forms.Label lbSanPham;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Main;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtmakh;
        private Guna.UI2.WinForms.Guna2TextBox txttenkh;
        private Guna.UI2.WinForms.Guna2TextBox txtsdt;
        private Guna.UI2.WinForms.Guna2TextBox diachi;
        private Guna.UI2.WinForms.Guna2DataGridView dgvkh;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2Button btnupdate;
        private Guna.UI2.WinForms.Guna2Button btndel;
        private System.Windows.Forms.PictureBox picsearch;
        private Guna.UI2.WinForms.Guna2TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ComboBox gioitinh;
    }
}