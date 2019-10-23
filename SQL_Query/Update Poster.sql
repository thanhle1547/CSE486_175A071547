-- https://stackoverflow.com/a/15660012
Update Phim 
	Set Poster = BulkColumn
		From OpenRowSet (Bulk 'D:\Learning\C#\Cinema Management\Movie Posters\joker_vietnamese_poster.png', Single_Blob ) as img
			Where IDPhim = 1

Update Phim 
	Set Poster = BulkColumn
		From OpenRowSet (Bulk 'D:\Learning\C#\Cinema Management\Movie Posters\avengers-endgame-poster-3d.png', Single_Blob ) as img
			Where IDPhim = 2

Update Phim 
	Set Poster = BulkColumn
		From OpenRowSet (Bulk 'D:\Learning\C#\Cinema Management\Movie Posters\Frozen 2.png', Single_Blob ) as img
			Where IDPhim = 3