-- View lấy các dữ liệu liên quan của 1 bộ phim





-- View lấy lịch chiếu phim






GO
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
