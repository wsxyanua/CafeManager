CREATE DATABASE CafeManager2
USE CafeManager2
GO

CREATE TABLE Menu
(
	MenuID int Primary key Identity(1,1),
	TENMON Nvarchar(200) NOT NULL,
	GIA DECIMAL(18,2) NOT NULL,
	LOAIMON NVARCHAR(50),
	HINHANH NVARCHAR(MAX),
	HIENTHI BIT,
)

CREATE TABLE Ban
(
	BanID int Primary key Identity(1,1),
	SOBAN INT NOT NULL,
	TINHTRANG NVARCHAR(50) NOT NULL,
)

CREATE TABLE NhanVien (
    MaNV CHAR(10) PRIMARY KEY NOT NULL, 
    TENNV NVARCHAR(100) NOT NULL,       
    GIOITINH BIT NOT NULL,   
    SDT VARCHAR(15)            
);
ALTER TABLE NhanVien
ADD HIENTHI BIT

CREATE TABLE HoaDon (
    SOHOADON INT PRIMARY KEY,
    NGAYDAT DATETIME DEFAULT GETDATE(),
	MaNV CHAR(10) NOT NULL, 
	CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) 
);
ALTER TABLE HoaDon -- chua load
ADD TONGTIEN DECIMAL(18,2) 

CREATE TABLE ChiTietHoaDon
(  
    SOHOADON INT NOT NULL,  
    MenuID INT,  
    SOLUONG INT NOT NULL, 
	CONSTRAINT PK_ChiTietHoaDon PRIMARY KEY (SOHOADON, MenuID),
    CONSTRAINT FK_ChiTietHoaDon_HoaDon FOREIGN KEY (SOHOADON) REFERENCES HoaDon(SOHOADON), 
    CONSTRAINT FK_ChiTietHoaDon_Menu FOREIGN KEY (MenuID) REFERENCES Menu(MenuID)
);

CREATE TABLE DangKy (
    MaDK INT PRIMARY KEY IDENTITY(1,1),
    TenDK NVARCHAR(50) NOT NULL,
    MatKhau NVARCHAR(50) NOT NULL,
    ChucVu BIT NOT NULL,
    MaNV CHAR(10) NOT NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

/*CREATE TABLE ThongKe (
    ThongKeID INT PRIMARY KEY IDENTITY(1,1), 
    NGAY DATETIME DEFAULT GETDATE() NOT NULL,                      
    DOANHTHU DECIMAL(18,2) NOT NULL,         
    SOHOADON INT NOT NULL,                   
    FOREIGN KEY (SOHOADON) REFERENCES HoaDon(SOHOADON)
);*/

SELECT * FROM NhanVien
SELECT * FROM Menu
SELECT * FROM Ban
SELECT * FROM DangKy
SELECT * FROM HoaDon
SELECT * FROM ChiTietHoaDon

-- xóa data cũ
DELETE FROM ChiTietHoaDon;
DELETE FROM HoaDon;
DELETE FROM DangKy;
DELETE FROM Ban;
DELETE FROM Menu;
DELETE FROM NhanVien;

--fix tk admin 
UPDATE DangKy SET ChucVu = 0 WHERE TenDK = 'admin';
UPDATE DangKy SET ChucVu = 1 WHERE TenDK <> 'admin';

--insert into nhanvien
INSERT INTO NhanVien (MaNV, TENNV, GIOITINH, SDT, HIENTHI)
VALUES 
('NV001', N'Nguyễn Văn A', 1, '0123456789', 1),
('NV002', N'Trần Thị B', 0, '0987654321', 1),
('NV003', N'Lê Văn C', 1, '0123456780', 1),
('NV004', N'Phạm Thị D', 0, '0987654320', 1),
('NV005', N'Hoàng Văn E', 1, '0123456781', 1);

--insert into menu
INSERT INTO Menu (TENMON, GIA, LOAIMON, HINHANH, HIENTHI)
VALUES 
(N'Cà phê đen', 25000, N'Cà phê', '', 1),
(N'Cà phê sữa', 30000, N'Cà phê', '', 1),
(N'Trà sữa trân châu', 45000, N'Trà sữa', '', 1),
(N'Bánh tiramisu', 35000, N'Bánh ngọt', '', 1),
(N'Bánh mì sandwich', 25000, N'Bánh mặn', '', 1);

--insert into ban
INSERT INTO Ban (SOBAN, TINHTRANG)
VALUES 
(1, N'Trống'),
(2, N'Đang sử dụng'),
(3, N'Trống'),
(4, N'Đang sử dụng'),
(5, N'Trống');

--insert into dangky
INSERT INTO DangKy (TenDK, MatKhau, ChucVu, MaNV)
VALUES 
('admin', 'admin123', 1, 'NV001'),
('nhanvien1', 'nv123', 0, 'NV002'),
('nhanvien2', 'nv123', 0, 'NV003'),
('nhanvien3', 'nv123', 0, 'NV004'),
('nhanvien4', 'nv123', 0, 'NV005');

--insert into hoadon
INSERT INTO HoaDon (SOHOADON, NGAYDAT, MaNV, TONGTIEN)
VALUES 
(1, GETDATE(), 'NV001', 75000),
(2, GETDATE(), 'NV002', 45000),
(3, GETDATE(), 'NV003', 100000),
(4, GETDATE(), 'NV004', 55000),
(5, GETDATE(), 'NV005', 80000);

--insert into chitiethoadonchitiethoadon
INSERT INTO ChiTietHoaDon (SOHOADON, MenuID, SOLUONG)
VALUES 
(1, 1, 2),  -- 2 cà phê đen
(1, 2, 1),  -- 1 cà phê sữa
(2, 3, 1),  -- 1 trà sữa trân châu
(3, 4, 2),  -- 2 bánh tiramisu
(3, 5, 1),  -- 1 bánh mì sandwich
(4, 1, 1),  -- 1 cà phê đen
(4, 2, 1),  -- 1 cà phê sữa
(5, 3, 1),  -- 1 trà sữa trân châu
(5, 4, 1);  -- 1 bánh tiramisu
