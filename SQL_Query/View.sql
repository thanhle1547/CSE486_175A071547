Create View v_DienVien_Phim
As
	Select P_DienVien.IDPhim, STRING_AGG(DienVien.TenDienVien, ', ') As TenDienVien
		From DienVien, P_DienVien
			Where DienVien.IDDienVien = P_DienVien.IDDienVien
				Group by P_DienVien.IDPhim
GO
Create View v_DaoDien_Phim
As
	Select pdv.IDPhim, STRING_AGG(TenDaoDien, ', ') TenDaoDien
		From DaoDien dd, P_DaoDien pdv
			Where dd.IDDaoDien = pdv.IDDaoDien
				Group by pdv.IDPhim



-- View lấy các dữ liệu liên quan của 1 bộ phim
go
Create View v_dl_Phim
As
	 select p.IDPhim, KhoiChieu, poster, Thoiluong, p.MoTa,
			t.TenTheLoai,
			pdn.IDPhim,ID_PDN,
			nn.ID_NgonNgu,NgonNgu
	


	 from Phim p,v_DienVien_Phim pdv, v_DaoDien_Phim pdd ,P_Theloai pt,  TheLoai t,  P_DN pdn, DonGia_DD dg, 
	 NgonNgu nn, DinhDang dd
	 where p.IDPhim = pdv.IDPhim 
	 and   p.IDPhim=pdd.IDPhim
	 and   p.IDPhim=pt.IDPhim
	 and   pt.IDTheLoai=t.IDTheLoai
	 and   p.IDPhim=pdn.IDPhim
	 and   p.IDPhim=pdn.IDPhim
	 and   pdn.ID_NgonNgu=nn.ID_NgonNgu
	 and   pdn.ID_DinhDang=dd.ID_DinhDang
	 and   dd.ID_DinhDang=dg.ID_DinhDang






GO
-- View lấy lịch chiếu phim
Create View View_Laylichchieuphim
as
Select ID_LichChieu,ID_PDN,IDPhongChieuPhim,ThoiGianChieu
From LichChieuPhim l
Where l.ID_LichChieu=PhongChieuPhim.IDPhongChieuPhim

create View v_lichchieupim_Phim
As 
    select Lichchieuphim.ID_LichChieu,ThoiGianChieu,  ChiTietHD_KH.TG_MuaVe,MaGhengoi,GheVip,ThanhTien,
	       HoaDon_KH.TongTien,  
		   KhachHang.HoTen,GioiTinh,


	 
	 
	       

Select p.IDPhim, TenPhim, d.TenDinhDang, n.NgonNgu, c.TenPhong, ThoiGianChieu
From P_DN dn, LichChieuPhim l, DinhDang d, NgonNgu n, Phim p, PhongChieuPhim c
Where p.IDPhim = 1
	and dn.ID_PDN = l.ID_PDN 
	and dn.ID_DinhDang = d.ID_DinhDang
	and dn.ID_NgonNgu = n.ID_NgonNgu
	and dn.ID_PDN = l.IDPhongChieuPhim



-- View lấy các dữ liệu liên quan của 1 khách hàng
create View v_dl_KhachHang(IDKhachHang,HoTen,NgaySinh,GioiTinh)
As
   select IDKhachHang,HoTen,NgaySinh,GioiTinh    
    From KhachHang


-- View lấy các dữ liệu liên quan của 1 khách hàng
--Create view View_KhachHang
--As
--Select kh.IDKhachHanq,HoTen,NgaySinh,GioiTinh
--From Kha
--Where KhachHang.IDKhachhanq = Account_KH.IDKhachHang and 







GO
-- View lấy các dữ liệu liên quan của 1 nhân viên
Create view View_Nhanvien
As
Select nv.IDNhanVien ,HoTen,NgaySinh,Que,SoChungMinhThu,GioiTinh
From NhanVien nv,Account_NV a,ChucVu cv
Where nv.IDNhanVien=a.IDNhanVien and cv.IDChucVu=a.IDChucvu





-- View tổng hợp dl lịch chiếu phim tính tới ngày hiện tại
view_LichChieuPhim

TenPhim
DinhDang 
NgonNgu
TenPhong 
ThoiGian 
-- View tổng hợp dl của phim theo định dạng và ngôn ngữ