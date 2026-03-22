using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class ClassManagement : Form
    {
        private readonly QLSVDBDataContext db = new QLSVDBDataContext();

        private List<LopGridItem> lops = new List<LopGridItem>();
        private List<LopGridItem> filteredLops = new List<LopGridItem>();
        private List<StudentInClassGridItem> studentsInSelectedClass = new List<StudentInClassGridItem>();
        private string selectedClassId = string.Empty;
        private int currentClassPage = 1;
        private int classPageSize = 8;
        private int currentStudentPage = 1;
        private int studentPageSize = 8;

        public ClassManagement()
        {
            InitializeComponent();
            ApplyVisualStyles();
            InitializePagination();
            LoadDataFromDatabase(true);
        }

        public void RefreshManagementData()
        {
            LoadDataFromDatabase(true);
        }

        private void ApplyVisualStyles()
        {
            GridStyleHelper.ApplyPrimary(dataGridViewLop);
        }

        private void InitializePagination()
        {
            if (comboBoxClassPageSize.Items.Count == 0)
            {
                comboBoxClassPageSize.Items.AddRange(new object[] { "5", "8", "10", "20" });
            }

            comboBoxClassPageSize.SelectedItem = classPageSize.ToString();
        }

        private void LoadDataFromDatabase(bool resetPage)
        {
            try
            {
                lops = db.Lops
                    .OrderBy(l => l.MaLop)
                    .ToList()
                    .Select(l => new LopGridItem
                    {
                        MaLop = l.MaLop,
                        TenLop = l.TenLop,
                        GhiChu = l.GhiChu,
                        SoSinhVien = l.SinhViens.Count()
                    })
                    .ToList();

                ApplyClassFilter(resetPage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyClassFilter(bool resetPage)
        {
            string timKiem = textBoxTimKiem.Text.Trim().ToLower();
            IEnumerable<LopGridItem> query = lops;

            if (!string.IsNullOrEmpty(timKiem))
            {
                query = query.Where(l =>
                    ContainsText(l.MaLop, timKiem) ||
                    ContainsText(l.TenLop, timKiem) ||
                    ContainsText(l.GhiChu, timKiem));
            }

            filteredLops = query.ToList();

            if (filteredLops.All(l => l.MaLop != selectedClassId))
            {
                ClearForm();
            }

            if (resetPage)
            {
                currentClassPage = 1;
            }

            EnsureCurrentClassPage();
            BindClassGrid();
        }

        private static bool ContainsText(string source, string keyword)
        {
            return !string.IsNullOrEmpty(source) && source.ToLower().Contains(keyword);
        }

        private void BindClassGrid()
        {
            int skip = (currentClassPage - 1) * classPageSize;
            List<LopGridItem> pageItems = filteredLops
                .Skip(skip)
                .Take(classPageSize)
                .ToList();

            dataGridViewLop.DataSource = null;
            dataGridViewLop.DataSource = pageItems;

            ConfigureClassGridColumns();
            RestoreSelectedClass();
            UpdateClassPaginationControls();
        }

        private void ConfigureClassGridColumns()
        {
            if (dataGridViewLop.Columns.Count == 0)
            {
                return;
            }

            dataGridViewLop.Columns["MaLop"].HeaderText = "Mã lớp";
            dataGridViewLop.Columns["TenLop"].HeaderText = "Tên lớp";
            dataGridViewLop.Columns["GhiChu"].HeaderText = "Ghi chú";
            dataGridViewLop.Columns["SoSinhVien"].HeaderText = "Số SV";

            dataGridViewLop.Columns["MaLop"].FillWeight = 20;
            dataGridViewLop.Columns["TenLop"].FillWeight = 28;
            dataGridViewLop.Columns["GhiChu"].FillWeight = 36;
            dataGridViewLop.Columns["SoSinhVien"].FillWeight = 16;
        }

        private void RestoreSelectedClass()
        {
            if (string.IsNullOrEmpty(selectedClassId))
            {
                dataGridViewLop.ClearSelection();
                return;
            }

            foreach (DataGridViewRow row in dataGridViewLop.Rows)
            {
                LopGridItem lop = row.DataBoundItem as LopGridItem;
                if (lop != null && lop.MaLop == selectedClassId)
                {
                    row.Selected = true;
                    dataGridViewLop.CurrentCell = row.Cells[0];
                    return;
                }
            }

            dataGridViewLop.ClearSelection();
        }

        private void UpdateClassPaginationControls()
        {
            int totalRecords = filteredLops.Count;
            int totalPages = GetTotalPages(totalRecords, classPageSize);
            int fromRecord = totalRecords == 0 ? 0 : ((currentClassPage - 1) * classPageSize) + 1;
            int toRecord = totalRecords == 0 ? 0 : Math.Min(currentClassPage * classPageSize, totalRecords);

            labelClassPageInfo.Text = totalRecords == 0
                ? "Trang 0/0"
                : string.Format("Trang {0}/{1}", currentClassPage, totalPages);

            labelClassPageStatus.Text = string.Format("{0}-{1} / {2} lớp", fromRecord, toRecord, totalRecords);

            buttonClassFirst.Enabled = totalRecords > 0 && currentClassPage > 1;
            buttonClassPrevious.Enabled = totalRecords > 0 && currentClassPage > 1;
            buttonClassNext.Enabled = totalRecords > 0 && currentClassPage < totalPages;
            buttonClassLast.Enabled = totalRecords > 0 && currentClassPage < totalPages;
        }

        private int GetTotalPages(int totalRecords, int itemsPerPage)
        {
            if (totalRecords <= 0)
            {
                return 1;
            }

            return (int)Math.Ceiling(totalRecords / (double)itemsPerPage);
        }

        private void EnsureCurrentClassPage()
        {
            int totalPages = GetTotalPages(filteredLops.Count, classPageSize);

            if (currentClassPage < 1)
            {
                currentClassPage = 1;
            }
            else if (currentClassPage > totalPages)
            {
                currentClassPage = totalPages;
            }
        }

        private void ClearForm()
        {
            textBoxMaLop.Clear();
            textBoxTenLop.Clear();
            textBoxGhiChu.Clear();
            selectedClassId = string.Empty;
            textBoxMaLop.ReadOnly = false;

            if (dataGridViewLop != null)
            {
                dataGridViewLop.ClearSelection();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxMaLop.Text))
            {
                MessageBox.Show("Vui lòng nhập mã lớp", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBoxTenLop.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp", "Thông báo",
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

            string maLop = textBoxMaLop.Text.Trim();
            if (lops.Any(l => l.MaLop == maLop))
            {
                MessageBox.Show("Mã lớp đã tồn tại", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Lop lop = new Lop
                {
                    MaLop = maLop,
                    TenLop = textBoxTenLop.Text.Trim(),
                    GhiChu = textBoxGhiChu.Text.Trim()
                };

                db.Lops.InsertOnSubmit(lop);
                db.SubmitChanges();

                LoadDataFromDatabase(false);
                ClearForm();
                MessageBox.Show("Thêm lớp thành công", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm lớp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedClassId))
            {
                MessageBox.Show("Vui lòng chọn lớp để sửa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput())
            {
                return;
            }

            string maLop = textBoxMaLop.Text.Trim();

            try
            {
                Lop lop = db.Lops.FirstOrDefault(l => l.MaLop == maLop);
                if (lop == null)
                {
                    MessageBox.Show("Không tìm thấy lớp trong database", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lop.TenLop = textBoxTenLop.Text.Trim();
                lop.GhiChu = textBoxGhiChu.Text.Trim();

                db.SubmitChanges();

                LoadDataFromDatabase(false);
                ClearForm();
                MessageBox.Show("Cập nhật lớp thành công", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật lớp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedClassId))
            {
                MessageBox.Show("Vui lòng chọn lớp để xóa", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LopGridItem lopItem = lops.FirstOrDefault(l => l.MaLop == selectedClassId);
            string tenLop = lopItem == null ? selectedClassId : lopItem.TenLop;
            int soSV = lopItem == null ? 0 : lopItem.SoSinhVien;

            string msg = soSV > 0
                ? string.Format("Lớp \"{0}\" còn {1} sinh viên.\nXóa lớp sẽ xóa toàn bộ sinh viên đó (CASCADE).\nBạn có chắc chắn?", tenLop, soSV)
                : string.Format("Bạn có chắc chắn muốn xóa lớp \"{0}\"?", tenLop);

            DialogResult dlg = MessageBox.Show(msg, "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dlg != DialogResult.Yes)
            {
                return;
            }

            try
            {
                Lop lop = db.Lops.FirstOrDefault(l => l.MaLop == selectedClassId);
                if (lop != null)
                {
                    db.Lops.DeleteOnSubmit(lop);
                    db.SubmitChanges();
                }

                LoadDataFromDatabase(false);
                ClearForm();
                MessageBox.Show("Xóa lớp thành công", "Thành công",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lớp: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            ApplyClassFilter(true);
        }

        private void buttonXemSV_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedClassId))
            {
                MessageBox.Show("Vui lòng chọn một lớp để xem sinh viên", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mở form riêng để xem sinh viên của lớp
            StudentInClassForm studentForm = new StudentInClassForm(selectedClassId, textBoxTenLop.Text);
            studentForm.Show();
        }

        private void buttonQuanLySinhVien_Click(object sender, EventArgs e)
        {
            StudentManagement ownerStudentForm = this.Owner as StudentManagement;
            if (ownerStudentForm != null && !ownerStudentForm.IsDisposed)
            {
                ownerStudentForm.RefreshManagementData();
                ownerStudentForm.Show();
                this.Close();
                return;
            }

            StudentManagement studentForm = new StudentManagement();
            studentForm.Owner = this;
            studentForm.FormClosed += studentForm_FormClosed;
            studentForm.Show();
            this.Hide();
        }

        private void dataGridViewLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dataGridViewLop.Rows.Count)
            {
                return;
            }

            LopGridItem lop = dataGridViewLop.Rows[e.RowIndex].DataBoundItem as LopGridItem;
            if (lop == null)
            {
                return;
            }

            selectedClassId = lop.MaLop;
            textBoxMaLop.Text = lop.MaLop;
            textBoxTenLop.Text = lop.TenLop;
            textBoxGhiChu.Text = lop.GhiChu ?? string.Empty;
            textBoxMaLop.ReadOnly = true;
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            textBoxTimKiem.Clear();
            currentClassPage = 1;
            currentStudentPage = 1;
            ClearForm();
            LoadDataFromDatabase(true);
        }

        private void buttonClassFirst_Click(object sender, EventArgs e)
        {
            currentClassPage = 1;
            BindClassGrid();
        }

        private void buttonClassPrevious_Click(object sender, EventArgs e)
        {
            if (currentClassPage > 1)
            {
                currentClassPage--;
                BindClassGrid();
            }
        }

        private void buttonClassNext_Click(object sender, EventArgs e)
        {
            int totalPages = GetTotalPages(filteredLops.Count, classPageSize);
            if (currentClassPage < totalPages)
            {
                currentClassPage++;
                BindClassGrid();
            }
        }

        private void buttonClassLast_Click(object sender, EventArgs e)
        {
            currentClassPage = GetTotalPages(filteredLops.Count, classPageSize);
            BindClassGrid();
        }

        private void comboBoxClassPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            int newPageSize;
            if (int.TryParse(comboBoxClassPageSize.Text, out newPageSize) && newPageSize > 0)
            {
                classPageSize = newPageSize;
                currentClassPage = 1;
                BindClassGrid();
            }
        }

        private void studentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.IsDisposed)
            {
                return;
            }

            RefreshManagementData();
            this.Show();
        }

        private void ClassManagement_Load(object sender, EventArgs e)
        {
        }

        private sealed class LopGridItem
        {
            public string MaLop { get; set; }
            public string TenLop { get; set; }
            public string GhiChu { get; set; }
            public int SoSinhVien { get; set; }
        }

        private sealed class StudentInClassGridItem
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public string NgaySinh { get; set; }
            public string GioiTinh { get; set; }
        }

        private void dataGridViewSinhVienLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelSinhVienLop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
