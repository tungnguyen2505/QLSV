using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class StudentManagement : Form
    {
        private readonly QLSVDBDataContext db = new QLSVDBDataContext();

        private List<Student> students = new List<Student>();
        private List<Student> filteredStudents = new List<Student>();
        private string selectedStudentId = string.Empty;
        private int currentPage = 1;
        private int pageSize = 10;

        public StudentManagement()
        {
            InitializeComponent();
            ApplyVisualStyles();
            InitializePagination();
            LoadLopComboBox();
            LoadDataFromDatabase(true);
        }

        public void RefreshManagementData()
        {
            LoadLopComboBox();
            LoadDataFromDatabase(true);
        }

        private void ApplyVisualStyles()
        {
            GridStyleHelper.ApplyPrimary(dataGridView1);
        }

        private void InitializePagination()
        {
            if (comboBoxPageSize.Items.Count == 0)
            {
                comboBoxPageSize.Items.AddRange(new object[] { "5", "10", "20", "50" });
            }

            comboBoxPageSize.SelectedItem = pageSize.ToString();
        }

        private void LoadLopComboBox()
        {
            try
            {
                var dsLop = db.Lops
                    .OrderBy(l => l.MaLop)
                    .ToList();

                comboBoxLop.DisplayMember = "TenLop";
                comboBoxLop.ValueMember = "MaLop";
                comboBoxLop.DataSource = dsLop;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách lớp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataFromDatabase(bool resetPage)
        {
            try
            {
                var query = from sv in db.SinhViens
                            join lop in db.Lops on sv.MaLop equals lop.MaLop
                            orderby sv.MaSV
                            select new Student
                            {
                                MaSV = sv.MaSV,
                                HoTen = sv.HoTen,
                                NgaySinh = sv.NgaySinh,
                                GioiTinh = sv.GioiTinh,
                                MaLop = sv.MaLop,
                                TenLop = lop.TenLop
                            };

                students = query.ToList();
                ApplyFilter(resetPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilter(bool resetPage)
        {
            string timKiem = textBoxTimKiem.Text.Trim().ToLower();
            IEnumerable<Student> query = students;

            if (!string.IsNullOrEmpty(timKiem))
            {
                query = query.Where(s =>
                    ContainsText(s.MaSV, timKiem) ||
                    ContainsText(s.HoTen, timKiem) ||
                    ContainsText(s.MaLop, timKiem) ||
                    ContainsText(s.TenLop, timKiem));
            }

            filteredStudents = query.ToList();

            if (filteredStudents.All(s => s.MaSV != selectedStudentId))
            {
                ClearForm();
            }

            if (resetPage)
            {
                currentPage = 1;
            }

            EnsureCurrentPage();
            BindStudentGrid();
        }

        private static bool ContainsText(string source, string keyword)
        {
            return !string.IsNullOrEmpty(source) && source.ToLower().Contains(keyword);
        }

        private void BindStudentGrid()
        {
            int skip = (currentPage - 1) * pageSize;
            List<Student> pageItems = filteredStudents
                .Skip(skip)
                .Take(pageSize)
                .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = pageItems;

            ConfigureStudentGridColumns();
            RestoreSelectedStudent();
            UpdatePaginationControls();
        }

        private void ConfigureStudentGridColumns()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                return;
            }

            dataGridView1.Columns["MaSV"].HeaderText = "Mã SV";
            dataGridView1.Columns["HoTen"].HeaderText = "Họ tên";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày sinh";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới tính";
            dataGridView1.Columns["MaLop"].HeaderText = "Mã lớp";
            dataGridView1.Columns["TenLop"].HeaderText = "Tên lớp";

            dataGridView1.Columns["MaSV"].FillWeight = 18;
            dataGridView1.Columns["HoTen"].FillWeight = 28;
            dataGridView1.Columns["NgaySinh"].FillWeight = 18;
            dataGridView1.Columns["GioiTinh"].FillWeight = 14;
            dataGridView1.Columns["MaLop"].FillWeight = 12;
            dataGridView1.Columns["TenLop"].FillWeight = 20;

            dataGridView1.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void RestoreSelectedStudent()
        {
            if (string.IsNullOrEmpty(selectedStudentId))
            {
                dataGridView1.ClearSelection();
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Student student = row.DataBoundItem as Student;
                if (student != null && student.MaSV == selectedStudentId)
                {
                    row.Selected = true;
                    dataGridView1.CurrentCell = row.Cells[0];
                    return;
                }
            }

            dataGridView1.ClearSelection();
        }

        private void UpdatePaginationControls()
        {
            int totalRecords = filteredStudents.Count;
            int totalPages = GetTotalPages(totalRecords);
            int fromRecord = totalRecords == 0 ? 0 : ((currentPage - 1) * pageSize) + 1;
            int toRecord = totalRecords == 0 ? 0 : Math.Min(currentPage * pageSize, totalRecords);

            labelPageInfo.Text = totalRecords == 0
                ? "Trang 0/0"
                : string.Format("Trang {0}/{1}", currentPage, totalPages);

            labelPageStatus.Text = string.Format("{0}-{1} / {2} sinh viên", fromRecord, toRecord, totalRecords);

            buttonFirstPage.Enabled = totalRecords > 0 && currentPage > 1;
            buttonPreviousPage.Enabled = totalRecords > 0 && currentPage > 1;
            buttonNextPage.Enabled = totalRecords > 0 && currentPage < totalPages;
            buttonLastPage.Enabled = totalRecords > 0 && currentPage < totalPages;
        }

        private int GetTotalPages(int totalRecords)
        {
            if (totalRecords <= 0)
            {
                return 1;
            }

            return (int)Math.Ceiling(totalRecords / (double)pageSize);
        }

        private void EnsureCurrentPage()
        {
            int totalPages = GetTotalPages(filteredStudents.Count);

            if (currentPage < 1)
            {
                currentPage = 1;
            }
            else if (currentPage > totalPages)
            {
                currentPage = totalPages;
            }
        }

        private void ClearForm()
        {
            textBoxMaSV.Clear();
            textBoxHoTen.Clear();
            dateTimePickerNgaySinh.Value = DateTime.Now;

            if (comboBoxGioiTinh.Items.Count > 0)
            {
                comboBoxGioiTinh.SelectedIndex = 0;
            }

            if (comboBoxLop.Items.Count > 0)
            {
                comboBoxLop.SelectedIndex = 0;
            }

            selectedStudentId = string.Empty;
            textBoxMaSV.ReadOnly = false;

            if (dataGridView1 != null)
            {
                dataGridView1.ClearSelection();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (comboBoxLop.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn lớp", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
            {
                return;
            }

            string maSV = textBoxMaSV.Text.Trim();

            if (students.Any(s => s.MaSV == maSV))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SinhVien sv = new SinhVien
                {
                    MaSV = maSV,
                    HoTen = textBoxHoTen.Text.Trim(),
                    NgaySinh = dateTimePickerNgaySinh.Value.Date,
                    GioiTinh = comboBoxGioiTinh.SelectedItem == null ? string.Empty : comboBoxGioiTinh.SelectedItem.ToString(),
                    MaLop = comboBoxLop.SelectedValue == null ? string.Empty : comboBoxLop.SelectedValue.ToString()
                };

                db.SinhViens.InsertOnSubmit(sv);
                db.SubmitChanges();

                LoadDataFromDatabase(false);
                ClearForm();
                MessageBox.Show("Thêm sinh viên thành công", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedStudentId))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            string maSV = textBoxMaSV.Text.Trim();

            try
            {
                SinhVien sv = db.SinhViens.FirstOrDefault(s => s.MaSV == maSV);
                if (sv == null)
                {
                    MessageBox.Show("Không tìm thấy sinh viên trong database", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                sv.HoTen = textBoxHoTen.Text.Trim();
                sv.NgaySinh = dateTimePickerNgaySinh.Value.Date;
                sv.GioiTinh = comboBoxGioiTinh.SelectedItem == null ? string.Empty : comboBoxGioiTinh.SelectedItem.ToString();
                sv.MaLop = comboBoxLop.SelectedValue == null ? string.Empty : comboBoxLop.SelectedValue.ToString();

                db.SubmitChanges();

                LoadDataFromDatabase(false);
                ClearForm();
                MessageBox.Show("Cập nhật sinh viên thành công", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedStudentId))
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dlg = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg != DialogResult.Yes)
            {
                return;
            }

            try
            {
                SinhVien sv = db.SinhViens.FirstOrDefault(s => s.MaSV == selectedStudentId);
                if (sv != null)
                {
                    db.SinhViens.DeleteOnSubmit(sv);
                    db.SubmitChanges();
                }

                LoadDataFromDatabase(false);
                ClearForm();
                MessageBox.Show("Xóa sinh viên thành công", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            ApplyFilter(true);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridView1.Rows.Count)
            {
                return;
            }

            Student student = dataGridView1.Rows[e.RowIndex].DataBoundItem as Student;
            if (student == null)
            {
                return;
            }

            selectedStudentId = student.MaSV;
            textBoxMaSV.Text = student.MaSV;
            textBoxHoTen.Text = student.HoTen;
            dateTimePickerNgaySinh.Value = student.NgaySinh;

            if (comboBoxGioiTinh.Items.Contains(student.GioiTinh))
            {
                comboBoxGioiTinh.SelectedItem = student.GioiTinh;
            }

            comboBoxLop.SelectedValue = student.MaLop;
            textBoxMaSV.ReadOnly = true;
        }

        private void buttonChonAnh_Click(object sender, EventArgs e)
        {
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            textBoxTimKiem.Clear();
            currentPage = 1;
            ClearForm();
            LoadDataFromDatabase(true);
        }

        private void buttonQuanLyLop_Click(object sender, EventArgs e)
        {
            ClassManagement ownerClassForm = this.Owner as ClassManagement;
            if (ownerClassForm != null && !ownerClassForm.IsDisposed)
            {
                ownerClassForm.RefreshManagementData();
                ownerClassForm.Show();
                this.Close();
                return;
            }

            ClassManagement classForm = new ClassManagement();
            classForm.Owner = this;
            classForm.FormClosed += classForm_FormClosed;
            classForm.Show();
            this.Hide();
        }

        private void classForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.IsDisposed)
            {
                return;
            }

            RefreshManagementData();
            this.Show();
        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            BindStudentGrid();
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                BindStudentGrid();
            }
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            int totalPages = GetTotalPages(filteredStudents.Count);
            if (currentPage < totalPages)
            {
                currentPage++;
                BindStudentGrid();
            }
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            currentPage = GetTotalPages(filteredStudents.Count);
            BindStudentGrid();
        }

        private void comboBoxPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newPageSize;
            if (int.TryParse(comboBoxPageSize.Text, out newPageSize) && newPageSize > 0)
            {
                pageSize = newPageSize;
                currentPage = 1;
                BindStudentGrid();
            }
        }

        private void StudentManagement_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
