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
	insert into THI_SINH values(@username, @password, @ho, @tenlot, @ten, @ngaysinh, @cmnd_pid,
					@diachi, @email, @ngaythigannhat)
	
	IF @@ERROR <>0 -- vd lỗi 547, ai làm cái này thì tự xét kĩ hơn
	BEGIN
		RAISERROR(N'Lỗi insert vào bảng THI_SINH (sp_DangKyTaiKhoan)', 16, 1)
		--rollback tran
		return
	END
	--commit tran
end

--exec spDangKyTaiKhoan 'TS00001', 'tinyfoot', 'emgalam', 'nguyen', 'hue', 'nghi', 
--			'4/13/1987', '024212366', '213 Nguyễn Duy', 'tinyfoot@yahoo.com.vn',
--			null
			
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

--exec spDangNhap 'tinyfoot', 'emgalam'

