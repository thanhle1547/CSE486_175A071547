﻿CREATE DATABASE QLRapChieuPhim
On Primary
(
	Name = QLRapChieuPhim_Data,
	Filename = 'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Data\QLRapChieuPhim_data.mdf',	
	Size = 10 MB,
	MaxSize = 20 MB,
	FileGrowth = 1 MB
)
Log On
(
	Name = QLRapChieuPhim_Log,
	Filename = 'D:\Program Files\Microsoft SQL Server\MSSQL14.MSSQLSERVER\MSSQL\Data\QLRapChieuPhim_log.ldf',	
	Size = 10 MB,
	MaxSize = 20 MB,
	FileGrowth = 1 MB
)

Use QLRapChieuPhim

-- #########################
CREATE TABLE PhongChieuPhim
(
   IDPhongChieuPhim tinyint NOT NULL PRIMARY KEY,
   TenPhong varchar(5),
   SoGheThuong tinyint,
   SoGheVIP tinyint,
)
--Exec sp_rename 'PhongChieuPhim.IDPhongChieuphim', 'IDPhong', 'COLUMN'

-- #########################
CREATE TABLE NhaSanXuat
(
	ID_NSX int NOT NULL PRIMARY KEY Identity(1,1),
	TenNSX nvarchar(20)
)

--ALter Table NhaSanXuat
--	Alter Column TenNSX nvarchar(50)

CREATE TABLE TheLoai
(
	IDTheLoai tinyint NOT NULL PRIMARY KEY Identity(1,1),
	TenTheLoai nvarchar(15)
)

CREATE TABLE DinhDang -- Định dạng phim: 2D, 3D...
(
	ID_DinhDang tinyint NOT NULL PRIMARY KEY Identity(1,1),
	TenDinhDang varchar(5)
)

--ALter Table DinhDang
--	Alter Column TenDinhDang varchar(5)

CREATE TABLE NgonNgu -- Ngôn ngữ phim: phụ đề việt, lồng Tiếng Việt...
(
	ID_NgonNgu tinyint NOT NULL PRIMARY KEY Identity(1,1),
	NgonNgu nvarchar(30)
)

--ALter Table NgonNgu
--	Alter Column NgonNgu nvarchar(30)

CREATE TABLE DaoDien
(
	IDDaoDien int NOT NULL PRIMARY KEY Identity(1,1),
	TenDaoien nvarchar(20)
)

--Exec sp_rename 'DaoDien.TenDaoien', 'TenDaoDien', 'COLUMN'

CREATE TABLE DienVien
(
	IDDienVien int NOT NULL PRIMARY KEY Identity(1,1),
	TenDienVien nvarchar(20)
)

----------------------
 CREATE TABLE Phim
(  
   IDPhim int NOT NULL PRIMARY KEY,
   ID_NSX int,
   TenPhim nvarchar(max),
   Poster image,
   ThoiLuong tinyint,
   KhoiChieu date,
   Rated char(3),
   MoTa nvarchar(max),
   FOREIGN KEY (ID_NSX) REFERENCES NhaSanXuat(ID_NSX),
)
--ALter Table Phim
--	Alter Column TenPhim nvarchar(max)
--ALter Table Phim
--	Alter Column MoTa nvarchar(max)
----------------------

Create Table P_DaoDien
(
	IDPhim int NOT NULL,
	IDDaoDien int NOT NULL,
	Primary key (IDPhim, IDDaoDien),

	FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim),
	FOREIGN KEY (IDDaoDien) REFERENCES DaoDien(IDDaoDien)
)

Create Table P_DienVien
(
	IDPhim int NOT NULL,
	IDDienVien int NOT NULL,
	Primary key (IDPhim, IDDienVien),

	FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim),
	FOREIGN KEY (IDDienVien) REFERENCES DienVien(IDDienVien)
)

Create Table P_TheLoai
(
	IDPhim int NOT NULL,
	IDTheLoai tinyint NOT NULL,
	Primary key (IDPhim, IDTheLoai),

	FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim),
	FOREIGN KEY (IDTheLoai) REFERENCES TheLoai(IDTheLoai)
)

-- Phim_Định dạng_Ngôn ngữ
Create Table P_DN
(
	ID_PDN int NOT NULL PRIMARY KEY Identity(1,1),
	IDPhim int NOT NULL,
	ID_DinhDang tinyint NOT NULL,
	ID_NgonNgu tinyint NOT NULL,

	FOREIGN KEY (IDPhim) REFERENCES Phim(IDPhim),
	FOREIGN KEY (ID_DinhDang) REFERENCES DinhDang(ID_DinhDang),
	FOREIGN KEY (ID_NgonNgu) REFERENCES NgonNgu(ID_NgonNgu)
)


-- #########################
CREATE TABLE LichChieuPhim
(
	ID_LichChieu int NOT NULL PRIMARY KEY Identity(1,1),
	ID_PDN int NOT NULL,
	IDPhongChieuPhim tinyint,
	ThoiGianChieu smalldatetime,

	FOREIGN KEY (IDPhongChieuphim) REFERENCES PhongChieuphim(IDPhongChieuphim),
	FOREIGN KEY (ID_PDN) REFERENCES P_DN(ID_PDN)
)
-- Rename column
-- https://stackoverflow.com/a/16296669
--Exec sp_rename 'LichChieuPhim.IDPhongChieuphim', 'IDPhongChieuPhim', 'COLUMN'
--Exec sp_rename 'LichChieuPhim.IDPhongChieuphim', 'IDPhong', 'COLUMN'

-- #########################
CREATE TABLE Account_KH
(
	IDKhachHang varchar(9) NOT NULL PRIMARY KEY,
	TenDangNhap varchar(20),
	MatKhau varchar(10),
)

--Alter Table Account_KH
--	Add Unique (TenDangNhap) bỏ
--Alter Table Account_KH
--	Alter Column TenDangNhap varchar(20)
--Alter Table Account_KH
--	Alter Column MatKhau varchar(16)

CREATE TABLE KhachHang
(
	IDKhachHang varchar(9) NOT NULL PRIMARY KEY,
	HoTen nvarchar(30),
	NgaySinh date,
	--Que nvarchar(20),
	--SoChungMinhThu varchar(15),
	GioiTinh nvarchar(3) CHECK (GioiTinh= N'Nam' or GioiTinh= N'Nữ'),

	FOREIGN KEY (IDKhachHang) REFERENCES Account_KH(IDKhachHang)
)

--Alter Table KhachHang
--	Drop Column Que, SoChungMinhThu

-- IDKhachHang là 1 chuỗi gồm 9 kí tự ghép bởi millisecond + minutes + date + months
--Alter Table Account_KH
--	Alter Column IDKhachHang varchar(9)
--Alter Table KhachHang
--	Alter Column IDKhachHang varchar(9)

CREATE TABLE NhanVien
(
	IDNhanVien int NOT NULL PRIMARY KEY Identity(1,1),
	HoTen nvarchar(30),
	NgaySinh date,
	Que nvarchar(20),
	SoChungMinhThu varchar(15),
	GioiTinh nvarchar(3) CHECK (GioiTinh = N'Nam' or GioiTinh = N'Nữ'),
)

CREATE TABLE ChucVu
(
	IDChucVu tinyint NOT NULL PRIMARY KEY Identity(1,1),
	ChucVu nvarchar(20),
)

CREATE TABLE Account_NV
(
	IDNhanVien int NOT NULL PRIMARY KEY,
	TenDangNhap varchar(20),
	MatKhau varchar(10),
	IDChucVu tinyint,

	FOREIGN KEY (IDNhanVien) REFERENCES NhanVien(IDNhanVIen),
	FOREIGN KEY (IDChucVu) REFERENCES ChucVu(IDChucVu)
)

--Alter Table Account_NV
--	Add Unique (TenDangNhap) bỏ
--Alter Table Account_NV
--	Alter Column TenDangNhap varchar(20)
--Alter Table Account_NV
--	Alter Column MatKhau varchar(16)


-- #########################
CREATE TABLE ThoiGian
(
	ID_TG tinyint NOT NULL Primary key,
	TG_BatDau time,
	TG_KetThuc time
)

-- Đơn giá_Định dạng_Thời gian
CREATE TABLE DonGia
(
	ID_DinhDang tinyint NOT NULL,
	Thu tinyint CHECK (Thu > 0 and Thu < 8), -- theo SQL Chủ nhật ~ 1, Thứ 2 ~ 2
	-- Dùng hàm DatePart để kiểm tra ngày đặt vé với thứ
	ID_TG tinyint,
	DonGia real,
	MoTa nvarchar(max),
	Primary key (ID_DinhDang, Thu, ID_TG),

	Foreign key (ID_DinhDang) References DinhDang(ID_DinhDang),
	Foreign key (ID_TG) References ThoiGian(ID_TG)
)

-- http://www.sqlservertutorial.net/sql-server-basics/sql-server-rename-table/
-- EXEC sp_rename 'old_table_name', 'new_table_name'
-- Exec sp_rename 'DonGia_DD', 'DonGia'
--Alter Table DonGia
--	Drop Column MoTa

/*CREATE TABLE HoaDon_KH
(
	IDHoaDonKH varchar(20) NOT NULL PRIMARY KEY,
	IDKhachHang int,
	TongTien real,
	FOREIGN KEY (IDKhachHang) REFERENCES KhachHang(IDKhachHang)
)

CREATE TABLE HoaDon_POS
(
	IDHoaDon int NOT NULL PRIMARY KEY,
	TongTien real,
)
*/
/*Drop Table HoaDon_KH
Drop Table HoaDon_POS*/

CREATE TABLE Booking_POS	 --ChiTietHD_POS
(
	ID int NOT NULL,
	ID_LichChieu int NOT NULL,
	TG_MuaVe smalldatetime, -- Thời gian mua vé
	SoLuongVe tinyint,
	MaGheNgoi varchar(max),
	GheVIP bit,
	TongTien real, --ThanhTien
	Primary key (ID, ID_LichChieu),

	-- FOREIGN KEY (IDHoaDon) REFERENCES HoaDon_POS(IDHoaDon),
	FOREIGN KEY (ID_LichChieu) REFERENCES LichChieuPhim(ID_LichChieu)
)

--Alter Table ChiTietHD_POS
--	Alter Column MaGheNgoi varchar(max)

CREATE TABLE Booking_Client -- ChiTietHD_KH
(
	ID varchar(6) NOT NULL,
	IDKhachHang varchar(9),
	ID_LichChieu int NOT NULL,
	TG_MuaVe smalldatetime, -- Thời gian mua vé
	SoLuongVe tinyint,
	MaGheNgoi varchar(max),
	GheVIP bit,
	TongTien real,
	Primary key (ID, ID_LichChieu),

	-- FOREIGN KEY (IDHoaDonKH) REFERENCES HoaDon_KH(IDHoaDonKH),
	FOREIGN KEY (ID_LichChieu) REFERENCES LichChieuPhim(ID_LichChieu),
	FOREIGN KEY (IDKhachHang) REFERENCES Account_KH(IDKhachHang)
)

--Alter Table ChiTietHD_KH
--	Alter Column IDHoaDonKH varchar(6)




-- Câu lệnh đặt lại Identity -> nhưng phải xóa hết dl
Delete From NgonNgu
-- DBCC CHECKIDENT('tableName', RESEED, NEW_RESEED_VALUE)
DBCC CHECKIDENT('NgonNgu', RESEED, 0)



-- SQL Case Sensitive String Compare
-- https://stackoverflow.com/a/15471754
Alter Table Account_NV
	Alter Column TenDangNhap nvarchar(20)
		COLLATE SQl_Latin1_General_CP1_CS_AS --  CS = Case Sensitive, AS = Accent sensitive
--The object 'UQ__Account___55F68FC062998A23' is dependent on column 'TenDangNhap'.
-- Msg 4922, Level 16, State 9, Line 277
-- ALTER TABLE ALTER COLUMN TenDangNhap failed because one or more objects access this column.

-- Sửa lại
-- https://stackoverflow.com/a/1514262
Alter Table Account_NV
	Drop Constraint UQ__Account___55F68FC062998A23

Alter Table Account_NV
	Alter Column TenDangNhap nvarchar(20)
		COLLATE SQl_Latin1_General_CP1_CS_AS

Create UNIQUE INDEX UIX_TenDN_NV On Account_NV(TenDangNhap)
-- Drop INDEX Account_NV.UIX_TenDN_NV -- alter column type


Alter Table Account_KH
	Drop Constraint UQ__Account___55F68FC043D58C74

Alter Table Account_KH
	Alter Column TenDangNhap nvarchar(20)
		COLLATE SQl_Latin1_General_CP1_CS_AS
		
Create UNIQUE INDEX UIX_TenDN_KH On Account_KH(TenDangNhap)
--Drop INDEX Account_KH.UIX_TenDN_KH