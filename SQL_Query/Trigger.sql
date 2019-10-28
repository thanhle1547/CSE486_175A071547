-- Kiểm tra
Create Trigger insert_Phim


GO
-- Khi INSERT vào lịch 1 bản ghi ->> kiểm tra thời gian chiếu của phim đó có 
-- bị trùng với thời gian chiếu của phim trước đó
Alter Trigger Insert_LCP -- LichChieuPhim
On LichChieuPhim
For INSERT
AS
	if ( Exists (Select 1 From v_LichChieuPhim l, inserted
			Where inserted.ThoiGianChieu Between l.ThoiGianChieu and l.ThoiGianKetThuc) )
		Begin
-- https://docs.microsoft.com/en-us/sql/relational-databases/errors-events/database-engine-error-severities?view=sql-server-ver15
			RaisError(N'Lịch chiếu trùng thời gian', 16, 1)
			RollBack Tran
		End

Insert into LichChieuPhim ([ID_PDN], [IDPhong], [ThoiGianChieu])
	Values (1, 1, '2019-10-28 16:20')