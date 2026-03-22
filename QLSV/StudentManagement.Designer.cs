namespace QLSV
{
    partial class StudentManagement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelLeft = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelMaSV = new System.Windows.Forms.Label();
            this.textBoxMaSV = new System.Windows.Forms.TextBox();
            this.labelHoTen = new System.Windows.Forms.Label();
            this.textBoxHoTen = new System.Windows.Forms.TextBox();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.dateTimePickerNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.labelGioiTinh = new System.Windows.Forms.Label();
            this.comboBoxGioiTinh = new System.Windows.Forms.ComboBox();
            this.labelLop = new System.Windows.Forms.Label();
            this.comboBoxLop = new System.Windows.Forms.ComboBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonQuanLyLop = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelDanhSach = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelPagination = new System.Windows.Forms.Panel();
            this.labelRowsPerPage = new System.Windows.Forms.Label();
            this.comboBoxPageSize = new System.Windows.Forms.ComboBox();
            this.buttonFirstPage = new System.Windows.Forms.Button();
            this.buttonPreviousPage = new System.Windows.Forms.Button();
            this.labelPageInfo = new System.Windows.Forms.Label();
            this.buttonNextPage = new System.Windows.Forms.Button();
            this.buttonLastPage = new System.Windows.Forms.Button();
            this.labelPageStatus = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Controls.Add(this.labelMaSV);
            this.panelLeft.Controls.Add(this.textBoxMaSV);
            this.panelLeft.Controls.Add(this.labelHoTen);
            this.panelLeft.Controls.Add(this.textBoxHoTen);
            this.panelLeft.Controls.Add(this.labelNgaySinh);
            this.panelLeft.Controls.Add(this.dateTimePickerNgaySinh);
            this.panelLeft.Controls.Add(this.labelGioiTinh);
            this.panelLeft.Controls.Add(this.comboBoxGioiTinh);
            this.panelLeft.Controls.Add(this.labelLop);
            this.panelLeft.Controls.Add(this.comboBoxLop);
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(350, 720);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(195, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thông tin sinh viên";
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMaSV.Location = new System.Drawing.Point(20, 72);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(39, 15);
            this.labelMaSV.TabIndex = 1;
            this.labelMaSV.Text = "Mã SV";
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxMaSV.Location = new System.Drawing.Point(20, 92);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(310, 24);
            this.textBoxMaSV.TabIndex = 2;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelHoTen.Location = new System.Drawing.Point(20, 128);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(45, 15);
            this.labelHoTen.TabIndex = 3;
            this.labelHoTen.Text = "Họ tên";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxHoTen.Location = new System.Drawing.Point(20, 148);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(310, 24);
            this.textBoxHoTen.TabIndex = 4;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNgaySinh.Location = new System.Drawing.Point(20, 184);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(57, 15);
            this.labelNgaySinh.TabIndex = 5;
            this.labelNgaySinh.Text = "Ngày sinh";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dateTimePickerNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(20, 204);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(310, 24);
            this.dateTimePickerNgaySinh.TabIndex = 6;
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelGioiTinh.Location = new System.Drawing.Point(20, 240);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(53, 15);
            this.labelGioiTinh.TabIndex = 7;
            this.labelGioiTinh.Text = "Giới tính";
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboBoxGioiTinh.FormattingEnabled = true;
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(20, 260);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(310, 25);
            this.comboBoxGioiTinh.TabIndex = 8;
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLop.Location = new System.Drawing.Point(20, 297);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(26, 15);
            this.labelLop.TabIndex = 9;
            this.labelLop.Text = "Lớp";
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.comboBoxLop.FormattingEnabled = true;
            this.comboBoxLop.Location = new System.Drawing.Point(20, 317);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(310, 25);
            this.comboBoxLop.TabIndex = 10;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.panelButtons.Controls.Add(this.buttonThem);
            this.panelButtons.Controls.Add(this.buttonSua);
            this.panelButtons.Controls.Add(this.buttonXoa);
            this.panelButtons.Controls.Add(this.buttonLamMoi);
            this.panelButtons.Controls.Add(this.buttonQuanLyLop);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 500);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(350, 220);
            this.panelButtons.TabIndex = 15;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.buttonThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThem.FlatAppearance.BorderSize = 0;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Location = new System.Drawing.Point(20, 20);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(140, 45);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.buttonSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(180, 20);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(140, 45);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Cập nhật";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(20, 80);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(140, 45);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.buttonLamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLamMoi.FlatAppearance.BorderSize = 0;
            this.buttonLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLamMoi.ForeColor = System.Drawing.Color.White;
            this.buttonLamMoi.Location = new System.Drawing.Point(180, 80);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(140, 45);
            this.buttonLamMoi.TabIndex = 3;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = false;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonQuanLyLop
            // 
            this.buttonQuanLyLop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.buttonQuanLyLop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuanLyLop.FlatAppearance.BorderSize = 0;
            this.buttonQuanLyLop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLyLop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonQuanLyLop.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLyLop.Location = new System.Drawing.Point(20, 145);
            this.buttonQuanLyLop.Name = "buttonQuanLyLop";
            this.buttonQuanLyLop.Size = new System.Drawing.Size(300, 45);
            this.buttonQuanLyLop.TabIndex = 4;
            this.buttonQuanLyLop.Text = "Quản lý lớp học";
            this.buttonQuanLyLop.UseVisualStyleBackColor = false;
            this.buttonQuanLyLop.Click += new System.EventHandler(this.buttonQuanLyLop_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelRight.Controls.Add(this.panelPagination);
            this.panelRight.Controls.Add(this.dataGridView1);
            this.panelRight.Controls.Add(this.buttonTim);
            this.panelRight.Controls.Add(this.textBoxTimKiem);
            this.panelRight.Controls.Add(this.labelDanhSach);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(350, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(730, 720);
            this.panelRight.TabIndex = 1;
            // 
            // labelDanhSach
            // 
            this.labelDanhSach.AutoSize = true;
            this.labelDanhSach.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.labelDanhSach.Location = new System.Drawing.Point(20, 20);
            this.labelDanhSach.Name = "labelDanhSach";
            this.labelDanhSach.Size = new System.Drawing.Size(177, 25);
            this.labelDanhSach.TabIndex = 0;
            this.labelDanhSach.Text = "Danh sách sinh viên";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxTimKiem.Location = new System.Drawing.Point(20, 60);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(580, 24);
            this.textBoxTimKiem.TabIndex = 1;
            // 
            // buttonTim
            // 
            this.buttonTim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.buttonTim.FlatAppearance.BorderSize = 0;
            this.buttonTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonTim.ForeColor = System.Drawing.Color.White;
            this.buttonTim.Location = new System.Drawing.Point(610, 59);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(90, 27);
            this.buttonTim.TabIndex = 2;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Location = new System.Drawing.Point(20, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(680, 560);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panelPagination
            // 
            this.panelPagination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPagination.BackColor = System.Drawing.Color.White;
            this.panelPagination.Controls.Add(this.labelRowsPerPage);
            this.panelPagination.Controls.Add(this.comboBoxPageSize);
            this.panelPagination.Controls.Add(this.buttonFirstPage);
            this.panelPagination.Controls.Add(this.buttonPreviousPage);
            this.panelPagination.Controls.Add(this.labelPageInfo);
            this.panelPagination.Controls.Add(this.buttonNextPage);
            this.panelPagination.Controls.Add(this.buttonLastPage);
            this.panelPagination.Controls.Add(this.labelPageStatus);
            this.panelPagination.Location = new System.Drawing.Point(20, 668);
            this.panelPagination.Name = "panelPagination";
            this.panelPagination.Size = new System.Drawing.Size(680, 40);
            this.panelPagination.TabIndex = 4;
            // 
            // labelRowsPerPage
            // 
            this.labelRowsPerPage.AutoSize = true;
            this.labelRowsPerPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelRowsPerPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.labelRowsPerPage.Location = new System.Drawing.Point(6, 12);
            this.labelRowsPerPage.Name = "labelRowsPerPage";
            this.labelRowsPerPage.Size = new System.Drawing.Size(67, 15);
            this.labelRowsPerPage.TabIndex = 0;
            this.labelRowsPerPage.Text = "Dòng/trang";
            // 
            // comboBoxPageSize
            // 
            this.comboBoxPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPageSize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxPageSize.FormattingEnabled = true;
            this.comboBoxPageSize.Location = new System.Drawing.Point(79, 8);
            this.comboBoxPageSize.Name = "comboBoxPageSize";
            this.comboBoxPageSize.Size = new System.Drawing.Size(58, 23);
            this.comboBoxPageSize.TabIndex = 1;
            this.comboBoxPageSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxPageSize_SelectedIndexChanged);
            // 
            // buttonFirstPage
            // 
            this.buttonFirstPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonFirstPage.FlatAppearance.BorderSize = 0;
            this.buttonFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFirstPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonFirstPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonFirstPage.Location = new System.Drawing.Point(168, 7);
            this.buttonFirstPage.Name = "buttonFirstPage";
            this.buttonFirstPage.Size = new System.Drawing.Size(42, 25);
            this.buttonFirstPage.TabIndex = 2;
            this.buttonFirstPage.Text = "<<";
            this.buttonFirstPage.UseVisualStyleBackColor = false;
            this.buttonFirstPage.Click += new System.EventHandler(this.buttonFirstPage_Click);
            // 
            // buttonPreviousPage
            // 
            this.buttonPreviousPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonPreviousPage.FlatAppearance.BorderSize = 0;
            this.buttonPreviousPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPreviousPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonPreviousPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonPreviousPage.Location = new System.Drawing.Point(216, 7);
            this.buttonPreviousPage.Name = "buttonPreviousPage";
            this.buttonPreviousPage.Size = new System.Drawing.Size(42, 25);
            this.buttonPreviousPage.TabIndex = 3;
            this.buttonPreviousPage.Text = "<";
            this.buttonPreviousPage.UseVisualStyleBackColor = false;
            this.buttonPreviousPage.Click += new System.EventHandler(this.buttonPreviousPage_Click);
            // 
            // labelPageInfo
            // 
            this.labelPageInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.labelPageInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.labelPageInfo.Location = new System.Drawing.Point(264, 7);
            this.labelPageInfo.Name = "labelPageInfo";
            this.labelPageInfo.Size = new System.Drawing.Size(104, 25);
            this.labelPageInfo.TabIndex = 4;
            this.labelPageInfo.Text = "Trang 0/0";
            this.labelPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonNextPage
            // 
            this.buttonNextPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonNextPage.FlatAppearance.BorderSize = 0;
            this.buttonNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonNextPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonNextPage.Location = new System.Drawing.Point(374, 7);
            this.buttonNextPage.Name = "buttonNextPage";
            this.buttonNextPage.Size = new System.Drawing.Size(42, 25);
            this.buttonNextPage.TabIndex = 5;
            this.buttonNextPage.Text = ">";
            this.buttonNextPage.UseVisualStyleBackColor = false;
            this.buttonNextPage.Click += new System.EventHandler(this.buttonNextPage_Click);
            // 
            // buttonLastPage
            // 
            this.buttonLastPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonLastPage.FlatAppearance.BorderSize = 0;
            this.buttonLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLastPage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonLastPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonLastPage.Location = new System.Drawing.Point(422, 7);
            this.buttonLastPage.Name = "buttonLastPage";
            this.buttonLastPage.Size = new System.Drawing.Size(42, 25);
            this.buttonLastPage.TabIndex = 6;
            this.buttonLastPage.Text = ">>";
            this.buttonLastPage.UseVisualStyleBackColor = false;
            this.buttonLastPage.Click += new System.EventHandler(this.buttonLastPage_Click);
            // 
            // labelPageStatus
            // 
            this.labelPageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPageStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelPageStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.labelPageStatus.Location = new System.Drawing.Point(492, 10);
            this.labelPageStatus.Name = "labelPageStatus";
            this.labelPageStatus.Size = new System.Drawing.Size(175, 18);
            this.labelPageStatus.TabIndex = 7;
            this.labelPageStatus.Text = "0-0 / 0 sinh viên";
            this.labelPageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.MinimumSize = new System.Drawing.Size(1096, 759);
            this.Name = "StudentManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.Load += new System.EventHandler(this.StudentManagement_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelPagination.ResumeLayout(false);
            this.panelPagination.PerformLayout();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMaSV;
        private System.Windows.Forms.TextBox textBoxMaSV;
        private System.Windows.Forms.Label labelHoTen;
        private System.Windows.Forms.TextBox textBoxHoTen;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaySinh;
        private System.Windows.Forms.Label labelGioiTinh;
        private System.Windows.Forms.ComboBox comboBoxGioiTinh;
        private System.Windows.Forms.Label labelLop;
        private System.Windows.Forms.ComboBox comboBoxLop;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonQuanLyLop;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelDanhSach;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelPagination;
        private System.Windows.Forms.Label labelRowsPerPage;
        private System.Windows.Forms.ComboBox comboBoxPageSize;
        private System.Windows.Forms.Button buttonFirstPage;
        private System.Windows.Forms.Button buttonPreviousPage;
        private System.Windows.Forms.Label labelPageInfo;
        private System.Windows.Forms.Button buttonNextPage;
        private System.Windows.Forms.Button buttonLastPage;
        private System.Windows.Forms.Label labelPageStatus;
    }
}
