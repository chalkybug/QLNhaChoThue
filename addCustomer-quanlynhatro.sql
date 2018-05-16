USE	QuanLyNhaChoThue
GO


--login
INSERT dbo.DangNhap
        ( name, pass )
VALUES  ( 'admin', -- username - varchar(50)
          '123'  -- pass - varchar(50)
          )
GO

-- thêm khách
INSERT dbo.Khach VALUES  ( 'ms1' ,N'Nguyễn Văn Đức' , 1987 , 1 , '013575492345' ,  N'hà nội' , '0931843124' )
INSERT dbo.Khach VALUES  ( 'ms2' ,N'Nguyễn Văn Hoàng' , 1977 , 1 , '013455492345' ,  N'thái nguyên' , '093184624' )
INSERT dbo.Khach VALUES  ( 'ms3' ,N'Nguyễn Lâm Anh' , 1981 , 0 , '013575494535' ,  N'cao bằng' , '09313124' )
INSERT dbo.Khach VALUES  ( 'ms4' ,N'Hà Thu Giang' , 1982 , 0 , '013575492345' ,  N'lạng sơn' , '0931843124' )
INSERT dbo.Khach VALUES  ( 'ms5' ,N'Cù Văn Chính' , 1983 , 1 , '013575762345' ,  N'phú thọ' , '096443124' )
INSERT dbo.Khach VALUES  ( 'ms6' ,N'Hoàng Lan Nghi' , 1984 , 1 , '013573592345' ,  N'hà tây' , '093184644' )
INSERT dbo.Khach VALUES  ( 'ms7' ,N'Nguyễn Trần Quân' , 1985 , 0 , '013577492345' ,  N'vĩnh phúc' , '09318324' )
INSERT dbo.Khach VALUES  ( 'ms8' ,N'Nguyễn Văn Giáp' , 1987 , 1 , '013575492345' ,  N'đông anh' , '0931843124' )
INSERT dbo.Khach VALUES  ( 'ms9' ,N'Nguyễn Đức Nam' , 1987 , 0 , '019875492345' ,  N'nam định' , '0931843124' )
INSERT dbo.Khach VALUES  ( 'ms10' ,N'Nguyễn Văn Tôn' , 1988 , 1 , '013575465345' ,  N'bắc ninh' , '09343124' )
INSERT dbo.Khach VALUES  ( 'ms11' ,N'Nguyễn Hoàng Tôn' , 1989 , 1 , '013575492345' ,  N'hà nội' , '0931843124' )
INSERT dbo.Khach VALUES  ( 'ms12' ,N'Nguyễn Chí Thanh' , 1990 , 1 , '013575492345' ,  N'hà nội' , '0936443124' )
INSERT dbo.Khach VALUES  ( 'ms13' ,N'Nguyễn Trần Đạt' , 1991 , 1 , '013575492345' ,  N'hà nội' , '09313124' )
INSERT dbo.Khach VALUES  ( 'ms14' ,N'Hà Thị Thu Uyên' , 1992 , 0 , '013875492345' ,  N'hà nội' , '093763124' )

go
-- thêm phòng
INSERT dbo.Phong VALUES  ( 'r1' , 100 , N'Đơn' , N'Trống' , 230 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r2' , 140 , N'Đơn' , N'Trống' , 540 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r3' , 150 , N'Đôi' , N'Trống' , 120 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r4' , 160 , N'Đơn' , N'Trống' , 540 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r5' , 130 , N'Đơn' , N'Trống' , 120 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r6' , 110 , N'Đôi' , N'Trống' , 340 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r7' , 150 , N'Đơn' , N'Trống' , 120 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r8' , 160 , N'Đôi' , N'Trống' , 230 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r9' , 170 , N'Đơn' , N'Trống' , 200 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r10' , 120 , N'Đôi' , N'Trống' , 300 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r11' , 140 , N'Đơn' , N'Trống' , 200 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r12' , 150 , N'Đôi' , N'Trống' , 400 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r13' , 30 , N'Đơn' , N'Trống' , 200 , N'Tv tủ lạnh quạt' )
INSERT dbo.Phong VALUES  ( 'r14' , 20 , N'Đôi' , N'Trống' , 100 , N'Tv tủ lạnh quạt' )
GO

-- thêm đăng ký phòng
INSERT dbo.DangKyPhong VALUES  ( 'ms1' , 'r1' , 2 , GETDATE() , 100 , GETDATE() , N'tiền mặt' )
UPDATE dbo.Phong SET tinhtrang=N'Có người' WHERE maphong='r1'
INSERT dbo.DangKyPhong VALUES  ( 'ms2' , 'r2' , 2 , GETDATE() , 100 , GETDATE() , N'tiền mặt' )
UPDATE dbo.Phong SET tinhtrang=N'Có người' WHERE maphong='r2'
INSERT dbo.DangKyPhong VALUES  ( 'ms3' , 'r3' , 1 , GETDATE() , 100 , GETDATE() , N'tiền mặt' )
UPDATE dbo.Phong SET tinhtrang=N'Có người' WHERE maphong='r3'
INSERT dbo.DangKyPhong VALUES  ( 'ms4' , 'r4' , 2 , GETDATE() , 100 , GETDATE() , N'tiền mặt' )
UPDATE dbo.Phong SET tinhtrang=N'Có người' WHERE maphong='r4'
INSERT dbo.DangKyPhong VALUES  ( 'ms5' , 'r5' , 1 , GETDATE() , 100 , GETDATE() , N'tiền mặt' )
UPDATE dbo.Phong SET tinhtrang=N'Có người' WHERE maphong='r5'
INSERT dbo.DangKyPhong VALUES  ( 'ms6' , 'r6' , 2 , GETDATE() , 100 , GETDATE() , N'tiền mặt' )
UPDATE dbo.Phong SET tinhtrang=N'Có người' WHERE maphong='r6'
INSERT dbo.DangKyPhong VALUES  ( 'ms7' , 'r7' , 1 , GETDATE() , 100 , GETDATE() , N'tiền mặt' )
UPDATE dbo.Phong SET tinhtrang=N'Có người' WHERE maphong='r7'
INSERT dbo.DangKyPhong VALUES  ( 'ms8' , 'r8' , 2 , GETDATE() , 100 , GETDATE() , N'tiền mặt' )
UPDATE dbo.Phong SET tinhtrang=N'Có người' WHERE maphong='r8'
GO
