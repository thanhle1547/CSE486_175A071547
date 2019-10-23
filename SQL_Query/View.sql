Create View v_DienVien_Phim
As
	Select P_DienVien.IDPhim, STRING_AGG(DienVien.TenDienVien, ', ') As TenDienVien
		From DienVien, P_DienVien
			Where IDPhim in ( 
				select * from dbo.getIDPhimDangChieu() 
				union select * from dbo.getIDPhimSapChieu()
				)
			and DienVien.IDDienVien = P_DienVien.IDDienVien
			    Group by P_DienVien.IDPhim

GO

Create View v_DaoDien_Phim
As
	Select pdv.IDPhim, STRING_AGG(TenDaoDien, ', ') TenDaoDien
		From DaoDien dd, P_DaoDien pdv
			Where IDPhim in ( 
				select * from dbo.getIDPhimDangChieu() 
				union select * from dbo.getIDPhimSapChieu()
				)
			and dd.IDDaoDien = pdv.IDDaoDien
				Group by pdv.IDPhim

GO

create View v_TheLoai_Phim
As
	Select ptl.IDPhim, STRING_AGG(TenTheLoai, ', ') TenTheLoai
		From TheLoai tl, P_TheLoai ptl
			Where IDPhim in ( 
				select * from dbo.getIDPhimDangChieu() 
				union select * from dbo.getIDPhimSapChieu()
				)
			and tl.IDTheLoai = ptl.IDTheLoai
				group by ptl.IDPhim
GO

create View v_DinhDangNN
As
	select pdn.ID_PDN,IDPhim ,
		   nn.ngonngu,
		   dd.TenDinhDang
		From P_DN pdn, NgonNgu nn, DinhDang dd
			where pdn.ID_NgonNgu = nn.ID_NgonNgu
			and   pdn.ID_DinhDang = dd.ID_DinhDang

-- View lấy các dữ liệu liên quan của 1 bộ phim

Create View v_DuLieu_Phim
As
	 select p.IDPhim, poster,
	        pdv.TenDienVien,
			pdd.TenDaoDien,
			vtl.TenTheLoai,
			NgonNgu,KhoiChieu,Thoiluong, p.MoTa
	 from Phim p,v_DienVien_Phim pdv, v_DaoDien_Phim pdd ,v_TheLoai_Phim vtl,  v_DinhDangNN vddnn
	 where p.IDPhim = pdv.IDPhim 
	 and   p.IDPhim=pdd.IDPhim
	 and   p.IDPhim=vtl.IDPhim
	 and   p.IDPhim=vddnn.IDPhim

GO
-- View lấy lịch chiếu phim

create View v_lichchieupim_Phim
As 
    select lcp.ID_LichChieu,lcp.ID_PDN , pcp.TenPhong,ThoiGianChieu,  
		   vdd.NgonNgu,vdd.TenDinhDang
		from LichChieuPhim lcp,  PhongChieuPhim pcp,v_DinhDangNN vdd
			where ThoiGianChieu>= GETDATE()
			and lcp.IDPhongChieuPhim = pcp.IDPhongChieuPhim
			and lcp.ID_PDN = vdd.ID_PDN

GO    
-- View lấy các dữ liệu liên quan của 1 khách hàng
create View v_dl_KhachHang(IDKhachHang,HoTen,NgaySinh,GioiTinh)
As
   select kh.IDKhachHang,HoTen,GioiTinh,    
          ackh.TenDangNhap
		From KhachHang kh, Account_KH ackh
			where kh.IDKhachHang = ackh.IDKhachHang

GO

-- View lấy các dữ liệu liên quan của 1 nhân viên
Create View v_dl_Nhanvien
As
	Select nv.IDNhanVien ,HoTen,NgaySinh,Que,SoChungMinhThu,GioiTinh,cv.ChucVu
		From NhanVien nv,Account_NV a,ChucVu cv
			Where nv.IDNhanVien=a.IDNhanVien 
			and cv.IDChucVu=a.IDChucvu





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