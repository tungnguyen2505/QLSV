using System;

namespace QLSV
{
    public class Student
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string Lop { get; set; }

        public Student() { }

        public Student(string maSV, string hoTen, DateTime ngaySinh, string gioiTinh, string lop)
        {
            MaSV = maSV;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            Lop = lop;
         
        }
    }
}
