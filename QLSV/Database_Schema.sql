-- Script khởi tạo cơ sở dữ liệu cho phần mềm Quản Lý Sinh Viên (QLSV)
CREATE DATABASE QLSVDB;
GO

USE QLSVDB;
GO

-- 1. Bảng lưu trữ thông tin Lớp học (Class)
CREATE TABLE Lop (
    Id INT IDENTITY(1,1) PRIMARY KEY,   -- Mã ID tự tăng
    MaLop VARCHAR(20) NOT NULL UNIQUE,  -- Mã lớp, VD: CNTT1
    TenLop NVARCHAR(100) NOT NULL,      -- Tên lớp, VD: Công nghệ thông tin 1
    GhiChu NVARCHAR(255)                -- Ghi chú thêm
);
GO

-- 2. Bảng lưu trữ thông tin Sinh Viên (Student)
CREATE TABLE SinhVien (
    MaSV VARCHAR(20) PRIMARY KEY,       -- VD: SV001
    HoTen NVARCHAR(100) NOT NULL,       -- VD: Nguyễn Văn A
    NgaySinh DATE NOT NULL,             -- VD: 2002-03-15
    GioiTinh NVARCHAR(10) NOT NULL,     -- VD: Nam / Nữ
    MaLop VARCHAR(20) NOT NULL,         -- Khóa ngoại liên kết tới bảng Lop
    CONSTRAINT FK_SinhVien_Lop FOREIGN KEY (MaLop) REFERENCES Lop(MaLop)
        ON UPDATE CASCADE 
        ON DELETE CASCADE
);
GO

-- Thêm dữ liệu mẫu cho Lớp
INSERT INTO Lop (MaLop, TenLop, GhiChu)
VALUES 
    ('CNTT1', N'Công nghệ thông tin 1', N'Khóa 2020'),
    ('CNTT2', N'Công nghệ thông tin 2', N'Khóa 2020');
GO

-- Thêm dữ liệu mẫu cho Sinh Viên
INSERT INTO SinhVien (MaSV, HoTen, NgaySinh, GioiTinh, MaLop)
VALUES 
    ('SV001', N'Nguyễn Văn A', '2002-03-15', N'Nam', 'CNTT1'),
    ('SV002', N'Trần Thị B', '2003-07-20', N'Nữ', 'CNTT2'),
    ('SV003', N'Phạm Minh C', '2002-11-10', N'Nam', 'CNTT1');
GO
