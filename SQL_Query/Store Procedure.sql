-- Store Procedure accountLogin kiểm tra dữ liệu tài khoản NHÂN VIÊN đăng nhập có tồn tại 0
Create Proc ckLogin_NV @userName varchar(20), @passWord varchar(16)
As
Begin
	--Declare @HoTen nvarchar(30)
	Select HoTen, a.IDNhanVien
		From Account_NV a, NhanVien n
			Where TenDangNhap = @userName and MatKhau = @passWord
				and a.IDNhanVien = n.IDNhanVien
	/*if (@HoTen = '')
		return;
	Select @HoTen as HoTen*/
End


GO
-- Store Procedure accountLogin kiểm tra dữ liệu tài khoản KHÁCH HÀNG đăng nhập có tồn tại 0
Create Proc ckLogin_KH @userName varchar(20), @passWord varchar(16)
As
Begin
	--Declare @HoTen nvarchar(30)
	Select a.IDKhachHang
		From Account_KH a, KhachHang n
			Where TenDangNhap = @userName and MatKhau = @passWord
				and a.IDKhachHang = n.IDKhachHang
	/*if (@HoTen = '')
		return;
	Select @HoTen as HoTen*/
End


GO
-- Store Procedure
Create Proc SignUp_KH @IDKhachHang varchar(9), @userName varchar(20), @passWord varchar(16),
	@HoTen nvarchar(30), @NgaySinh date, @GioiTinh nvarchar(3)
As
Begin
	Insert into Account_KH
		Values (@IDKhachHang, @userName, @passWord)
	Insert into KhachHang
		Values (@IDKhachHang, COALESCE(@HoTen, 'unknown'), COALESCE(@NgaySinh, null), COALESCE(@GioiTinh, '') )
End

-- Store Procedure lấy thông tin tổng hợp của 1 tài khoản khách hàng








GO
-- Store Procedure lấy thông tin tổng hợp của 1 tài khoản nhân viên
Create Proc Get_dsNV @IDChucVu tinyint
As
Begin
	--Declare @HoTen nvarchar(30)
	Select HoTen, a.IDNhanVien
		From Account_NV a, NhanVien n
			Where TenDangNhap = @userName and MatKhau = @passWord
				and a.IDNhanVien = n.IDNhanVien
	/*if (@HoTen = '')
		return;
	Select @HoTen as HoTen*/
End








-- Store Procedure thêm dữ liệu hóa đơn



-- Store Procedure trả về số ghế còn trống (thường, VIP) theo lịch chiếu của mỗi phim
-- THAM SỐ: ID_LichChieu
-- tổng hợp từ số vé trong cả 2 bảng ChiTietHD_POS & ChiTietHD_KH 
-- nối từ ID_LichChieu trong bảng LichChieuPhim
GO
create proc st_ghetrong
As
	begin
		declare @pos table (SoLuongVe int,MaGheNgoi nvarchar(max), GheVip bit)
		 insert into @pos
		select sum (SoLuongVe) SoLuongVe,
			   STRING_AGG (MaGheNgoi,', ') as MaGhe,
			   GheVIP
			from Booking_POS 
				group by GheVIP



		declare @client table (SoLuongVe int,MaGheNgoi nvarchar(max), GheVip bit)
		 insert into @client
		select sum (SoLuongVe) SoLuongVe,
			   STRING_AGG (MaGheNgoi,', ') as MaGhe,
			   GheVIP
			from Booking_Client 
				group by GheVIP

		select sum (SoLuongVe) SoLuongVe,
			   STRING_AGG (MaGheNgoi,', ') as MaGhe,
			   GheVIP
			from (select * from @client UNION ALL select * from @POS) as t
			-- UNION ALL chạy nhanh hơn lệnh UNION vì nó không kiểm tra các bản ghi trùng lặp
				group by GheVIP

	end



   



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
					


GO
-- Store Proc lấy dl phim đang / sắp chiếu từ view v_DuLieu_Phim
-- Tránh tiền tố “sp_” với tên store procedure người dùng tự định nghĩa 
-- bởi vì SQL server đầu tiên tìm kiếm những thủ tục người dùng định nghĩa 
-- trong cơ sở dử liệu master và sau đó mới sử dụng phiên làm việc của cơ sở dữ liệu hiện hành
Alter Proc Get_Movies @comingSoon bit = 0, @all bit = 0
As
	if (@comingSoon = 0)
		Begin
			if (@all = 0)
				Select IDPhim, TenPhim, Poster, ThoiLuong, Rated From v_DuLieu_Phim	Where IDPhim in (Select * From dbo.getIDPhimDangChieu() )
			else
				Select * From v_DuLieu_Phim	Where IDPhim in (Select * From dbo.getIDPhimDangChieu() )
		End
	else
		Begin
			if (@all = 0)
				Select IDPhim, TenPhim, Poster, ThoiLuong, Rated From v_DuLieu_Phim	Where IDPhim in (Select * From dbo.getIDPhimSapChieu() )
			else
				Select * From v_DuLieu_Phim	Where IDPhim in (Select * From dbo.getIDPhimSapChieu() )
		End

Exec Get_Movies 1


GO
Create Proc Get_MovieInfors @id int
As
	Select DaoDien, DienVien, TheLoai, KhoiChieu, NgonNgu, MoTa, DinhDang From v_DuLieu_Phim Where IDPhim = @id





GO
-- Store Proc trả về lịch chiếu của 1 bộ phim từ view_LichChieuPhim theo NGÀY + số ghế đã đặt
-- tham số đầu vào là IDPhim, Ngày mà khách hàng chọn
Alter Proc Get_LichChieu_Ngay @IDPhim int, @Ngay date
As
	Select v.ID_LichChieu, ThoiGianChieu as ThoiGian, TenDinhDang as DinhDang, NgonNgu, TenPhong, SoLuongVe as SoGheTrong
							-- dùng TenPhong thay cho id
			From v_LichChieuPhim v, (Select * From Get_GhePhim(@IDPhim)) g
				Where cast(ThoiGianChieu as date) = @Ngay and v.IDPhim = @IDPhim and g.ID_LichChieu = v.ID_LichChieu
		
	/*Begin
		Select ID_LichChieu, ThoiGianChieu, TenDinhDang, NgonNgu, TenPhong
							-- dùng TenPhong thay cho id
			From v_LichChieuPhim v
				Where v.IDPhim = @IDPhim and cast(ThoiGianChieu as date) = @Ngay
		Select * From Get_GhePhim(@IDPhim)
	End*/
	/*Select v.ID_LichChieu, ThoiGianChieu, TenDinhDang, NgonNgu, TenPhong, SoLuongVe, MaGhe
							-- dùng TenPhong thay cho id
		From v_LichChieuPhim v, (Select * From Get_GhePhim()) s
			Where v.IDPhim = @IDPhim and v.ID_LichChieu = s.ID_LichChieu*/

/*	OK
Create Proc Get_2Table
As
	Begin
		Select * From Phim
		Select * From DienVien
	End
Exec Get_2Table*/

GO
-- Store Proc trả về lịch chiếu của 1 bộ phim từ view_LichChieuPhim theo PHÒNG
-- tham số đầu vào là IDPhim, Phòng chiếu
Create Proc Get_LichChieu_Phong @IDPhim int = null, @TenPhong varchar(5) = ''
As
	if (@TenPhong = '')
		Select TenPhong, ThoiGianChieu, TenDinhDang, NgonNgu
			From v_LichChieuPhim
				Where IDPhim = @IDPhim
	else if (@IDPhim is Null)
		Select TenPhim, ThoiGianChieu, TenDinhDang, NgonNgu
			From v_LichChieuPhim v, Phim p
				Where v.IDPhim = @IDPhim and TenPhong = @TenPhong and v.IDPhim = p.IDPhim
	else
		Select ID_LichChieu, ThoiGianChieu, TenDinhDang, NgonNgu
			From v_LichChieuPhim
				Where IDPhim = @IDPhim and TenPhong = @TenPhong








GO
-- Store Proc INSERT dl vào bảng liên quan đến 1 bộ phim
Create Proc isrt_MovieInf @TableName varchar(10), @IDPhim int, @data varchar(20)
As
Begin
	Declare @d varchar(5), @q varchar(max)
	Declare c Cursor
		For Select value From string_split(@data, ',')
	Open c

	Fetch NEXT From c into @d
	While (@@FETCH_STATUS = 0)
		Begin
			Set @q = 'Insert into ' + @TableName + 
				' Values(' + @IDPhim + ', ' + @d + ')'
			Exec(@q)
			Fetch NEXT From c into @d
		End
	Close c
	DeAllocate c
End


GO
Create Proc isrt_MovieInfs @TableName varchar(10), @ColNames varchar(20), 
			@IDPhim int, @data1 varchar(20), @data2 varchar(20)
As
Begin
	Declare @d1 varchar(5), @d2 varchar(5), @q varchar(max)
	Declare c1 Cursor
		For Select value From string_split(@data1, ',')
	Declare c2 Cursor
		For Select value From string_split(@data2, ',')
	Open c1
	Open c2

	Fetch NEXT From c1 into @d1
	Fetch NEXT From c1 into @d1
	While (@@FETCH_STATUS = 0)
		Begin
			Set @q = 'Insert into ' + @TableName + '(' + @ColNames + ')' +
				' Values(' + @IDPhim + ', ' + @d1 + ', ' + @d2 + ')'
			Exec(@q)
			Fetch NEXT From c1 into @d1
			Fetch NEXT From c1 into @d1
		End
	Close c1
	DeAllocate c1
	Close c2
	DeAllocate c2
End




GO
-- Store Proc INSERT 1 bộ phim
Alter Proc isrt_Movie @IDPhim int, @TenPhim nvarchar(max), @Poster image = null,
	@ThoiLuong tinyint, @KhoiChieu date, @Rated char(3), @MoTa nvarchar(max),
	@ID_NSX int = null, @IDs_DienVien varchar(20), @IDs_DaoDien varchar(20), 
	@IDs_NgonNgu varchar(20), @IDs_DinhDang varchar(20), @IDs_TheLoai varchar(20)
As
Begin
	Set NoCount ON;

	Insert into Phim
		Values (@IDPhim, @ID_NSX, @TenPhim, @Poster, @ThoiLuong, @KhoiChieu, @Rated, @MoTa)
	
	Exec isrt_MovieInf 'P_DaoDien', @IDPhim, @IDs_DaoDien
	Exec isrt_MovieInf 'P_DienVien', @IDPhim, @IDs_DienVien
	Exec isrt_MovieInf 'P_TheLoai', @IDPhim, @IDs_TheLoai
	Exec isrt_MovieInfs 'P_DN', 'IDPhim, ID_DinhDang, ID_NgonNgu', @IDPhim, @IDs_DinhDang, @IDs_NgonNgu
End

GO
-- DELETE 1 bộ phim
-- Trigger DELETE khi xóa 1 bộ phim thì dl tương ứng trong các bảng P_DaoDien.. cũng đc xóa theo
-- -> ko đc vì ràng buộc khóa ngoại 
Create Proc del_Movie @IDPhim int
As
Begin
	Declare @inserted Table (ID_PDN int)

	Delete From P_DaoDien Where IDPhim = @IDPhim
	Delete From P_DienVien Where IDPhim = @IDPhim
	Delete From P_TheLoai Where IDPhim = @IDPhim
	Delete From P_DN OUTPUT deleted.ID_PDN into @inserted Where IDPhim = @IDPhim
	Delete From Phim Where IDPhim = @IDPhim
	Delete From LichChieuPhim Where ID_PDN in (Select * From @inserted)
End

GO
Create Proc update_Movie @IDPhim int, @IDs_DienVien varchar(20) = null, @IDs_DaoDien varchar(20) = null, 
	@IDs_NgonNgu varchar(20) = null, @IDs_DinhDang varchar(20) = null, @IDs_TheLoai varchar(20) = null
As
Begin
	Set NoCount ON;
	if (@IDs_DaoDien != null)
		Begin
			Delete From P_DaoDien Where IDPhim = @IDPhim
			Exec isrt_MovieInf 'P_DaoDien', @IDPhim, @IDs_DaoDien
		End
	if (@IDs_DienVien != null)
		Begin
			Delete From P_DienVien Where IDPhim = @IDPhim
			Exec isrt_MovieInf 'P_DienVien', @IDPhim, @IDs_DienVien
		End
	if (@IDs_TheLoai != null)
		Begin
			Delete From P_TheLoai Where IDPhim = @IDPhim
			Exec isrt_MovieInf 'P_TheLoai', @IDPhim, @IDs_TheLoai
		End
	if (@IDs_NgonNgu != null)
		Begin
			Delete From P_DN Where IDPhim = @IDPhim
			Exec isrt_MovieInfs 'P_DN', 'IDPhim, ID_DinhDang, ID_NgonNgu', @IDPhim, @IDs_DinhDang, @IDs_NgonNgu
		End
End



GO
-- Trả về Đơn giá của phim lựa chọn
Alter Proc Get_DonGia @ID_LichChieu int, @TenDinhDang varchar(5)
As
	Select DonGia
		From v_LichChieuPhim l, v_DonGia d
			Where ID_LichChieu = @ID_LichChieu 
			and   d.TenDinhDang = @TenDinhDang
			and   DatePart(WEEKDAY, ThoiGianChieu) = Thu
			and   cast(ThoiGianChieu as Time) between TG_BatDau and TG_KetThuc

GO
Exec Get_DonGia 9, '2D'

Select * From v_LichChieuPhim
Select * From v_DonGia
			