CREATE DATABASE QuanLyNhaChoThue
GO

USE QuanLyNhaChoThue
GO
----------------------------------------------------------------------------------------------------------------- create
CREATE TABLE DangNhap(
	name VARCHAR(50),
	pass VARCHAR(50)
);
GO

CREATE TABLE Phong(
	maphong VARCHAR(10) PRIMARY KEY,
	dientich INT,
	loaiphong NVARCHAR(10),
	tinhtrang NVARCHAR(20),
	giaphong INT,
	dodac NTEXT

);
GO

CREATE TABLE Khach(
	makhach VARCHAR(10) PRIMARY KEY,
	hoten NVARCHAR(50),
	namsinh INT,
	gioitinh BIT,
	cmnd VARCHAR(12),
	quequan NVARCHAR(20),
	sdt VARCHAR(11),

);
GO

CREATE TABLE DangKyPhong(

	mahdp INT PRIMARY KEY IDENTITY,
	makhach VARCHAR(10) REFERENCES dbo.Khach(makhach),
	maphong VARCHAR(10) REFERENCES dbo.Phong(maphong),
	songuoi INT,
	ngaythue DATE,
	datcoc int,
	ngaytra DATE,
	htthanhtoan NVARCHAR(15)

);
GO
-------- bill
CREATE TABLE Bill(
	id INT IDENTITY PRIMARY KEY,
	price FLOAT,
	makhach VARCHAR(10) REFERENCES dbo.Khach(makhach),
	maphong VARCHAR(10) REFERENCES dbo.Phong(maphong),
	timePayment DATE,
	timefrom DATE,
	timeto DATE,

);

----------------------------------------------------------------------------------------------------------------- proc
--check login
CREATE PROC checkLogin
 @username VARCHAR(50), @password VARCHAR(50)
 AS
BEGIN	
	SELECT * FROM dbo.DangNhap WHERE name=@username AND pass=@password

END
GO



-- thêm bảng đăng ký phòng
CREATE PROC SelectRoomForCustomer
@mahp INT,@makhach VARCHAR(10), @maphong VARCHAR(10), @songuoi INT,  @ngaythue VARCHAR(20), @ngaytra VARCHAR(20), @datcoc INT, @htthanhtoan NVARCHAR(50)
AS
BEGIN
SET IDENTITY_INSERT DangKyPhong ON
	INSERT dbo.DangKyPhong
	        ( mahdp ,
	          makhach ,
	          maphong ,
	          songuoi ,
	          ngaythue ,
	          datcoc ,
	          ngaytra ,
	          htthanhtoan
	        )
	VALUES  ( @mahp , -- mahdp - varchar(10)
	          @makhach , -- makhach - varchar(10)
	          @maphong , -- maphong - varchar(10)
	          @songuoi , -- songuoi - int
	          @ngaythue , -- ngaythue - date
	          @datcoc , -- datcoc - int
	          @ngaytra , -- ngaytra - date
	          @htthanhtoan  -- htthanhtoan - nvarchar(15)
	        )
			
SET IDENTITY_INSERT DangKyPhong OFF
end

GO

-- thêm khách
CREATE PROC DangKyKhach
@makhach VARCHAR(10), @hoten NVARCHAR(50),@namsinh INT, @gioitinh BIT,@cmnd VARCHAR(12),@quequan NVARCHAR(20),@sdt VARCHAR(11)
AS
BEGIN
	INSERT dbo.Khach
	        ( makhach ,
	          hoten ,
	          namsinh ,
	          gioitinh ,
	          cmnd ,
	          quequan ,
	          sdt
	        )
	VALUES  ( @makhach , -- makhach - varchar(10)
	          @hoten , -- hoten - nvarchar(50)
	          @namsinh , -- nawmsinh - int
	          @gioitinh , -- gioitinh - bit
	          @cmnd , -- cmnd - varchar(12)
	          @quequan  , -- quequan - nvarchar(20)
	          @sdt  -- sdt - varchar(11)
			  )

END
GO

-- thêm phòng
CREATE  PROC AddRoom
@maphong VARCHAR(10), @dientich INT, @loaiphong NVARCHAR(10), @tinhtrang NVARCHAR(20), @giaphong INT,@dodac NTEXT
AS
BEGIN
		INSERT dbo.Phong
        ( maphong ,
          dientich ,
          loaiphong ,
          tinhtrang ,
          giaphong ,
          dodac
        )
VALUES  (@maphong , -- maphong - varchar(10)
          @dientich , -- dientich - int
          @loaiphong , -- loaiphong - nvarchar(10)
          @tinhtrang , -- tinhtrang - nvarchar(20)
          @giaphong , -- giaphong - int
          @dodac  -- dodac - ntext
        )


end

GO

------------------------------------------------------------------------------------------------Update

-----------Update Khách
CREATE PROC UpdateCustomer
@makhach varchar(10),
@hoten nvarchar(50),
@namsinh int,
@gioitinh bit,
@sdt varchar(11),
@quequan nvarchar(20),
@cmnd varchar(10)
AS
BEGIN
UPDATE Khach
SET makhach=@makhach, hoten=@hoten, namsinh=@namsinh, gioitinh=@gioitinh, sdt=@sdt , quequan=@quequan,  cmnd=@cmnd
WHERE makhach = @makhach 
END

GO

--------Update Phòng
CREATE PROC UpdateRoom
@maphong VARCHAR(10), @dientich INT, @loaiphong NVARCHAR(10), @tinhtrang NVARCHAR(20), @giaphong INT,@dodac NTEXT
AS
BEGIN
	UPDATE dbo.Phong SET	maphong=@maphong,dientich=@dientich, loaiphong=@loaiphong,tinhtrang=@tinhtrang,giaphong=@giaphong,dodac=@dodac
	WHERE maphong = @maphong

end
go

--------Update đăng ký khách
CREATE PROC	UpdateDangKyKhach
@mahp INT,@makhach VARCHAR(10), @maphong VARCHAR(10), @songuoi INT,  @ngaythue DATE, @ngaytra DATE, @datcoc INT, @htthanhtoan NVARCHAR(15)
AS
BEGIN
	UPDATE dbo.DangKyPhong SET makhach=@makhach, maphong=@maphong,songuoi= @songuoi,ngaythue=@ngaythue,ngaytra= @ngaytra,datcoc=@datcoc,htthanhtoan=@htthanhtoan
	WHERE mahdp=@mahp


END
go

------------------------------------------------------------------------------------------------Detele
go
---------------------------DeteLeDangKyPhong
CREATE PROC deleteDangKyPhong
@mahdp varchar(10)
AS
BEGIN
	DECLARE @maphong VARCHAR(10)
	SELECT @maphong=maphong FROM dbo.DangKyPhong WHERE mahdp=@mahdp
	UPDATE dbo.Phong SET tinhtrang=N'Trống' WHERE maphong=@maphong
	DELETE dbo.DangKyPhong WHERE mahdp=@mahdp
	--sau khi xóa đăng ký phòng thì trả lại trạng thái trống cho phòng

END
GO

---------------------------DetelePhong

CREATE PROC deletePhong
@maphong VARCHAR(10)
AS
BEGIN
	DECLARE @mahd INT
	SELECT @mahd=mahdp FROM dbo.DangKyPhong WHERE maphong=@maphong
	EXEC dbo.deleteDangKyPhong @mahdp=@mahd
	DELETE dbo.Phong WHERE maphong=@maphong
	
END
go

---------------------------DetelKhach

CREATE PROC deleteKhach
@makhach VARCHAR(10)
AS
BEGIN
	DECLARE @mahd INT
	SELECT @mahd=mahdp FROM dbo.DangKyPhong WHERE makhach=@makhach
	EXEC dbo.deleteDangKyPhong @mahdp=@mahd
	DELETE dbo.Khach WHERE makhach=@makhach
	
END
go


SELECT * FROM dbo.Khach
SELECT * FROM dbo.DangKyPhong
EXEC dbo.DangKyKhach @makhach = 'ms44', -- varchar(10)
    @hoten = N'long', -- nvarchar(50)
    @namsinh = 1992, -- int
    @gioitinh = 1, -- bit
    @cmnd = '3434', -- varchar(12)
    @quequan = N'ha noi', -- nvarchar(20)
    @sdt = '4342332' -- varchar(11)

GO

---Create proc Search 

CREATE	 PROC TimKiemKhach
@str nvarchar(50)
AS 
BEGIN
	DECLARE @chuoi NVARCHAR(100)
	SET @chuoi='%'+@str+N'%'
	SELECT * FROM  dbo.Khach WHERE hoten LIKE @chuoi
OR quequan LIKE @chuoi
OR makhach LIKE @chuoi
OR namsinh LIKE @chuoi
OR cmnd LIKE @chuoi
OR sdt LIKE @chuoi

END
go

--EXEC dbo.TimKiemKhach  @str = N'1989' -- nvarchar(50)


------------- tìm kiếm phòng
CREATE PROC TimKiemPhong
@str nvarchar(50)
AS 
BEGIN
	DECLARE @chuoi NVARCHAR(100)
	SET @chuoi='%'+@str+N'%'
	SELECT * FROM dbo.Phong WHERE maphong LIKE @chuoi
	OR dientich LIKE @chuoi
	OR loaiphong LIKE @chuoi
	OR tinhtrang LIKE @chuoi
	OR giaphong LIKE @chuoi

END
go
--EXEC TimKiemPhong @str=N'Đơn'

------------- tìm kiếm đăng ký phòng
CREATE PROC TimKiemdkp
@str nvarchar(50)
AS 
BEGIN
	DECLARE @chuoi NVARCHAR(100)
	SET @chuoi='%'+@str+N'%'
	SELECT * FROM dbo.DangKyPhong WHERE mahdp LIKE @chuoi
	OR	makhach LIKE @chuoi
	OR maphong LIKE @chuoi
	OR songuoi LIKE @chuoi
	OR songuoi LIKE @chuoi
	OR ngaythue LIKE @chuoi
	OR datcoc LIKE @chuoi
	OR ngaytra LIKE @chuoi
	OR htthanhtoan LIKE @chuoi

END
go




