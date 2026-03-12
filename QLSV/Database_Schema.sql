-- Script khởi tạo cơ sở dữ liệu cho phần mềm Quản Lý Sinh Viên (QLSV)
CREATE DATABASE QLSVDB;
GO

USE QLSVDB;
GO

-- 1. Bảng lưu trữ thông tin Sinh Viên (dựa trên Student.cs và StudentManagement.cs)
CREATE TABLE SinhVien (
    MaSV VARCHAR(20) PRIMARY KEY,       -- VD: SV001
    HoTen NVARCHAR(100) NOT NULL,       -- VD: Nguyễn Văn A
    NgaySinh DATE NOT NULL,             -- VD: 2002-03-15
    GioiTinh NVARCHAR(10) NOT NULL,     -- VD: Nam / Nữ
    Lop NVARCHAR(50) NOT NULL           -- VD: CNTT1
);
GO

-- Thêm dữ liệu mẫu (dựa trên phương thức LoadSampleData)
INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, Lop)
VALUES 
    ('SV001', N'Nguyễn Văn A', '2002-03-15', N'Nam', 'CNTT1'),
    ('SV002', N'Trần Thị B', '2003-07-20', N'Nữ', 'CNTT2'),
    ('SV003', N'Phạm Minh C', '2002-11-10', N'Nam', 'CNTT1');
GO
