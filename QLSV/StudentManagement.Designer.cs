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
            this.panelRight = new System.Windows.Forms.Panel();
            this.labelDanhSach = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.buttonTim = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelLeft.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.WhiteSmoke;
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
            this.panelLeft.Size = new System.Drawing.Size(350, 700);
            this.panelLeft.TabIndex = 0;
            this.panelLeft.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLeft_Paint);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelTitle.Location = new System.Drawing.Point(20, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(210, 30);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thông tin sinh viên";
            // 
            // labelMaSV
            // 
            this.labelMaSV.AutoSize = true;
            this.labelMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelMaSV.Location = new System.Drawing.Point(20, 70);
            this.labelMaSV.Name = "labelMaSV";
            this.labelMaSV.Size = new System.Drawing.Size(74, 15);
            this.labelMaSV.TabIndex = 1;
            this.labelMaSV.Text = "Mã sinh viên";
            // 
            // textBoxMaSV
            // 
            this.textBoxMaSV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxMaSV.Location = new System.Drawing.Point(20, 90);
            this.textBoxMaSV.Name = "textBoxMaSV";
            this.textBoxMaSV.Size = new System.Drawing.Size(310, 23);
            this.textBoxMaSV.TabIndex = 2;
            // 
            // labelHoTen
            // 
            this.labelHoTen.AutoSize = true;
            this.labelHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelHoTen.Location = new System.Drawing.Point(20, 125);
            this.labelHoTen.Name = "labelHoTen";
            this.labelHoTen.Size = new System.Drawing.Size(43, 15);
            this.labelHoTen.TabIndex = 3;
            this.labelHoTen.Text = "Họ tên";
            // 
            // textBoxHoTen
            // 
            this.textBoxHoTen.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxHoTen.Location = new System.Drawing.Point(20, 145);
            this.textBoxHoTen.Name = "textBoxHoTen";
            this.textBoxHoTen.Size = new System.Drawing.Size(310, 23);
            this.textBoxHoTen.TabIndex = 4;
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelNgaySinh.Location = new System.Drawing.Point(20, 180);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(60, 15);
            this.labelNgaySinh.TabIndex = 5;
            this.labelNgaySinh.Text = "Ngày sinh";
            // 
            // dateTimePickerNgaySinh
            // 
            this.dateTimePickerNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateTimePickerNgaySinh.Location = new System.Drawing.Point(20, 200);
            this.dateTimePickerNgaySinh.Name = "dateTimePickerNgaySinh";
            this.dateTimePickerNgaySinh.Size = new System.Drawing.Size(310, 23);
            this.dateTimePickerNgaySinh.TabIndex = 6;
            // 
            // labelGioiTinh
            // 
            this.labelGioiTinh.AutoSize = true;
            this.labelGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelGioiTinh.Location = new System.Drawing.Point(20, 235);
            this.labelGioiTinh.Name = "labelGioiTinh";
            this.labelGioiTinh.Size = new System.Drawing.Size(52, 15);
            this.labelGioiTinh.TabIndex = 7;
            this.labelGioiTinh.Text = "Giới tính";
            // 
            // comboBoxGioiTinh
            // 
            this.comboBoxGioiTinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBoxGioiTinh.Location = new System.Drawing.Point(20, 255);
            this.comboBoxGioiTinh.Name = "comboBoxGioiTinh";
            this.comboBoxGioiTinh.Size = new System.Drawing.Size(310, 23);
            this.comboBoxGioiTinh.TabIndex = 8;
            // 
            // labelLop
            // 
            this.labelLop.AutoSize = true;
            this.labelLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelLop.Location = new System.Drawing.Point(20, 290);
            this.labelLop.Name = "labelLop";
            this.labelLop.Size = new System.Drawing.Size(27, 15);
            this.labelLop.TabIndex = 9;
            this.labelLop.Text = "Lớp";
            // 
            // comboBoxLop
            // 
            this.comboBoxLop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxLop.Items.AddRange(new object[] {
            "CNTT1",
            "CNTT2",
            "CNTT3",
            "KT1",
            "KT2"});
            this.comboBoxLop.Location = new System.Drawing.Point(20, 310);
            this.comboBoxLop.Name = "comboBoxLop";
            this.comboBoxLop.Size = new System.Drawing.Size(310, 23);
            this.comboBoxLop.TabIndex = 10;
            // 
            // panelButtons
            // 
            this.panelButtons.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelButtons.Controls.Add(this.buttonThem);
            this.panelButtons.Controls.Add(this.buttonSua);
            this.panelButtons.Controls.Add(this.buttonXoa);
            this.panelButtons.Controls.Add(this.buttonLamMoi);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 530);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(350, 170);
            this.panelButtons.TabIndex = 15;
            // 
            // buttonThem
            // 
            this.buttonThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
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
            this.buttonSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
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
            this.buttonXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
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
            this.buttonLamMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
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
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.White;
            this.panelRight.Controls.Add(this.labelDanhSach);
            this.panelRight.Controls.Add(this.textBoxTimKiem);
            this.panelRight.Controls.Add(this.buttonTim);
            this.panelRight.Controls.Add(this.dataGridView1);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(350, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(700, 700);
            this.panelRight.TabIndex = 1;
            // 
            // labelDanhSach
            // 
            this.labelDanhSach.AutoSize = true;
            this.labelDanhSach.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.labelDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelDanhSach.Location = new System.Drawing.Point(20, 20);
            this.labelDanhSach.Name = "labelDanhSach";
            this.labelDanhSach.Size = new System.Drawing.Size(185, 25);
            this.labelDanhSach.TabIndex = 0;
            this.labelDanhSach.Text = "Danh sách sinh viên";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBoxTimKiem.Location = new System.Drawing.Point(20, 60);
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(600, 23);
            this.textBoxTimKiem.TabIndex = 1;
            // 
            // buttonTim
            // 
            this.buttonTim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTim.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonTim.ForeColor = System.Drawing.Color.White;
            this.buttonTim.Location = new System.Drawing.Point(630, 60);
            this.buttonTim.Name = "buttonTim";
            this.buttonTim.Size = new System.Drawing.Size(50, 25);
            this.buttonTim.TabIndex = 2;
            this.buttonTim.Text = "Tìm";
            this.buttonTim.UseVisualStyleBackColor = false;
            this.buttonTim.Click += new System.EventHandler(this.buttonTim_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(660, 580);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // StudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 700);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelLeft);
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
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Label labelDanhSach;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.Button buttonTim;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
