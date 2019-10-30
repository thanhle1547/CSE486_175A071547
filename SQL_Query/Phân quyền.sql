--use QLRapChieuPhim

-- Tạo Login
sp_addlogin 'admin', 'admin123'
GO
sp_addlogin 'perManner', 'pm'
GO
sp_addlogin 'staff', 'sff'

-- Tạo user
Exec sp_grantdbaccess 'admin', 'Thanh'
Exec sp_grantdbaccess 'perManner', 'Hinh'
Exec sp_grantdbaccess 'staff', 'Quy'

-- Tạo role
sp_addrole 'admin'
	-- Thêm user vào role
	sp_addrolemember 'admin', 'Thanh'
	-- Cấp quyền cho role
	Grant Select, Insert, Update to admin

sp_addrole 'personnelManner'
	sp_addrolemember 'personnelManner', 'Hinh'
	Grant Select, Insert, Update On NhanVien to personnelManner