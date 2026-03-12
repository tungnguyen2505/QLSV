using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLSV
{
    public partial class StudentManagement : Form
    {
        private List<Student> students = new List<Student>();
        private int selectedIndex = -1;
        private string connectionString = ConfigurationManager.ConnectionStrings["QLSV.Properties.Settings.QLSVConnectionString"].ConnectionString;

        public StudentManagement()
        {
            InitializeComponent();
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            students.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "SELECT MaSV, HoTen, NgaySinh, GioiTinh, Lop FROM SinhVien";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        con.Open();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                students.Add(new Student(
                                    reader["MaSV"].ToString(),
                                    reader["HoTen"].ToString(),
                                    Convert.ToDateTime(reader["NgaySinh"]),
                                    reader["GioiTinh"].ToString(),
                                    reader["Lop"].ToString()
                                ));
                            }
                        }
                    }
                }
                LoadDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students.ToList();
        }

        private void ClearForm()
        {
            textBoxMaSV.Clear();
            textBoxHoTen.Clear();
            dateTimePickerNgaySinh.Value = DateTime.Now;
            if (comboBoxGioiTinh.Items.Count > 0) comboBoxGioiTinh.SelectedIndex = 0;
            if (comboBoxLop.Items.Count > 0) comboBoxLop.SelectedIndex = 0;
            selectedIndex = -1;
            textBoxMaSV.ReadOnly = false;
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(textBoxMaSV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sinh viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string maSV = textBoxMaSV.Text.Trim();
            if (students.Any(s => s.MaSV == maSV))
            {
                MessageBox.Show("Mã sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Lop) VALUES (@MaSV, @HoTen, @NgaySinh, @GioiTinh, @Lop)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@HoTen", textBoxHoTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", dateTimePickerNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Lop", comboBoxLop.SelectedItem?.ToString() ?? "");

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadDataFromDatabase();
                ClearForm();
                MessageBox.Show("Thêm sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            string maSV = textBoxMaSV.Text.Trim();

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    string query = "UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, Lop = @Lop WHERE MaSV = @MaSV";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@MaSV", maSV);
                        cmd.Parameters.AddWithValue("@HoTen", textBoxHoTen.Text.Trim());
                        cmd.Parameters.AddWithValue("@NgaySinh", dateTimePickerNgaySinh.Value.Date);
                        cmd.Parameters.AddWithValue("@GioiTinh", comboBoxGioiTinh.SelectedItem?.ToString() ?? "");
                        cmd.Parameters.AddWithValue("@Lop", comboBoxLop.SelectedItem?.ToString() ?? "");

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                LoadDataFromDatabase();
                ClearForm();
                MessageBox.Show("Cập nhật sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            if (selectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn sinh viên để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string maSV = students[selectedIndex].MaSV;
                try
                {
                    using (SqlConnection con = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM SinhVien WHERE MaSV = @MaSV";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@MaSV", maSV);
                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                    LoadDataFromDatabase();
                    ClearForm();
                    MessageBox.Show("Xóa sinh viên thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                     MessageBox.Show("Lỗi khi xóa sinh viên: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonTim_Click(object sender, EventArgs e)
        {
            string timKiem = textBoxTimKiem.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(timKiem))
            {
                LoadDataFromDatabase();
                return;
            }

            var result = students.Where(s => 
                s.MaSV.ToLower().Contains(timKiem) || 
                s.HoTen.ToLower().Contains(timKiem)
            ).ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = result;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra bounds kỹ hơn để tránh lỗi khi người dùng click vào header (RowIndex = -1) hoặc vùng trống
            if (e.RowIndex >= 0 && e.RowIndex < students.Count)
            {
                selectedIndex = e.RowIndex;
                Student s = students[selectedIndex];
                textBoxMaSV.Text = s.MaSV;
                textBoxHoTen.Text = s.HoTen;
                dateTimePickerNgaySinh.Value = s.NgaySinh;
                if (comboBoxGioiTinh.Items.Contains(s.GioiTinh)) comboBoxGioiTinh.SelectedItem = s.GioiTinh;
                if (comboBoxLop.Items.Contains(s.Lop)) comboBoxLop.SelectedItem = s.Lop;
                
                textBoxMaSV.ReadOnly = true;
            }
        }

        private void buttonChonAnh_Click(object sender, EventArgs e)
        {
        }

        private void buttonLamMoi_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadDataFromDatabase();
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
