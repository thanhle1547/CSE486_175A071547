-- https://stackoverflow.com/questions/194852/how-to-concatenate-text-from-multiple-rows-into-a-single-text-string-in-sql-serv
Select p.IDPhim, STRING_AGG(d.TenDienVien, ', ') as DienVien
	From DienVien d, P_DienVien p
		Where d.IDDienVien = p.IDDienVien
			Group by p.IDPhim
GO


--------------------------
Create Function DienVien_Phim()
	RETURNS @tb Table (IDPhim int, TenDienVien nvarchar(20))
As
Begin
	Insert Into @tb
		Select P_DienVien.IDPhim, STRING_AGG(DienVien.TenDienVien, ', ') As TenDienVien
			From DienVien, P_DienVien
				Where DienVien.IDDienVien = P_DienVien.IDDienVien
					Group by P_DienVien.IDPhim
	Return
End

GO


Create Function DaoDien_Phim()
	RETURNS Table 
As 
	Return Select pdv.IDPhim, STRING_AGG(TenDaoDien, ', ') TenDaoDien
				From DaoDien dd, P_DaoDien pdv
					Where dd.IDDaoDien = pdv.IDDaoDien
						Group by pdv.IDPhim


select * from  DienVien_Phim()


Go


Create Function getIDPhimDangChieu()
	RETURNS @bien TABLE (IDPhim int)
As
	Begin
		Insert into @bien
			Select IDPhim
			From LichChieuPhim lcp, P_DN pdn
				Where ThoiGianChieu >= GETDATE()
				and lcp.ID_PDN = pdn.ID_PDN
	   Return
	End
  
GO

Create Function getIDPhimSapChieu()
	RETURNS @bien TABLE (IDPhim int)
As
	Begin
		Insert into @bien
			Select IDPhim
				From Phim 
					Where KhoiChieu >= Convert(date, GETDATE())
		Return
	End


GO 
Create Function Get_GhePhim(@IDPhim int)
	RETURNS @t TABLE (ID_LichChieu int, SoLuongVe int)
As
	Begin
		declare @id table (ID_LichChieu int)
		Insert into @id
			Select ID_LichChieu From v_LichChieuPhim Where IDPhim = @IDPhim

		declare @pos table (ID_LichChieu int, SoLuongVe int)
		Insert into @pos
			select ID_LichChieu,
				   sum (SoLuongVe) SoLuongVe
				from Booking_POS
					Where ID_LichChieu in (Select * From @id)
						Group by ID_LichChieu

		declare @client table (ID_LichChieu int, SoLuongVe int)
		Insert into @client
			select ID_LichChieu,
				   sum (SoLuongVe) SoLuongVe
				from Booking_Client 
					Where ID_LichChieu in (Select * From @id)
						Group by ID_LichChieu

		Insert into @t
			select ID_LichChieu,
				   sum (SoLuongVe) SoLuongVe
				from (select * from @client UNION ALL select * from @POS) as t
				-- UNION ALL chạy nhanh hơn lệnh UNION vì nó không kiểm tra các bản ghi trùng lặp
					group by ID_LichChieu
		return
	End

GO 
Create Function Get_MaGhe(@ID_LichChieu int)
	RETURNS VARCHAR(max)
As
	Begin
		declare @pos varchar(max)
			select @pos = STRING_AGG (MaGheNgoi,',')
				from Booking_POS
					Where ID_LichChieu = @ID_LichChieu

		declare @client varchar(max)
			select @client = STRING_AGG (MaGheNgoi,',')
				from Booking_Client 
					Where ID_LichChieu = @ID_LichChieu
		Declare @result varchar(max) = Concat(@pos, ' , ', @client)
		return @result
	End