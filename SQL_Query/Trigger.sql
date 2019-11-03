-- Kiểm tra
Create Trigger insert_Phim


GO
-- Khi INSERT vào lịch 1 bản ghi ->> kiểm tra thời gian chiếu của phim đó có 
-- bị trùng với thời gian chiếu của phim trước đó
Create Trigger Insert_LCP -- LichChieuPhim
On LichChieuPhim
For INSERT
AS
Begin
	if ( Exists (Select 1 From Phim p, P_DN d, inserted i 
						Where d.ID_PDN = i.ID_PDN and p.IDPhim = d.IDPhim and ThoiLuong is null) 
		)
		Begin
			RaisError(N'Phim chưa có thời lượng', 16, 1)
			RollBack Tran
		End

	-- đk này ko đúng nếu chèn vào 1 thời gian cũ
	-- dùng view thì sau khi chèn xong, view đc tạo lại, trùng lặp bản ghi
	-- dùng inner join thì khi 0 có bản khi ở view
	if ( Exists
			(Select 1 From v_LichChieuPhim l, inserted i
					Where i.ThoiGianChieu Between l.ThoiGianChieu and l.ThoiGianKetThuc
					and l.IDPhong = i.IDPhong
						Having Count(1) > 1 -- https://stackoverflow.com/a/43520873
				)
		)
		Begin
-- https://docs.microsoft.com/en-us/sql/relational-databases/errors-events/database-engine-error-severities?view=sql-server-ver15
			--Select * From inserted
			--Select l.* From v_LichChieuPhim l, inserted i
			--		Where i.ThoiGianChieu Between l.ThoiGianChieu and l.ThoiGianKetThuc
			--		and l.IDPhong = i.IDPhong
			RaisError(N'Lịch chiếu trùng thời gian', 16, 1)
			RollBack Tran
		End
End

Insert into LichChieuPhim ([ID_PDN], [IDPhong], [ThoiGianChieu])
	Values (1, 2, '2019-10-30 20:10')

Insert into LichChieuPhim ([ID_PDN], [IDPhong], [ThoiGianChieu])
	Values (1, 1, '2019-10-29 15:20')

Insert into LichChieuPhim ([ID_PDN], [IDPhong], [ThoiGianChieu])
	Values (1, 1, '2019-10-30 15:20')

-- Lỗi khi 0 có bản ghi trong csdl -> lỗi vì nối TG KetThuc dựa trên thời lượng của các phim để ra bảng mới
-- dùng v_LichChieuPhim vào TH chèn vào 1 thòi gian cũ thì 0 đc -> sửa trên phần mềm
Insert into LichChieuPhim ([ID_PDN], [IDPhong], [ThoiGianChieu])
	Values (4, 2, '2019-10-29 15:20')

Insert into v_LichChieuPhim ([ID_PDN], [IDPhong], [ThoiGianChieu])
	Values (4, 2, '2019-10-29 15:20')

--  chèn vào 1 thời gian cũ
Insert into LichChieuPhim ([ID_PDN], [IDPhong], [ThoiGianChieu])
	Values (1, 1, '2019-10-28 15:20')



Create Trigger Update_LCP -- LichChieuPhim
On LichChieuPhim
For UPDATE
AS
Begin
	if ( Exists
			(Select 1 From v_LichChieuPhim l, inserted i
					Where i.ThoiGianChieu Between l.ThoiGianChieu and l.ThoiGianKetThuc
					and l.IDPhong = i.IDPhong
						Having Count(1) > 1
				)
		)
		Begin
			RaisError(N'Lịch chiếu trùng thời gian', 16, 1)
			RollBack Tran
		End
End