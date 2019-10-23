-- https://stackoverflow.com/questions/194852/how-to-concatenate-text-from-multiple-rows-into-a-single-text-string-in-sql-serv
Select p.IDPhim, STRING_AGG(d.TenDienVien, ', ') as DienVien
	From DienVien d, P_DienVien p
		Where d.IDDienVien = p.IDDienVien
			Group by p.IDPhim
go

create function DienVien_Phim()
returns @tb table (IDPhim int, TenDienVien nvarchar(20))
as
begin
	insert into @tb	
		select P_DienVien.IDPhim, STRING_AGG( DienVien.TenDienVien, ', ') as TenDienVien
			from DienVien,P_DienVien
				where DienVien.IDDienVien=P_DienVien.IDDienVien
					group by P_DienVien.IDPhim
	return
end

GO


create function DaoDien_Phim()
RETURNS TABLE
as
	return select pdv.IDPhim, STRING_AGG( TenDaoDien, ', ') TenDaoDien
			from DaoDien dd, P_DaoDien pdv
				where dd.IDDaoDien=pdv.IDDaoDien
					group by pdv.IDPhim
select * from  DienVien_Phim()
