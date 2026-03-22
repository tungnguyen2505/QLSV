using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLSV
{
    public partial class StudentInClassForm : Form
    {
        private readonly QLSVDBDataContext db = new QLSVDBDataContext();
        private List<StudentInClassGridItem> studentsInClass = new List<StudentInClassGridItem>();
        private string classId = string.Empty;
        private string className = string.Empty;
        private int currentPage = 1;
        private int pageSize = 10;

        public StudentInClassForm(string maLop, string tenLop)
        {
            InitializeComponent();
            classId = maLop;
            className = tenLop;
            ApplyVisualStyles();
            InitializePagination();
            LoadStudents();
        }

        private void ApplyVisualStyles()
        {
            GridStyleHelper.ApplyAccent(dataGridViewStudents);
        }

        private void InitializePagination()
        {
            if (comboBoxPageSize.Items.Count == 0)
            {
                comboBoxPageSize.Items.AddRange(new object[] { "5", "10", "20", "50" });
            }

            comboBoxPageSize.SelectedItem = pageSize.ToString();
        }

        private void LoadStudents()
        {
            try
            {
                studentsInClass = db.SinhViens
                    .Where(sv => sv.MaLop == classId)
                    .OrderBy(sv => sv.MaSV)
                    .ToList()
                    .Select(sv => new StudentInClassGridItem
                    {
                        MaSV = sv.MaSV,
                        HoTen = sv.HoTen,
                        NgaySinh = sv.NgaySinh.ToString("dd/MM/yyyy"),
                        GioiTinh = sv.GioiTinh
                    })
                    .ToList();

                currentPage = 1;
                BindGrid();
                UpdateTitle();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu sinh viên: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTitle()
        {
            this.Text = $"Danh sách sinh viên - Lớp {className} ({classId})";
            labelClassInfo.Text = $"Lớp: {className} ({classId}) - Tổng: {studentsInClass.Count} sinh viên";
        }

        private void BindGrid()
        {
            int skip = (currentPage - 1) * pageSize;
            List<StudentInClassGridItem> pageItems = studentsInClass
                .Skip(skip)
                .Take(pageSize)
                .ToList();

            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = pageItems;

            ConfigureGridColumns();
            UpdatePaginationControls();
        }

        private void ConfigureGridColumns()
        {
            if (dataGridViewStudents.Columns.Count == 0)
            {
                return;
            }

            dataGridViewStudents.Columns["MaSV"].HeaderText = "Mã SV";
            dataGridViewStudents.Columns["HoTen"].HeaderText = "Họ Tên";
            dataGridViewStudents.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridViewStudents.Columns["GioiTinh"].HeaderText = "Giới Tính";

            dataGridViewStudents.Columns["MaSV"].Width = 80;
            dataGridViewStudents.Columns["HoTen"].Width = 150;
            dataGridViewStudents.Columns["NgaySinh"].Width = 100;
            dataGridViewStudents.Columns["GioiTinh"].Width = 80;
        }

        private void UpdatePaginationControls()
        {
            int totalPages = GetTotalPages(studentsInClass.Count, pageSize);

            labelPageInfo.Text = $"Trang {currentPage}/{totalPages}";
            labelPageStatus.Text = $"{((currentPage - 1) * pageSize + 1)}-{Math.Min(currentPage * pageSize, studentsInClass.Count)} / {studentsInClass.Count} sinh viên";

            buttonFirstPage.Enabled = currentPage > 1;
            buttonPreviousPage.Enabled = currentPage > 1;
            buttonNextPage.Enabled = currentPage < totalPages;
            buttonLastPage.Enabled = currentPage < totalPages;
        }

        private int GetTotalPages(int totalRecords, int itemsPerPage)
        {
            if (totalRecords <= 0)
            {
                return 1;
            }

            return (int)Math.Ceiling(totalRecords / (double)itemsPerPage);
        }

        private void buttonFirstPage_Click(object sender, EventArgs e)
        {
            currentPage = 1;
            BindGrid();
        }

        private void buttonPreviousPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                BindGrid();
            }
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            int totalPages = GetTotalPages(studentsInClass.Count, pageSize);
            if (currentPage < totalPages)
            {
                currentPage++;
                BindGrid();
            }
        }

        private void buttonLastPage_Click(object sender, EventArgs e)
        {
            int totalPages = GetTotalPages(studentsInClass.Count, pageSize);
            currentPage = totalPages;
            BindGrid();
        }

        private void comboBoxPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (int.TryParse(comboBoxPageSize.SelectedItem?.ToString(), out int newPageSize))
            {
                pageSize = newPageSize;
                currentPage = 1;
                BindGrid();
            }
        }

        private sealed class StudentInClassGridItem
        {
            public string MaSV { get; set; }
            public string HoTen { get; set; }
            public string NgaySinh { get; set; }
            public string GioiTinh { get; set; }
        }
    }
}
