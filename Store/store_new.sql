if object_id('spTaoMaThiSinh', 'p') is not null
drop proc spTaoMaThiSinh
go
create proc spTaoMaThiSinh
	@ma varchar(10) out
as
begin
	select @ma = max(MaThiSinh) from THI_SINH
	if(@ma is null)
		set @ma= 'TS00001'
	else
		set @ma = 'TS' + right('00000' + cast(((cast(right(@ma, 5) as int)) +1) as nvarchar(10)) ,5 )	
end

----------------------------------------------------
-- Đăng ký tài khoản thí sinh
----------------------------------------------------
if object_id('spDangKyTaiKhoan', 'p') is not null
drop proc spDangKyTaiKhoan
go
create proc spDangKyTaiKhoan
	@username varchar(30), @password varchar(30),
	@ho nvarchar(20), @tenlot nvarchar(20), @ten nvarchar(20),
	@ngaysinh datetime, @cmnd_pid varchar(20), @diachi nvarchar(50),
	@email varchar(50), @ngaythigannhat datetime, @mathisinh varchar(10) out
as
begin
	--begin tran
	declare @ma varchar(10)
	exec spTaoMaThiSinh @ma out
	
	set @mathisinh = @ma
	insert into THI_SINH values(@mathisinh, @username, @password, @ho, @tenlot, @ten, @ngaysinh, @cmnd_pid,
					@diachi, @email, @ngaythigannhat)
	
	IF @@ERROR <>0 -- vd lỗi 547, ai làm cái này thì tự xét kĩ hơn
	BEGIN
		RAISERROR(N'Lỗi insert vào bảng THI_SINH (sp_DangKyTaiKhoan)', 16, 1)
		--rollback tran
		return
	END
	--commit tran
end

declare @mathisinh varchar(10)
exec spDangKyTaiKhoan 'tinyfoot7', 'emgalam4', 'nguyen', 'hue', 'nghi', 
			'4/13/1987', '024212366', '213 Nguyễn Duy', 'tinyfoot@yahoo.com.vn',
			'01/01/1999', @mathisinh out
select @mathisinh
----------------------------------------------------
--ĐĂNG NHẬP
----------------------------------------------------
if object_id('spDangNhap', 'p') is not null
drop proc spDangNhap
go
create proc spDangNhap
	@username varchar(30), @password varchar(30)
as
begin
	select * 
	from THI_SINH 
	where Username = @username
	and Password = @password
end		

--exec spDangNhap 'tinyfoot2', 'emgalam2'


----------------------------------------------------
-- Ðang ký dự thi
----------------------------------------------------
if object_id('sp_DangKyDuThi', 'p') is not null
drop proc sp_DangKyDuThi
go
create proc sp_DangKyDuThi
	@madangky varchar(10), @mathisinh varchar(10), @machitietdotthi int,
	@maloaithe int, @sothe varchar(20), @chuoimatruong varchar(200)
as 
begin
	declare @i int
	declare @matruong varchar(6)
	declare @phigoidiem smallmoney
	declare @sotruongtoidagoidiemmienphi int

	select @sotruongtoidagoidiemmienphi = sotruongtoidagoidiemmienphi from THAM_SO

	--insert vào bảng DANG_KY
	insert into DANG_KY
	values (@madangky, @mathisinh, @machitietdotthi, @maloaithe, @sothe, null, null,null, null)
	IF @@ERROR <>0 
	BEGIN
		RAISERROR(N'Lỗi......', 16, 1)
		return
	END
	
	set @phigoidiem = 0
	set @i = 1
	set @matruong = substring(@chuoimatruong, @i, 6)
	while @matruong <> ''
	begin
		if @i = 6*@sotruongtoidagoidiemmienphi + 1 --truong thu 5
			select @phigoidiem = phigoidiem from THAM_SO

		insert into GOI_DIEM
		values (@madangky, @matruong, @phigoidiem)
		IF @@ERROR <> 0 
		BEGIN
			RAISERROR(N'Lỗi......', 16, 1)
			return
		END

		set @i = @i + 6
		set @matruong = substring(@chuoimatruong, @i, 6)
		continue	
	end

end

--exec  sp_DangKyDuThi 'DK01', 'TS00001', 1, 1, '123', 'T00001T00002T00003T00004T00005'

			

