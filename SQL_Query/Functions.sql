-- https://stackoverflow.com/questions/194852/how-to-concatenate-text-from-multiple-rows-into-a-single-text-string-in-sql-serv
Select p.IDPhim, STRING_AGG(d.TenDienVien, ', ') as DienVien
	From DienVien d, P_DienVien p
		Where d.IDDienVien = p.IDDienVien
			Group by p.IDPhim
GO


--------------------------
Create Function DienVien_Phim()
	RETURNS @tb Table (IDPhim int, TenDienVien nvarchar(20))
-- string or binary data would be truncated ->> do nvarchar(20) nhưng STRING_AGG trả về chuỗi dài hơn
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
Alter Function Get_GhePhim(@IDPhim int)
	RETURNS @t TABLE (ID_LichChieu int, SoLuongVe int)
As
	Begin
		declare @id table (ID_LichChieu int, SoGhe int)
		Insert into @id
			Select ID_LichChieu, Sum(SoGheThuong + SoGheVIP) as SoGhe
				From v_LichChieuPhim v, PhongChieuPhim p
					Where IDPhim = @IDPhim and v.TenPhong = p.TenPhong
						Group by ID_LichChieu

		-- https://stackoverflow.com/questions/14877797/how-to-sum-two-fields-within-an-sql-query/14877850
		declare @pc table (ID_LichChieu int, SoLuongVe int, SoLuongVe2 int)
		Insert into @pc
			select i.ID_LichChieu,
				   sum(p.SoLuongVe) SoLuongVe,
				   sum(c.SoLuongVe) SoLuongVe2
				   --COALESCE(sum(p.SoLuongVe), 0) SoLuongVe,
				   --COALESCE(sum(c.SoLuongVe), 0) SoLuongVe2
				   -- (Case sum (SoLuongVe) When null then 0 else sum (SoLuongVe) End) SoLuongVe
				from Booking_POS p, @id i, Booking_Client c
					Where p.ID_LichChieu in (Select ID_LichChieu From @id) and c.ID_LichChieu in (Select ID_LichChieu From @id)
						Group by i.ID_LichChieu
			UNION ALL Select ID_LichChieu, 0, 0 From @id

		declare @total table (ID_LichChieu int, SoLuongVe int)
		Insert into @total
			select  p.ID_LichChieu,
					SoLuongVe + SoLuongVe2 as SoLuongVe
				from @pc p

			--declare @tot table (ID_LichChieu int, SoLuongVe int)
			--Insert into @tot
			--		Select (Select SoGhe from @id) - (Select SoLuongVe from  @total)

		Insert into @t
			select  i.ID_LichChieu,
					(Select SoGhe from @id) - Sum(SoLuongVe) as SoLuongVe
				from @total t, @id i
				-- UNION ALL chạy nhanh hơn lệnh UNION vì nó không kiểm tra các bản ghi trùng lặp
					Where t.ID_LichChieu = i.ID_LichChieu
						group by i.ID_LichChieu
		return
	End

Select * From dbo.Get_GhePhim(1)

--Select COALESCE(Sum(TongTien), 0) From Booking_Client
-- Select ISNULL(ID_LichChieu, 0) From Booking_Client ->> TH 0 có dl -> 0 đc, kể cả COALESCE
--Select COALESCE(ID_LichChieu, (Select ID_LichChieu From v_LichChieuPhim)) From Booking_Client 


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

Select dbo.Get_MaGhe(8)
Print dbo.Get_MaGhe(8)