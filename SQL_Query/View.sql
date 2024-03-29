﻿Create View v_DienVien_Phim
As
	Select P_DienVien.IDPhim, STRING_AGG(DienVien.TenDienVien, ', ') As TenDienVien
		From DienVien, P_DienVien
			Where IDPhim in ( 
				Select * from dbo.getIDPhimDangChieu() 
					UNION ALL Select * from dbo.getIDPhimSapChieu()
		-- UNION ALL chạy nhanh hơn lệnh UNION vì nó không kiểm tra các bản ghi trùng lặp
				)
			and DienVien.IDDienVien = P_DienVien.IDDienVien
			    Group by P_DienVien.IDPhim

GO

Create View v_DaoDien_Phim
As
	Select pdv.IDPhim, STRING_AGG(TenDaoDien, ', ') TenDaoDien
		From DaoDien dd, P_DaoDien pdv
			Where IDPhim in ( 
				Select * from dbo.getIDPhimDangChieu() 
					UNION ALL Select * from dbo.getIDPhimSapChieu()
				)
			and dd.IDDaoDien = pdv.IDDaoDien
				Group by pdv.IDPhim

GO

Create View v_TheLoai_Phim
As
	Select ptl.IDPhim, STRING_AGG(TenTheLoai, ', ') TenTheLoai
		From TheLoai tl, P_TheLoai ptl
			Where IDPhim in ( 
				Select * from dbo.getIDPhimDangChieu() 
					UNION ALL Select * from dbo.getIDPhimSapChieu()
				)
			and tl.IDTheLoai = ptl.IDTheLoai
				Group by ptl.IDPhim
GO

Create View v_DinhDangNN
As
	Select pdn.ID_PDN, IDPhim,
		   nn.Ngonngu, dd.TenDinhDang
		From P_DN pdn, NgonNgu nn, DinhDang dd
			Where pdn.ID_NgonNgu = nn.ID_NgonNgu
			and   pdn.ID_DinhDang = dd.ID_DinhDang


-- View lấy các dữ liệu liên quan của 1 bộ phim
Create View v_DuLieu_Phim
As
	 Select p.IDPhim, TenPhim, TenNSX, Poster,
	        TenDienVien as DienVien, TenDaoDien as DaoDien, TenTheLoai as TheLoai,
			TenDinhDang as DinhDang, NgonNgu, KhoiChieu, Thoiluong, Rated, MoTa
	 From Phim p, NhaSanXuat nsx, v_DienVien_Phim pdv, v_DaoDien_Phim pdd, v_TheLoai_Phim vtl, v_DinhDangNN vdn
	 Where p.IDPhim = pdv.IDPhim
	 and   p.ID_NSX = nsx.ID_NSX
	 and   p.IDPhim = pdd.IDPhim
	 and   p.IDPhim = vtl.IDPhim
	 and   p.IDPhim = vdn.IDPhim

GO


-- View lấy lịch chiếu phim
ALter View v_LichChieuPhim
As 
    Select vdd.IDPhim, ID_LichChieu, lcp.ID_PDN, lcp.IDPhong, TenPhong, -- IDPhong cho Trigger
		   ThoiGianChieu, DateAdd(Minute, ThoiLuong, ThoiGianChieu) as ThoiGianKetThuc,
		   Concat(TenDinhDang, ' - ', NgonNgu) as DN
		From LichChieuPhim lcp, PhongChieuPhim pcp, v_DinhDangNN vdd, Phim p -- Phim p cho ThoiLuong
			Where ThoiGianChieu >= GETDATE()
			and lcp.IDPhong = pcp.IDPhong
			and lcp.ID_PDN = vdd.ID_PDN
			and lcp.IDPhong = pcp.IDPhong
			and vdd.IDPhim = p.IDPhim

Select * From v_LichChieuPhim
Select * From v_LichChieuPhim
	Where cast('2019-10-29 15:30' as datetime) Between ThoiGianChieu and ThoiGianKetThuc


GO    
-- View lấy các dữ liệu liên quan của 1 khách hàng
Alter View v_dl_KhachHang (IDKhachHang,HoTen,NgaySinh,GioiTinh)
As
   select kh.IDKhachHang, HoTen, NgaySinh, GioiTinh
		From KhachHang kh, Account_KH ackh
			where kh.IDKhachHang = ackh.IDKhachHang

GO

Select * From v_dl_KhachHang


GO
-- View lấy các dữ liệu liên quan của 1 nhân viên
Alter View v_dl_Nhanvien
As
	Select nv.IDNhanVien, HoTen, NgaySinh, Que, SoChungMinhThu, GioiTinh, cv.IDChucVu, ChucVu
		From NhanVien nv,Account_NV a,ChucVu cv
			Where nv.IDNhanVien = a.IDNhanVien 
			and cv.IDChucVu = a.IDChucvu

Select * From v_dl_Nhanvien

Select * From v_dl_Nhanvien Where ChucVu = 'Admin'


GO
-- View tổng hợp đơn giá
Alter View v_DonGia
As
	Select TenDinhDang, Thu, TG_BatDau, TG_KetThuc, DonGia
		From ThoiGian g, DonGia d, DinhDang dd
			Where g.ID_TG = d.ID_TG
			and dd.ID_DinhDang = d.ID_DinhDang




---- View tổng hợp dl lịch chiếu phim tính tới ngày hiện tại
--create View v_LichChieuPhim
--as 
--	select 
--          p.TenPhim,
--          pdn.DinhDang 
--          nn.NgonNgu
--          pcp.TenPhong, 
--         ThoiGian 
--		from phim p, P_DN pdn , NgonNgu nn, PhongChieuPhim pcp,
---- View tổng hợp dl của phim theo định dạng và ngôn ngữ