-- Store Procedure accountLogin kiểm tra dữ liệu tài khoản NHÂN VIÊN đăng nhập có tồn tại 0
Create Proc ckLogin_NV @userName varchar(20), @passWord varchar(16)
As
Begin
	Declare @HoTen nvarchar(30)
	Select @HoTen = HoTen
		From Account_NV a, NhanVien n
			Where TenDangNhap = @userName and MatKhau = @passWord
				and a.IDNhanVien = n.IDNhanVien
	if (@HoTen = '')
		return;
	Select @HoTen as HoTen
End


GO
-- Store Procedure accountLogin kiểm tra dữ liệu tài khoản KHÁCH HÀNG đăng nhập có tồn tại 0
Create Proc ckLogin_KH @userName varchar(20), @passWord varchar(16)
As
Begin
	Declare @HoTen nvarchar(30)
	Select @HoTen = HoTen
		From Account_NV a, KhachHang n
			Where TenDangNhap = @userName and MatKhau = @passWord
				and a.IDNhanVien = n.IDKhachHang
	if (@HoTen = '')
		return;
	Select @HoTen as HoTen
End


-- Store Procedure lấy thông tin tổng hợp của 1 tài khoản khách hàng








-- Store Procedure lấy thông tin tổng hợp của 1 tài khoản nhân viên









-- Store Procedure thêm dữ liệu hóa đơn








-- Store Procedure trả về số ghế còn trống (thường, VIP) 
-- THAM SỐ: ID_LichChieu
-- tổng hợp từ số vé trong cả 2 bảng ChiTietHD_POS & ChiTietHD_KH 
-- nối từ ID_LichChieu trong bảng LichChieuPhim