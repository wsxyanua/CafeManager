CREATE DATABASE CafeManager
USE CafeManager
GO

CREATE TABLE Menu
(
	MenuID int Primary key Identity(1,1),
	TENMON Nvarchar(200) NOT NULL,
	GIA DECIMAL(18,2) NOT NULL,
	LOAIMON NVARCHAR(50),
	HINHANH NVARCHAR(MAX),
)

DELETE from Menu WHERE MenuID = '6';

CREATE TABLE NhanVien (
    MaNV CHAR(10) PRIMARY KEY NOT NULL, 
    TenNV NVARCHAR(100) NOT NULL,       
    GioiTinh BIT NOT NULL,   
    SDT VARCHAR(15)            
);
select *
from Menu

CREATE TABLE Orders (
    OrderNumber INT PRIMARY KEY,
    OrderDate DATETIME DEFAULT GETDATE()
);

CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY IDENTITY(1,1),  
    OrderNumber INT,  
    MenuID int ,  
    Quantity INT NOT NULL,  
    CONSTRAINT FK_OrderDetails_Order FOREIGN KEY (OrderNumber) REFERENCES Orders(OrderNumber), 
    CONSTRAINT FK_OrderDetails_Menu FOREIGN KEY (MenuID) REFERENCES Menu(MenuID)  
);

CREATE TABLE DangKy (
    MaDK INT PRIMARY KEY IDENTITY(1,1),
    TenDK NVARCHAR(50) NOT NULL,
    MatKhau NVARCHAR(50) NOT NULL,
    ChucVu BIT NOT NULL,
    MaNV CHAR(10) NOT NULL,
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

select *
from DangKy