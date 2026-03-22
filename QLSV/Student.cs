using System;

namespace QLSV
{
    /// <summary>
    /// ViewModel hiển thị thông tin sinh viên trên DataGridView.
    /// Kết hợp dữ liệu từ bảng SinhVien JOIN bảng Lop.
    /// </summary>
    public class Student
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string MaLop { get; set; }
        public string TenLop { get; set; }

        public Student() { }

        public Student(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string maLop, string tenLop)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            MaLop = maLop;
            TenLop = tenLop;
        }
    }
}
