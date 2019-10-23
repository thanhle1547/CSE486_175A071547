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








-- Store Procedure trả về số ghế còn trống (thường, VIP) theo lịch chiếu của mỗi phim
-- THAM SỐ: ID_LichChieu
-- tổng hợp từ số vé trong cả 2 bảng ChiTietHD_POS & ChiTietHD_KH 
-- nối từ ID_LichChieu trong bảng LichChieuPhim





go

-- Store Proc nối dl DienVien, DaoDien
Create proc view_DienVien
	as
		select P_DienVien.IDPhim, STRING_AGG( DienVien.TenDienVien, ', ') as TenDienVien
			from DienVien,P_DienVien
				where DienVien.IDDienVien=P_DienVien.IDDienVien
					group by P_DienVien.IDPhim

GO

CREATE PROC view_DaoDien
	as 
		select pdv.IDPhim, STRING_AGG( TenDaoDien, ', ') TenDaoDien
			from DaoDien dd, P_DaoDien pdv
				where dd.IDDaoDien=pdv.IDDaoDien
					group by pdv.IDPhim
					


-- Store Proc trả về lịch chiếu của 1 bộ phim từ view_LichChieuPhim
-- tham số đầu vào là IDPhim, Ngày mà khách hàng chọn
Create Proc LichChieu
As
	Select 