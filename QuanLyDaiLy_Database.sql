﻿CREATE DATABASE QuanLyDaiLy
GO
USE QuanLyDaiLy
GO

CREATE TABLE NhanVienQL(
	CMND VARCHAR(50) PRIMARY KEY NOT NULL,
	TenNV NVARCHAR(50) NOT NULL,
	NgaySinh DATE NOT NULL,
	QueQuan NVARCHAR(100) NOT NULL,
	SDT VARCHAR(50) NOT NULL
)
GO

CREATE TABLE ThongTinTaiKhoan(
	UserName VARCHAR(50) PRIMARY KEY NOT NULL,
	Pass VARCHAR(50) NOT NULL,
	CMND VARCHAR(50) NOT NULL,
	PhanQuyen INT DEFAULT 1 NOT NULL,--0 la  quyen Admin,1 la binh thuong
	TrangThai INT DEFAULT 0 NOT NULL,--0 binh thuong,1 bi block
	FOREIGN KEY (CMND) REFERENCES NhanVienQL(CMND)
)
GO
create table Quan(
	IdQuan int identity not null primary key,
	TenQuan nvarchar(50) not null
)
go
CREATE TABLE LoaiDaiLy(
	IdLoaiDL int IDENTITY PRIMARY KEY NOT NULL,
	TenLoaiDL NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE MatHang(
	IdMatHang INT identity PRIMARY KEY NOT NULL,
	TenMatHang NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE DaiLy(
	IdDaiLy INT IDENTITY PRIMARY KEY NOT NULL,
	TenDaiLy NVARCHAR(50) NOT NULL,
	SDT VARCHAR(50) NOT NULL,
	DiaChi NVARCHAR(100) NOT NULL,
	IdQuan int NOT NULL,
	NgayTiepNhan DATE NOT NULL,
	IdLoaiDL int NOT NULL,
	CMND VARCHAR(50) NOT NULL,
	TienNo float not null default 0,
	FOREIGN KEY (IdLoaiDL) REFERENCES LoaiDaiLy(IdLoaiDL),
	FOREIGN KEY (CMND) REFERENCES NhanVienQL(CMND),
	FOREIGN KEY (IdQuan) REFERENCES Quan(IdQuan)
)
GO

CREATE TABLE PhieuThuTien(
	IdPhieuThu INT IDENTITY PRIMARY KEY NOT NULL,
	NgayThu DATE NOT NULL,
	SoTienThu FLOAT NOT NULL,
	IdDaiLy INT NOT NULL,
	CMND VARCHAR(50) NOT NULL,
	FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(IdDaiLy),
	FOREIGN KEY (CMND) REFERENCES NhanVienQL(CMND)
)
GO
CREATE TABLE PhieuXuatHang(
	IdPhieuXuat INT IDENTITY PRIMARY KEY NOT NULL,
	NgayXuat DATE NOT NULL,
	IdDaiLy INT NOT NULL,
	CMND VARCHAR(50) NOT NULL,
	FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(IdDaiLy),
	FOREIGN KEY (CMND) REFERENCES NhanVienQL(CMND)
)
GO
CREATE TABLE ChiTietXuatHang(
	IdPhieuXuat INT NOT NULL,
	IdMatHang INT NOT NULL,
	SoLuong INT NOT NULL,
	DonGia float NOT NULL,
	DonViTinh NVARCHAR(20) NOT NULL,
	ThanhTien FLOAT NOT NULL,
	FOREIGN KEY (IdPhieuXuat) REFERENCES PhieuXuatHang(IdPhieuXuat),
	FOREIGN KEY (IdMatHang) REFERENCES MatHang(IdMatHang)
)
GO
CREATE TABLE CongNo(
	IdDaiLy INT NOT NULL,
	Thang int NOT NULL,
	NoDau FLOAT NOT NULL,
	NoCuoi FLOAT NOT NULL,
	PhatSinh FLOAT NOT NULL,
	FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(IdDaiLy)
)
GO
CREATE TABLE DoanhSo(
	IdDaiLy INT NOT NULL,
	Thang int NOT NULL,
	TongDoanhSo FLOAT NOT NULL,
	SoPhieuXuat INT NOT NULL,
	TyLe FLOAT NOT NULL,
	FOREIGN KEY (IdDaiLy) REFERENCES DaiLy(IdDaiLy)
)
GO
CREATE TABLE QuyDinhTienNo(
	IdLoaiDL int NOT NULL,
	TienNoToiDa float NOT NULL
	FOREIGN KEY (IdLoaiDL) REFERENCES LoaiDaiLy(IdLoaiDL)
)
GO

CREATE TABLE QuyDinhMatHang(
	IdMatHang int Not Null,
	DonViTinh nvarchar(50) Not null,
	DonGia float not null
	FOREIGN KEY (IdMatHang) REFERENCES MatHang(IdMatHang)
)
GO


CREATE TABLE QuyCheToChuc(
	SoLoaiDaiLy int NOT NULL,
	SoDaiLyToiDa int NOT NULL,
	SoMatHang int NOT NULL,
	SoQuan int NOT NULL
)
GO

----delete DaiLy-----
ALTER TABLE DaiLy WITH NOCHECK 
ADD CONSTRAINT FK_dl_ldl
FOREIGN KEY (IdLoaiDL) 
REFERENCES LoaiDaiLy (IdLoaiDL) 
ON DELETE CASCADE
go
ALTER TABLE DaiLy WITH NOCHECK 
ADD CONSTRAINT FK_dl_nv
FOREIGN KEY (CMND) 
REFERENCES NhanVienQL(CMND)
ON DELETE CASCADE
go
ALTER TABLE DaiLy WITH NOCHECK 
ADD CONSTRAINT FK_dl_q
FOREIGN KEY (IdQuan) 
REFERENCES Quan(IdQuan) 
ON DELETE CASCADE
go
-------delele ThongTinTK------------
ALTER TABLE ThongTinTaiKhoan WITH NOCHECK 
ADD CONSTRAINT FK_tk_nv
FOREIGN KEY (CMND) 
REFERENCES NhanVienQL(CMND) 
ON DELETE CASCADE
go
----------------PhieuThuTien-------------
ALTER TABLE PhieuThuTien WITH NOCHECK 
ADD CONSTRAINT FK_ptt_dl
FOREIGN KEY (IdDaiLy) 
REFERENCES DaiLy(IdDaiLy) 
ON DELETE CASCADE
go
--ALTER TABLE PhieuThuTien WITH NOCHECK 
--ADD CONSTRAINT FK_phieutt_nvql
--FOREIGN KEY (CMND) 
--REFERENCES NhanVienQL(CMND) 
--ON DELETE CASCADE
--go
---------------PhieuXuatHang----------------
ALTER TABLE PhieuXuatHang WITH NOCHECK 
ADD CONSTRAINT FK_xh_dl
FOREIGN KEY (IdDaiLy) 
REFERENCES DaiLy(IdDaiLy) 
ON DELETE CASCADE
go
--ALTER TABLE PhieuXuatHang WITH NOCHECK 
--ADD CONSTRAINT FK_xh_nv
--FOREIGN KEY (CMND) 
--REFERENCES NhanVienQL(CMND) 
--ON DELETE CASCADE
--go
-----------------ChiTietXuatHang---------------------
ALTER TABLE ChiTietXuatHang WITH NOCHECK 
ADD CONSTRAINT FK_ctx_px
FOREIGN KEY (IdPhieuXuat) 
REFERENCES PhieuXuatHang(IdPhieuXuat) 
ON DELETE CASCADE
go
ALTER TABLE ChiTietXuatHang WITH NOCHECK 
ADD CONSTRAINT FK_ctx_mh
FOREIGN KEY (IdMatHang) 
REFERENCES MatHang(IdMatHang) 
ON DELETE CASCADE
go
---------------CongNo------------------
ALTER TABLE CongNo WITH NOCHECK 
ADD CONSTRAINT FK_cn_dl
FOREIGN KEY (IdDaiLy) 
REFERENCES DaiLy(IdDaiLy)
ON DELETE CASCADE
go
-------------------------------
ALTER TABLE DoanhSo WITH NOCHECK 
ADD CONSTRAINT FK_ds_dl
FOREIGN KEY (IdDaiLy) 
REFERENCES DaiLy(IdDaiLy)
ON DELETE CASCADE
go
-----------QuyDinhTienNo----------------
ALTER TABLE QuyDinhTienNo WITH NOCHECK 
ADD CONSTRAINT FK_tn_ldl
FOREIGN KEY (IdLoaiDL) 
REFERENCES LoaiDaiLy(IdLoaiDL)
ON DELETE CASCADE
go
------------QuyDinhMatHang--------------
ALTER TABLE QuyDinhMatHang WITH NOCHECK 
ADD CONSTRAINT FK_mh_lmh
FOREIGN KEY (IdMatHang) 
REFERENCES MatHang(IdMatHang)
ON DELETE CASCADE
go
--------------------------
---------------CHEN DU LIEU------------

INSERT INTO NhanVienQL (CMND,TenNV,NgaySinh,QueQuan,SDT) VALUES ('225853403',N'NGUYỄN NHẬT LÂM','2000-02-22',N'Khánh Hòa','0339936377')
INSERT INTO NhanVienQL (CMND,TenNV,NgaySinh,QueQuan,SDT) VALUES ('312489024',N'NGUYỄN VÕ MINH KHANG','2000-09-05',N'Tiền Giang','0828599739')
INSERT INTO NhanVienQL (CMND,TenNV,NgaySinh,QueQuan,SDT) VALUES ('301687717',N'TRẦN CÔNG DANH','2000-06-01','Long An','0367773460')

INSERT INTO ThongTinTaiKhoan (UserName,Pass,CMND,PhanQuyen,TrangThai) VALUES ('NGUYENNHATLAM','22022000','225853403',0,0)
INSERT INTO ThongTinTaiKhoan (UserName,Pass,CMND,PhanQuyen,TrangThai) VALUES ('NGUYENVOMINHKHANG','05092000','312489024',0,0)
INSERT INTO ThongTinTaiKhoan (UserName,Pass,CMND,PhanQuyen,TrangThai) VALUES ('TRANCONGDANH','01062000','301687717',0,0)

insert into Quan (TenQuan) values (N'Quận Bình Thạnh')
insert into Quan (TenQuan) values (N'Quận 9')
insert into Quan (TenQuan) values (N'Quận Thủ Đức')

insert into LoaiDaiLy(TenLoaiDL) values (N'Loại 1')
insert into LoaiDaiLy(TenLoaiDL) values (N'Loại 2')

insert into DaiLy (TenDaiLy,SDT,DiaChi,IdQuan,NgayTiepNhan,IdLoaiDL,CMND) values (N'Đại Lý A Tứ','09891234',N'abc,Quận Bình Thạnh,HCM',1,'2020-12-25',1,'225853403')
insert into DaiLy (TenDaiLy,SDT,DiaChi,IdQuan,NgayTiepNhan,IdLoaiDL,CMND) values (N'Đại Lý B Tứ','01215677',N'xyz,Quận 9,HCM',2,'2021-1-4',1,'312489024')
insert into DaiLy (TenDaiLy,SDT,DiaChi,IdQuan,NgayTiepNhan,IdLoaiDL,CMND) values (N'Đại Lý C Tứ','09777888',N'kkk,Quận Thủ Đức,HCM',3,'2021-1-5',2,'301687717')

insert into MatHang(TenMatHang) values (N'Nước suối Aquavina')
insert into MatHang(TenMatHang) values (N'Nước suối Lavi')
insert into MatHang(TenMatHang) values (N'Bia Tiger')
insert into MatHang(TenMatHang) values (N'Bia 333')
insert into MatHang(TenMatHang) values (N'Bia Heneken')
insert into MatHang(TenMatHang) values (N'Cocacola')
insert into MatHang(TenMatHang) values (N'7up')
insert into MatHang(TenMatHang) values (N'Nước cam vắt')
insert into MatHang(TenMatHang) values (N'Nước Nha Đam')
insert into MatHang(TenMatHang) values (N'Sting')


insert into PhieuXuatHang(NgayXuat,IdDaiLy,CMND) values ('2020-12-31',1,'225853403')
insert into PhieuXuatHang(NgayXuat,IdDaiLy,CMND) values ('2021-1-5',2,'312489024')
insert into PhieuXuatHang(NgayXuat,IdDaiLy,CMND) values ('2021-1-6',3,'301687717')

insert into ChiTietXuatHang(IdPhieuXuat,IdMatHang,SoLuong,DonGia,DonViTinh,ThanhTien) values (1,1,20,5000,N'Chai',100000)
insert into ChiTietXuatHang(IdPhieuXuat,IdMatHang,SoLuong,DonGia,DonViTinh,ThanhTien) values (2,3,20,15000,N'Lon',300000)
insert into ChiTietXuatHang(IdPhieuXuat,IdMatHang,SoLuong,DonGia,DonViTinh,ThanhTien) values (3,4,10,15000,N'Lon',150000)
insert into ChiTietXuatHang(IdPhieuXuat,IdMatHang,SoLuong,DonGia,DonViTinh,ThanhTien) values (2,6,20,10000,N'Lon',200000)



insert into PhieuThuTien(NgayThu,SoTienThu,IdDaiLy,CMND) values ('2020-12-30',100000,1,'225853403')
insert into PhieuThuTien(NgayThu,SoTienThu,IdDaiLy,CMND) values ('2020-12-22',300000,2,'312489024')
insert into PhieuThuTien(NgayThu,SoTienThu,IdDaiLy,CMND) values ('2021-1-8',600000,3,'301687717')
insert into PhieuThuTien (NgayThu,SoTienThu,IdDaiLy,CMND) values ('2021-1-7',30000,1,'225853403')
insert into PhieuThuTien (NgayThu,SoTienThu,IdDaiLy,CMND) values ('2021-1-10',900000,2,'312489024')

insert into CongNo(IdDaiLy,Thang,NoDau,NoCuoi,PhatSinh) values (1,12,0,0,0)
insert into CongNo(IdDaiLy,Thang,NoDau,NoCuoi,PhatSinh) values (2,1,0,0,0)
insert into CongNo(IdDaiLy,Thang,NoDau,NoCuoi,PhatSinh) values (3,1,0,0,0)

insert into DoanhSo(IdDaiLy,Thang,TongDoanhSo,SoPhieuXuat,TyLe) values (1,12,130000,1,33)
insert into DoanhSo(IdDaiLy,Thang,TongDoanhSo,SoPhieuXuat,TyLe) values (2,1,1200000,1,33)
insert into DoanhSo(IdDaiLy,Thang,TongDoanhSo,SoPhieuXuat,TyLe) values (3,1,600000,1,33)
-----CÁC QUY ĐỊNH ---------------------
insert into QuyDinhTienNo values (1,50000)
insert into QuyDinhTienNo values (2,50000)

insert into QuyDinhMatHang values (1,N'Chai',5000)
insert into QuyDinhMatHang values (2,N'Chai',5000)
insert into QuyDinhMatHang values (3,N'Lon',15000)
insert into QuyDinhMatHang values (4,N'Lon',15000)
insert into QuyDinhMatHang values (5,N'Lon',18000)
insert into QuyDinhMatHang values (6,N'Lon',10000)
insert into QuyDinhMatHang values (7,N'Lon',10000)
insert into QuyDinhMatHang values (8,N'Chai',10000)
insert into QuyDinhMatHang values (9,N'Chai',12000)
insert into QuyDinhMatHang values (10,N'Lon',10000)

insert QuyCheToChuc values (2,4,5,20)
-------------------------------------------------------------------------------------------

-------------------------------------------------------------------------------------------------
--LOGIN AND REGISTER USER
create PROCEDURE PR_CheckLogin --0 cho phep dang nhap ,1 SAI USER,2 SAI PASS,3 BI BLOCK
@UserName VARCHAR(50),
@Pass VARCHAR(50),
@out int out
AS 
BEGIN
	DECLARE @KtUserName INT
	DECLARE @KtPass INT
	DECLARE @KtTrangThai INT
	SELECT @KtUserName = COUNT(UserName) FROM ThongTinTaiKhoan WHERE UserName=@UserName
	SELECT @KtTrangThai=TrangThai FROM ThongTinTaiKhoan WHERE UserName=@UserName AND TrangThai=0
	IF @KtUserName=0
	BEGIN
		set @out=1	
	END
	ELSE
	BEGIN
		SELECT @KtPass=COUNT(UserName) FROM ThongTinTaiKhoan WHERE Pass=@Pass
		IF @KtPass=0
		BEGIN
			set @out=2
		END
		ELSE
		BEGIN
		SELECT @KtTrangThai=TrangThai FROM ThongTinTaiKhoan WHERE UserName=@UserName
			IF @KtTrangThai=0
			BEGIN
				set @out=0
			END
			ELSE
			BEGIN 
				set @out=3
			END
		END
	END
END
GO
create proc PR_DangKi  ---- 0 dangki thanh cong, 1 trung user,2 nhan vien da co tai khoan,3 loi 
@CMND varchar(50),
@TenNV nvarchar(50),
@NgaySinh date,
@QueQuan nvarchar(100),
@SDT varchar(50),
@UserName varchar(50),
@Pass varchar(50),
@PhanQuyen int,
@TrangThai int,
@result int out
as
begin
	declare @ktcmnd int 
	declare @ktuser int
	select @ktuser =count(UserName) from ThongTinTaiKhoan where UserName=@UserName
	if @ktuser>0
	begin
		set @result=1
		return
	end
	else 
	begin
	select @ktcmnd =count(CMND) from NhanVienQL where CMND=@CMND
		if @ktcmnd>0
		begin
			set @result=2
			return
		end
	end
	begin try
		begin transaction dk
		insert into NhanVienQL (CMND,TenNV,NgaySinh,QueQuan,SDT) values (@CMND,@TenNV,@NgaySinh,@QueQuan,@SDT)
		insert into ThongTinTaiKhoan(UserName,Pass,CMND,PhanQuyen,TrangThai) values (@UserName,@Pass,@CMND,@PhanQuyen,@TrangThai)
		commit transaction dk	
		set @result=0
	end try
	begin catch
		set @result=3
		rollback transaction dk
	end catch
end
--declare @rs int
--EXEC PR_DangKi '123',N'haha','2000-02-22','hcm','123','NGUYENNHATLAM','lam123',0,0,@rs out
--print @rs
--go
create proc PR_UpdatePass
@passCu varchar(50),@passMoi varchar(50),@userName varchar(50),@out int out
as
begin
	declare @ktPassCu int
	select @ktPassCu=count(UserName) from ThongTinTaiKhoan where UserName=@userName and Pass=@passCu
	if(@ktPassCu>0)
	begin
		update ThongTinTaiKhoan set Pass=@passMoi where UserName=@userName
		set @out=1
	end
	else
	begin
		set @out=2
	end
end
go


------------------------------------------------------------------------------------
--LOẠI ĐẠI LÝ
create proc PR_InsertLoaiDaiLy
@TenLoaiDL nvarchar(50),
@out int out 
as
begin
	declare @ktTen int
	declare @slLoaiDL int
	declare @quyDinhSoLoaiDL int
	select @ktTen=count(TenLoaiDL) from LoaiDaiLy where TenLoaiDL=@TenLoaiDL
	select @slLoaiDL=count(IdLoaiDL) from LoaiDaiLy 
	select @quyDinhSoLoaiDL=SoLoaiDaiLy from QuyCheToChuc

	if @ktTen=0
	begin
		if(@slLoaiDL<@quyDinhSoLoaiDL)
		begin
			insert into LoaiDaiLy (TenLoaiDL) values (@TenLoaiDL)
			set @out=1
		end
		else
		begin 
			set @out=2
		end	
	end
	else
	begin
		set @out=3
	end
end
go
-----------------------------------------------------------------
--Thêm nhân viên
create proc PR_ThemNhanVien
@CMND VARCHAR(50),@TenNV NVARCHAR(50),@NgaySinh DATE,@QueQuan NVARCHAR(100),@SDT VARCHAR(50),@out int out
as
begin
	declare @ktCmnd int 
	select @ktCmnd=count(CMND) from NhanVienQL where CMND=@CMND
	if(@ktCmnd=0)
	begin
		INSERT INTO NhanVienQL (CMND,TenNV,NgaySinh,QueQuan,SDT) VALUES (@CMND,@TenNV,@NgaySinh,@QueQuan,@SDT)
		set @out =1
	end
	else
	begin
		set @out=2
	end
end
------------------------------------------------------------------------------------
--TIẾP NHẬN ĐẠI LÝ 
create PROC PR_InsertDl --0 thêm thành công ,1 tên đại lý tồn tại,2 lỗi thêm
@TenDL nvarchar(50),@SDT varchar(50),@DiaChi nvarchar(50),@IdQuan int,@NgayTiepNhan date,
@IdLoaiDL int,@CMND varchar(50),@out int out
as
begin
	declare @ktTenDL int
	declare @soDaiLyQuyDinh int
	declare @soDaiLyTrongQuan int
	select @ktTenDL=count(TenDaiLy) from DaiLy where TenDaiLy=@TenDL
	select @soDaiLyQuyDinh=SoQuan from QuyCheToChuc
	select @soDaiLyTrongQuan=count(IdDaiLy) from DaiLy where IdQuan=@IdQuan
	if @ktTenDL=0
	begin
		if(@soDaiLyTrongQuan<@soDaiLyQuyDinh)
		begin
			insert into DaiLy (TenDaiLy,SDT,DiaChi,IdQuan,NgayTiepNhan,IdLoaiDL,CMND) values (@TenDL,@SDT,@DiaChi,@IdQuan,
			@NgayTiepNhan,@IdLoaiDL,@CMND)
			set @out=1
		end
		else
		begin
			set @out=2
		end
	end
	else 
	begin
		set @out=3
	end
end
go
create PROC PR_UpdateDL
@IdDaiLy int,@TenDaiLy nvarchar(50),@SDT varchar(50),@DiaChi nvarchar(100),@IdQuan int,
@NgayTiepNhan date,@IdLoaiDL int,@CMND varchar(50),@TienNo float,@out int out
as
begin
	declare @tienNoQuyDinh float
	declare @soDaiLyTrongQuan int
	declare @soDaiLyQuyDinh int
	--select @tienNoQuyDinh=TienNoToiDa from QuyDinhTienNo where IdLoaiDL=@IdLoaiDL
	select @soDaiLyTrongQuan=count(IdDaiLy) from DaiLy where IdQuan=@IdQuan
	select @soDaiLyQuyDinh =SoDaiLyToiDa from QuyCheToChuc 

	if(@soDaiLyTrongQuan<=@soDaiLyQuyDinh)
	begin 
		--if(@TienNo<=@tienNoQuyDinh)
		--begin
			UPDATE DaiLy SET TenDaiLy=@TenDaiLy,SDT =@SDT,DiaChi=@DiaChi,NgayTiepNhan=@NgayTiepNhan,
			IdLoaiDL=@IdLoaiDL,CMND=@CMND,IdQuan=@IdQuan WHERE IdDaiLy=@IdDaiLy
			set @out=1
		--end
		--else
		--begin
		--set @out= 2
		--end
	end
	else
	begin
		set @out=3
	end
	
end
go

create proc PR_UpdateTienNo
@idDL int,@tienNo int,@out int out
as 
begin
	declare @tienNoQD float
	declare @loaiDL int
	declare @tienNoDLHT float
	declare @rs int
	select @loaiDL=IdLoaiDL from DaiLy where IdDaiLy=@idDL
	select @tienNoQD=TienNoToiDa from QuyDinhTienNo where IdLoaiDL=@loaiDL
	if @tienNo<@tienNoQD
	begin
		update DaiLy set TienNo=@tienNo where IdDaiLy=@idDL
		set @out=1 
	end
	else
	begin
		set @out = 2
	end
end
go
--select * from ChiTietXuatHang
--declare @r int
--exec PR_UpdateTienNo 1,15000,@r out
--select TienNo from DaiLy where IdDaiLy=1
--------------------------------------------------------------------------------------
--MẶT HÀNG
create proc PR_InsertMatHang
@TenMatHang nvarchar(50),
@Out int Out
as
begin
	declare @ktTen int
	declare @soLuongMHQuyDinh int
	declare @soLuongMatHang int
	select @ktTen=count(TenMatHang) from MatHang where TenMatHang=@TenMatHang
	select @soLuongMHQuyDinh= SoMatHang from QuyCheToChuc
	select @soLuongMatHang=count(IdMatHang) from MatHang
	if @ktTen=0
	begin
		if @soLuongMatHang<@soLuongMHQuyDinh
		begin
			insert into MatHang (TenMatHang) values (@TenMatHang)
			set @Out=1
		end
		else
		begin
			set @Out=2
		end
	end
	else
	begin
		set @Out=3
	end
end
go

------------------------------------------------------
-----Quận
create proc PR_InsertQuan
@TenQuan nvarchar(50) ,
@out int out
as
begin
	declare @ktTen int
	declare @quyDinhSLQuan int
	declare @soLuongQuan int 
	select @ktTen=count(TenQuan) from Quan where TenQuan=@TenQuan
	select @quyDinhSLQuan=SoQuan from QuyCheToChuc
	select @soLuongQuan=count(IdQuan) from Quan
	if @ktTen=0
	begin
		if(@soLuongQuan<@quyDinhSLQuan)
		begin 
			insert into Quan (TenQuan) values (@TenQuan)
			set @out= 1
		end
		else
		begin
			set @out= 2
		end
	end
	else
	begin
		set @out= 3
	end
end
go
---------------------------------------------

----Phiếu xuất
create proc PR_InsertPhieuXuat
@NgayXuat DATE,@IdDaiLy INT,@CMND VARCHAR(50),
@out int out
as
begin
	insert into PhieuXuatHang(NgayXuat,IdDaiLy,CMND) values (@NgayXuat,@IdDaiLy,@CMND)
	declare @rs int
	select top 1 @rs=IdPhieuXuat from PhieuXuatHang order by IdPhieuXuat DESC
	set @out =@rs
end
go


---Chi tiết xuất

--------------------------------------------------------------------------------------
--BÁO CÁO DOANH SỐ (ngày 1/1/2021)
--tính tổng tiền trong tháng
create function FN_TongTienTrongThang(@thang int)
returns float
as
begin
	declare @tongTien float
	select @tongtien=sum(SoTienThu) from PhieuThuTien where MONTH(NgayThu)=@thang
	if(@tongTien=0)
		return 1
	return @tongtien
end
go
--tỷ lệ
create function FN_TyLeTrongThang(@idDL int,@thang int)
returns float
as
begin
	declare @tyle float
	select @tyle=sum(SoTienThu)*100/dbo.FN_TongTienTrongThang(@thang)
	from PhieuThuTien 
	where IdDaiLy=@idDL and MONTH(NgayThu)=@thang
	group by IdDaiLy
	return @tyle
end
go
--báo cáo
create proc PR_BaoCaoDoanhSo
@Thang int
as
begin
	select T.IdDaiLy as idDL, sum(SoTienThu) as TongTien,count(IdPhieuThu) as SoPhieuXuat,
	dbo.FN_TyLeTrongThang(T.IdDaiLy,MONTH(T.NgayThu)) as tyle,MONTH(T.NgayThu) as Thang 
	 from PhieuThuTien T,PhieuXuatHang H 
	 where T.IdDaiLy=H.IdDaiLy and MONTH(T.NgayThu)=@Thang
	 group by T.IdDaiLy,MONTH(T.NgayThu)

end
go
--------------------------------------------------------------------------------------
--BÁO CÁO CÔNG NỢ
create function FN_NoDau(@thang int,@id int)
returns float
as
begin
	declare @tienNo float
	set @tienNo=0
	select top 1 @tienNo= D.TienNo from DaiLy D,PhieuThuTien P
	where D.IdDaiLy=P.IdDaiLy and MONTH(P.NgayThu)=@Thang-1
	order by DAY(P.NgayThu) DESC
	return @tienNo
end
go

create function FN_NoCuoi(@thang int,@id int)
returns float
as
begin
	declare @tienNo float
	set @tienNo=0
	select top 1 @tienNo= D.TienNo from DaiLy D,PhieuThuTien P
	where D.IdDaiLy=P.IdDaiLy and MONTH(P.NgayThu)=@Thang
	order by DAY(P.NgayThu) ASC
	return @tienNo
end
go

create proc PR_BaoCaoCongNo
@Thang int
as
begin
	select P.IdDaiLy as IdDL,@Thang as Thang,dbo.FN_NoDau(@Thang,P.IdDaiLy) as NoDau,dbo.FN_NoCuoi(@thang,P.IdDaiLy) as NoCuoi
	from PhieuThuTien P,DaiLy D
	where P.IdDaiLy=D.IdDaiLy and MONTH(P.NgayThu)=@Thang
	group by P.IdDaiLy
end
go


select * from ThongTinTaiKhoan