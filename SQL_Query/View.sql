-- View lấy các dữ liệu liên quan của 1 bộ phim
go
Create View v_dl_Phim
As
	 select Phim.KhoiChieu, poster, Thoiluong, MoTa,
	        P_DaoDien.IDPhim,
			DaoDien.TenDaoDien,
			DienVien.IDPhim,TenDienVien,
			P_DienVien.IDphim,IDdienVien,
			P_TheLoai.IDPhim, TheLoai.TenTheLoai,
			P_DN.ID_DinhDang,IDPhim,ID_PDN,
			NgonNgu.ID_NgonNgu,NgonNgu,
			DinhDang.ID_DinhDang,TenDinhDang,
			DonGia_DD.Thu,DonGia


	 from Phim p,  P_DaoDien pdd,  DaoDien d, P_DienVien pdv, DienVien dv ,P_Theloai pt,  TheLoai t,  P_DN pdn, DonGia_DD dg,  NgonNgu nn, DinhDang dd
	 where p.IDPhim = pdv.IDPhim
	 and   pdv.IDDienVien=dv.IDDienVien
	 and   p.IDPhim=pdd.IDPhim
	 and   Pdd.IDDaoDien=d.IDDaoDien
	 and   p.IDPhim=pt.IDPhim
	 and   pt.IDTheLoai=t.IDTheLoai
	 and   p.IDPhim=pdn.IDPhim
	 and   p.IDPhim=pdn.IDPhim
	 and   pdn.ID_NgonNgu=nn.ID_NgonNgu
	 and   pdn.ID_DinhDang=dd.ID_DinhDang
	 and   dd.ID_DinhDang=dg.DonGia







-- View lấy lịch chiếu phim

create View v_lichchieupim_Phim
As 
    select Lichchieuphim.ID_LichChieu,ThoiGianChieu,  ChiTietHD_KH.TG_MuaVe,MaGhengoi,GheVip,ThanhTien,
	       HoaDon_KH.TongTien,  
		   KhachHang.HoTen,GioiTinh,


	 
	 
	       





-- View lấy các dữ liệu liên quan của 1 khách hàng
create View v_dl_KhachHang(IDKhachHang,HoTen,NgaySinh,GioiTinh)
As
   select IDKhachHang,HoTen,NgaySinh,GioiTinh    
    From KhachHang









-- View lấy các dữ liệu liên quan của 1 nhân viên
create View v_dl_NhanVien(IDNhanVien,HoTen,NgaySinh,GioiTinh)
As
   select IDNhanVien,HoTen,NgaySinh,GioiTinh
    From NhanVien