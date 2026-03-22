namespace QLSV
{
    partial class ClassManagement
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
            this.labelMaLop = new System.Windows.Forms.Label();
            this.textBoxMaLop = new System.Windows.Forms.TextBox();
            this.labelTenLop = new System.Windows.Forms.Label();
            this.textBoxTenLop = new System.Windows.Forms.TextBox();
            this.labelGhiChu = new System.Windows.Forms.Label();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLamMoi = new System.Windows.Forms.Button();
            this.buttonXemSV = new System.Windows.Forms.Button();
            this.buttonQuanLySinhVien = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelDanhSachLop = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.dataGridViewLop = new System.Windows.Forms.DataGridView();
            this.panelClassPagination = new System.Windows.Forms.Panel();
            this.labelClassRowsPerPage = new System.Windows.Forms.Label();
            this.comboBoxClassPageSize = new System.Windows.Forms.ComboBox();
            this.buttonClassFirst = new System.Windows.Forms.Button();
            this.buttonClassPrevious = new System.Windows.Forms.Button();
            this.labelClassPageInfo = new System.Windows.Forms.Label();
            this.buttonClassNext = new System.Windows.Forms.Button();
            this.buttonClassLast = new System.Windows.Forms.Button();
            this.labelClassPageStatus = new System.Windows.Forms.Label();
            this.panelLeft.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).BeginInit();
            this.panelClassPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.panelLeft.Controls.Add(this.labelTitle);
            this.panelLeft.Controls.Add(this.labelMaLop);
            this.panelLeft.Controls.Add(this.textBoxMaLop);
            this.panelLeft.Controls.Add(this.labelTenLop);
            this.panelLeft.Controls.Add(this.textBoxTenLop);
            this.panelLeft.Controls.Add(this.labelGhiChu);
            this.panelLeft.Controls.Add(this.textBoxGhiChu);
            this.panelLeft.Controls.Add(this.panelButtons);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(467, 886);
            this.panelLeft.TabIndex = 1;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.labelTitle.Location = new System.Drawing.Point(27, 25);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(196, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thông tin lớp học";
            // 
            // labelMaLop
            // 
            this.labelMaLop.AutoSize = true;
            this.labelMaLop.Location = new System.Drawing.Point(27, 89);
            this.labelMaLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaLop.Name = "labelMaLop";
            this.labelMaLop.Size = new System.Drawing.Size(48, 16);
            this.labelMaLop.TabIndex = 1;
            this.labelMaLop.Text = "Mã lớp";
            // 
            // textBoxMaLop
            // 
            this.textBoxMaLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxMaLop.Location = new System.Drawing.Point(27, 113);
            this.textBoxMaLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxMaLop.Name = "textBoxMaLop";
            this.textBoxMaLop.Size = new System.Drawing.Size(412, 24);
            this.textBoxMaLop.TabIndex = 2;
            // 
            // labelTenLop
            // 
            this.labelTenLop.AutoSize = true;
            this.labelTenLop.Location = new System.Drawing.Point(27, 158);
            this.labelTenLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenLop.Name = "labelTenLop";
            this.labelTenLop.Size = new System.Drawing.Size(53, 16);
            this.labelTenLop.TabIndex = 3;
            this.labelTenLop.Text = "Tên lớp";
            // 
            // textBoxTenLop
            // 
            this.textBoxTenLop.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxTenLop.Location = new System.Drawing.Point(27, 182);
            this.textBoxTenLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTenLop.Name = "textBoxTenLop";
            this.textBoxTenLop.Size = new System.Drawing.Size(412, 24);
            this.textBoxTenLop.TabIndex = 4;
            // 
            // labelGhiChu
            // 
            this.labelGhiChu.AutoSize = true;
            this.labelGhiChu.Location = new System.Drawing.Point(27, 226);
            this.labelGhiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGhiChu.Name = "labelGhiChu";
            this.labelGhiChu.Size = new System.Drawing.Size(51, 16);
            this.labelGhiChu.TabIndex = 5;
            this.labelGhiChu.Text = "Ghi chú";
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxGhiChu.Location = new System.Drawing.Point(27, 251);
            this.textBoxGhiChu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxGhiChu.Multiline = true;
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxGhiChu.Size = new System.Drawing.Size(412, 110);
            this.textBoxGhiChu.TabIndex = 6;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.panelButtons.Controls.Add(this.buttonThem);
            this.panelButtons.Controls.Add(this.buttonSua);
            this.panelButtons.Controls.Add(this.buttonXoa);
            this.panelButtons.Controls.Add(this.buttonLamMoi);
            this.panelButtons.Controls.Add(this.buttonXemSV);
            this.panelButtons.Controls.Add(this.buttonQuanLySinhVien);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 554);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(467, 332);
            this.panelButtons.TabIndex = 7;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(163)))), ((int)(((byte)(74)))));
            this.buttonThem.FlatAppearance.BorderSize = 0;
            this.buttonThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonThem.ForeColor = System.Drawing.Color.White;
            this.buttonThem.Location = new System.Drawing.Point(27, 25);
            this.buttonThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(187, 55);
            this.buttonThem.TabIndex = 0;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = false;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(99)))), ((int)(((byte)(235)))));
            this.buttonSua.FlatAppearance.BorderSize = 0;
            this.buttonSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonSua.ForeColor = System.Drawing.Color.White;
            this.buttonSua.Location = new System.Drawing.Point(240, 25);
            this.buttonSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(187, 55);
            this.buttonSua.TabIndex = 1;
            this.buttonSua.Text = "Cập nhật";
            this.buttonSua.UseVisualStyleBackColor = false;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.buttonXoa.FlatAppearance.BorderSize = 0;
            this.buttonXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXoa.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonXoa.ForeColor = System.Drawing.Color.White;
            this.buttonXoa.Location = new System.Drawing.Point(27, 98);
            this.buttonXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(187, 55);
            this.buttonXoa.TabIndex = 2;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = false;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonLamMoi
            // 
            this.buttonLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(158)))), ((int)(((byte)(11)))));
            this.buttonLamMoi.FlatAppearance.BorderSize = 0;
            this.buttonLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLamMoi.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonLamMoi.ForeColor = System.Drawing.Color.White;
            this.buttonLamMoi.Location = new System.Drawing.Point(240, 98);
            this.buttonLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonLamMoi.Name = "buttonLamMoi";
            this.buttonLamMoi.Size = new System.Drawing.Size(187, 55);
            this.buttonLamMoi.TabIndex = 3;
            this.buttonLamMoi.Text = "Làm mới";
            this.buttonLamMoi.UseVisualStyleBackColor = false;
            this.buttonLamMoi.Click += new System.EventHandler(this.buttonLamMoi_Click);
            // 
            // buttonXemSV
            // 
            this.buttonXemSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
            this.buttonXemSV.FlatAppearance.BorderSize = 0;
            this.buttonXemSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXemSV.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonXemSV.ForeColor = System.Drawing.Color.White;
            this.buttonXemSV.Location = new System.Drawing.Point(27, 178);
            this.buttonXemSV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonXemSV.Name = "buttonXemSV";
            this.buttonXemSV.Size = new System.Drawing.Size(400, 55);
            this.buttonXemSV.TabIndex = 4;
            this.buttonXemSV.Text = "Xem sinh viên của lớp";
            this.buttonXemSV.UseVisualStyleBackColor = false;
            this.buttonXemSV.Click += new System.EventHandler(this.buttonXemSV_Click);
            // 
            // buttonQuanLySinhVien
            // 
            this.buttonQuanLySinhVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.buttonQuanLySinhVien.FlatAppearance.BorderSize = 0;
            this.buttonQuanLySinhVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQuanLySinhVien.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.buttonQuanLySinhVien.ForeColor = System.Drawing.Color.White;
            this.buttonQuanLySinhVien.Location = new System.Drawing.Point(27, 246);
            this.buttonQuanLySinhVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonQuanLySinhVien.Name = "buttonQuanLySinhVien";
            this.buttonQuanLySinhVien.Size = new System.Drawing.Size(400, 55);
            this.buttonQuanLySinhVien.TabIndex = 5;
            this.buttonQuanLySinhVien.Text = "Quay lại quản lý sinh viên";
            this.buttonQuanLySinhVien.UseVisualStyleBackColor = false;
            this.buttonQuanLySinhVien.Click += new System.EventHandler(this.buttonQuanLySinhVien_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.panelRight.Controls.Add(this.labelDanhSachLop);
            this.panelRight.Controls.Add(this.textBoxTimKiem);
            this.panelRight.Controls.Add(this.buttonTim);
            this.panelRight.Controls.Add(this.dataGridViewLop);
            this.panelRight.Controls.Add(this.panelClassPagination);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(467, 0);
            this.panelRight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(1026, 886);
            this.panelRight.TabIndex = 0;
            // 
            // labelDanhSachLop
            // 
            this.labelDanhSachLop.AutoSize = true;
            this.labelDanhSachLop.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelDanhSachLop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.labelDanhSachLop.Location = new System.Drawing.Point(27, 25);
            this.labelDanhSachLop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDanhSachLop.Name = "labelDanhSachLop";
            this.labelDanhSachLop.Size = new System.Drawing.Size(173, 25);
            this.labelDanhSachLop.TabIndex = 0;
            this.labelDanhSachLop.Text = "Danh sách lớp học";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.textBoxTimKiem.Location = new System.Drawing.Point(27, 74);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(1584, 24);
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
            this.buttonTim.Location = new System.Drawing.Point(1626, 71);
            this.buttonTim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(120, 34);
            this.buttonTim.TabIndex = 2;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // dataGridViewLop
            // 
            this.dataGridViewLop.AllowUserToAddRows = false;
            this.dataGridViewLop.AllowUserToDeleteRows = false;
            this.dataGridViewLop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewLop.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewLop.Location = new System.Drawing.Point(27, 123);
            this.dataGridViewLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewLop.Name = "dataGridViewLop";
            this.dataGridViewLop.ReadOnly = true;
            this.dataGridViewLop.Size = new System.Drawing.Size(1719, 664);
            this.dataGridViewLop.TabIndex = 3;
            this.dataGridViewLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLop_CellClick);
            // 
            // panelClassPagination
            // 
            this.panelClassPagination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelClassPagination.BackColor = System.Drawing.Color.White;
            this.panelClassPagination.Controls.Add(this.labelClassRowsPerPage);
            this.panelClassPagination.Controls.Add(this.comboBoxClassPageSize);
            this.panelClassPagination.Controls.Add(this.buttonClassFirst);
            this.panelClassPagination.Controls.Add(this.buttonClassPrevious);
            this.panelClassPagination.Controls.Add(this.labelClassPageInfo);
            this.panelClassPagination.Controls.Add(this.buttonClassNext);
            this.panelClassPagination.Controls.Add(this.buttonClassLast);
            this.panelClassPagination.Controls.Add(this.labelClassPageStatus);
            this.panelClassPagination.Location = new System.Drawing.Point(27, 806);
            this.panelClassPagination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelClassPagination.Name = "panelClassPagination";
            this.panelClassPagination.Size = new System.Drawing.Size(1719, 49);
            this.panelClassPagination.TabIndex = 4;
            // 
            // labelClassRowsPerPage
            // 
            this.labelClassRowsPerPage.AutoSize = true;
            this.labelClassRowsPerPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.labelClassRowsPerPage.Location = new System.Drawing.Point(8, 15);
            this.labelClassRowsPerPage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClassRowsPerPage.Name = "labelClassRowsPerPage";
            this.labelClassRowsPerPage.Size = new System.Drawing.Size(74, 16);
            this.labelClassRowsPerPage.TabIndex = 0;
            this.labelClassRowsPerPage.Text = "Dòng/trang";
            // 
            // comboBoxClassPageSize
            // 
            this.comboBoxClassPageSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClassPageSize.Location = new System.Drawing.Point(105, 10);
            this.comboBoxClassPageSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxClassPageSize.Name = "comboBoxClassPageSize";
            this.comboBoxClassPageSize.Size = new System.Drawing.Size(76, 24);
            this.comboBoxClassPageSize.TabIndex = 1;
            this.comboBoxClassPageSize.SelectedIndexChanged += new System.EventHandler(this.comboBoxClassPageSize_SelectedIndexChanged);
            // 
            // buttonClassFirst
            // 
            this.buttonClassFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonClassFirst.FlatAppearance.BorderSize = 0;
            this.buttonClassFirst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClassFirst.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonClassFirst.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonClassFirst.Location = new System.Drawing.Point(224, 9);
            this.buttonClassFirst.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClassFirst.Name = "buttonClassFirst";
            this.buttonClassFirst.Size = new System.Drawing.Size(56, 31);
            this.buttonClassFirst.TabIndex = 2;
            this.buttonClassFirst.Text = "<<";
            this.buttonClassFirst.UseVisualStyleBackColor = false;
            this.buttonClassFirst.Click += new System.EventHandler(this.buttonClassFirst_Click);
            // 
            // buttonClassPrevious
            // 
            this.buttonClassPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonClassPrevious.FlatAppearance.BorderSize = 0;
            this.buttonClassPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClassPrevious.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonClassPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonClassPrevious.Location = new System.Drawing.Point(288, 9);
            this.buttonClassPrevious.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClassPrevious.Name = "buttonClassPrevious";
            this.buttonClassPrevious.Size = new System.Drawing.Size(56, 31);
            this.buttonClassPrevious.TabIndex = 3;
            this.buttonClassPrevious.Text = "<";
            this.buttonClassPrevious.UseVisualStyleBackColor = false;
            this.buttonClassPrevious.Click += new System.EventHandler(this.buttonClassPrevious_Click);
            // 
            // labelClassPageInfo
            // 
            this.labelClassPageInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(246)))), ((int)(((byte)(255)))));
            this.labelClassPageInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelClassPageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(64)))), ((int)(((byte)(175)))));
            this.labelClassPageInfo.Location = new System.Drawing.Point(352, 9);
            this.labelClassPageInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClassPageInfo.Name = "labelClassPageInfo";
            this.labelClassPageInfo.Size = new System.Drawing.Size(139, 31);
            this.labelClassPageInfo.TabIndex = 4;
            this.labelClassPageInfo.Text = "Trang 0/0";
            this.labelClassPageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonClassNext
            // 
            this.buttonClassNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonClassNext.FlatAppearance.BorderSize = 0;
            this.buttonClassNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClassNext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonClassNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonClassNext.Location = new System.Drawing.Point(499, 9);
            this.buttonClassNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClassNext.Name = "buttonClassNext";
            this.buttonClassNext.Size = new System.Drawing.Size(56, 31);
            this.buttonClassNext.TabIndex = 5;
            this.buttonClassNext.Text = ">";
            this.buttonClassNext.UseVisualStyleBackColor = false;
            this.buttonClassNext.Click += new System.EventHandler(this.buttonClassNext_Click);
            // 
            // buttonClassLast
            // 
            this.buttonClassLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.buttonClassLast.FlatAppearance.BorderSize = 0;
            this.buttonClassLast.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClassLast.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonClassLast.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.buttonClassLast.Location = new System.Drawing.Point(563, 9);
            this.buttonClassLast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClassLast.Name = "buttonClassLast";
            this.buttonClassLast.Size = new System.Drawing.Size(56, 31);
            this.buttonClassLast.TabIndex = 6;
            this.buttonClassLast.Text = ">>";
            this.buttonClassLast.UseVisualStyleBackColor = false;
            this.buttonClassLast.Click += new System.EventHandler(this.buttonClassLast_Click);
            // 
            // labelClassPageStatus
            // 
            this.labelClassPageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelClassPageStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(85)))), ((int)(((byte)(105)))));
            this.labelClassPageStatus.Location = new System.Drawing.Point(1498, 12);
            this.labelClassPageStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClassPageStatus.Name = "labelClassPageStatus";
            this.labelClassPageStatus.Size = new System.Drawing.Size(204, 22);
            this.labelClassPageStatus.TabIndex = 7;
            this.labelClassPageStatus.Text = "0-0 / 0 lớp";
            this.labelClassPageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 886);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1509, 925);
            this.Name = "ClassManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý lớp học";
            this.Load += new System.EventHandler(this.ClassManagement_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLop)).EndInit();
            this.panelClassPagination.ResumeLayout(false);
            this.panelClassPagination.PerformLayout();
            this.ResumeLayout(false);

        }



        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMaLop;
        private System.Windows.Forms.TextBox textBoxMaLop;
        private System.Windows.Forms.Label labelTenLop;
        private System.Windows.Forms.TextBox textBoxTenLop;
        private System.Windows.Forms.Label labelGhiChu;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonLamMoi;
        private System.Windows.Forms.Button buttonXemSV;
        private System.Windows.Forms.Button buttonQuanLySinhVien;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelDanhSachLop;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.DataGridView dataGridViewLop;
        private System.Windows.Forms.Panel panelClassPagination;
        private System.Windows.Forms.Label labelClassRowsPerPage;
        private System.Windows.Forms.ComboBox comboBoxClassPageSize;
        private System.Windows.Forms.Button buttonClassFirst;
        private System.Windows.Forms.Button buttonClassPrevious;
        private System.Windows.Forms.Label labelClassPageInfo;
        private System.Windows.Forms.Button buttonClassNext;
        private System.Windows.Forms.Button buttonClassLast;
        private System.Windows.Forms.Label labelClassPageStatus;
    }
}
