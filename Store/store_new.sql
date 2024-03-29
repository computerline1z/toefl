
--PHÁT SINH MÃ THÍ SINH
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
GO

--PHÁT SINH MÃ ĐĂNG KÝ
if object_id('spTaoMaDangKy', 'p') is not null
drop proc spTaoMaDangKy
go
create proc spTaoMaDangKy
	@ma varchar(10) out
as
begin
	select @ma = max(MaDangKy) from DANG_KY
	if(@ma is null)
		set @ma= 'DK000001'
	else
		set @ma = 'DK' + right('000000' + cast(((cast(right(@ma, 6) as int)) +1) as nvarchar(10)) ,6 )	
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
	exec spTaoMaThiSinh @mathisinh out
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

--declare @mathisinh varchar(10)
--exec spDangKyTaiKhoan 'tinyfoot8', 'emgalam4', 'nguyen', 'hue', 'nghi', 
--			'4/13/1987', '024212366', '213 Nguyễn Duy', 'tinyfoot@yahoo.com.vn',
--			'01/01/1999', @mathisinh out
--select @mathisinh
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
if object_id('spDangKyDuThi', 'p') is not null
drop proc spDangKyDuThi
go
create proc spDangKyDuThi
	@mathisinh varchar(10), @machitietdotthi int,
	@maloaithe int, @sothe varchar(20), @lephithi smallmoney,
	@sotienphat smallmoney, @tongtiengoidiem smallmoney, @tongtienthu smallmoney,
	@chuoimatruong varchar(200), @madangky varchar(10) out
as 
begin
	exec spTaoMaDangKy @madangky out

	declare @i int
	declare @matruong varchar(6)
	declare @phigoidiem smallmoney
	declare @sotruongtoidagoidiemmienphi int

	select @sotruongtoidagoidiemmienphi = sotruongtoidagoidiemmienphi from THAM_SO

	begin tran
		--insert vào bảng DANG_KY
		insert into DANG_KY
		values (@madangky, @mathisinh, @machitietdotthi, @maloaithe, @sothe, 
			@lephithi, @sotienphat, @tongtiengoidiem, @tongtienthu)
		
		IF @@ERROR <>0 
		BEGIN
			RAISERROR(N'Lỗi insert vào bảng DANG_KY', 16, 1)
			rollback tran
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
				RAISERROR(N'Lỗi insert vào bảng GOI_DIEM', 16, 1)
				rollback tran
				return
			END
	
			set @i = @i + 6
			set @matruong = substring(@chuoimatruong, @i, 6)
			continue	
		end
	commit tran
end

declare @madangky varchar(10)
exec  spDangKyDuThi 'TS00001', 1, 1, '123', 0, 0, 0, 0,'T00001T00002T00003T00004T00005T00005T00005'
			, @madangky out
select @madangky

----------------------------------------------------
-- XEM BẢNG ĐIỂM
----------------------------------------------------			
if object_id('spXemBangDiem', 'p') is not null
drop proc spXemBangDiem
go
create proc spXemBangDiem
	@madangky varchar(10)
as
begin
	select *
	from DANG_KY dk, KET_QUA_THI kq
	where dk.madangky = kq.madangky
end

--In bảng điểm của thí sinh trong 1 lần thi cụ thể
--input : @mathisinh, @ngaythi
--output : Bang diem
if object_id('spXemBangDiem2', 'p') is not null
drop proc spXemBangDiem2
go
create proc spXemBangDiem2
	@mathisinh varchar(10), @ngaythi datetime
as
begin
	declare @diemnghe int, @diemnoi int, @diemdoc int, @diemviet int
	select kq.*
	from DANG_KY dk, DOT_THI dt, CT_DOT_THI ctdt, KET_QUA_THI kq
	where datediff(d, dt.NgayThi, @ngaythi) = 0
	and ctdt.MaDotThi = dt.MaDotThi
	and dk.MaChiTietDotThi = ctdt.MaChiTietDotThi
	and dk.MaThiSinh = @mathisinh
	and dk.MaDangKy = kq.MaDangKy
end

--exec spXemBangDiem2 'TS00001', '2008-06-01 10:00:00.000'

--Xếp loại điểm theo phần thi
if object_id('spXepLoaiDiem', 'p') is not null
drop proc spXepLoaiDiem
go
create proc spXepLoaiDiem
	@phanthi nvarchar(20), @diem int
as
begin
	select TenMucDiem
	from MUC_DIEM
	where PhanThi = @phanthi
	and CanDuoi <= @diem
	and CanTren >= @diem
end

exec spXepLoaiDiem N'Nói', 11

--Lấy thông tin thí sinh khi biết mã thí sinh
if object_id('spLayThongTinThiSinh', 'p') is not null
drop proc spLayThongTinThiSinh
go
create proc spLayThongTinThiSinh
	@mathisinh varchar(10)
as
begin
	select *
	from THI_SINH
	where MaThiSinh = @mathisinh
end


--Lấy thông tin thí sinh khi biết mã đăng ký
if object_id('spLayThongTinThiSinhTheoMaDangKy', 'p') is not null
drop proc spLayThongTinThiSinhTheoMaDangKy
go
create proc spLayThongTinThiSinhTheoMaDangKy
	@madangky varchar(10)
as
begin
	select ts.*
	from DANG_KY dt, THI_SINH ts
	where dt.MaDangKy = @madangky
	and dt.MaThiSinh = ts.MaThiSinh
end

--exec spLayThongTinThiSinhTheoMaDangKy 'DK000001'

--Xác định mã đăng ký khi biết mã thí sinh và ngày thi
--input : @mathisinh, @ngaythi
--output : @madangky
if object_id('spLayMaDangKy', 'p') is not null
drop proc spLayMaDangKy
go
create proc spLayMaDangKy
	@mathisinh varchar(10), @ngaythi datetime, @madangky varchar(10) output
as
begin
	select @madangky = dk.MaDangKy 
	from DANG_KY dk, DOT_THI dt, CT_DOT_THI ctdt
	where dt.NgayThi = @ngaythi
	and ctdt.MaDotThi = dt.MaDotThi
	and dk.MaChiTietDotThi = ctdt.MaChiTietDotThi
	and dk.MaThiSinh = @mathisinh
end

----------------------------------------------------
-- THỐNG KÊ
----------------------------------------------------	
--Trong 1 tháng thông kê số lượng thí sinh dự thi theo từng địa điểm của từng quốc gia
--input : tháng năm
--output : bảng 
if object_id('spThongKeThiSinhTheoDiaDiem', 'p') is not null
drop proc spThongKeThiSinhTheoDiaDiem
go
create proc spThongKeThiSinhTheoDiaDiem
	@thangnam datetime
as
begin
	select dd.QuocGia, dd.TenDiaDiem, sum(ctdt.SoLuongDangKy) as SoLuongDangKy
	from DOT_THI dt, CT_DOT_THI ctdt, DIA_DIEM dd
	where datepart(month, dt.NgayThi) - datepart(month, @thangnam) = 0
	and datepart(year, dt.NgayThi) - datepart(year, @thangnam) = 0
	and dt.MaDotThi = ctdt.MaDotThi
	and dd.MaDiaDiem = ctdt.MaDiaDiem
	group by dd.QuocGia, dd.TenDiaDiem
end


--THỐNG KÊ ĐIỂM THI TRONG MỘT ĐỢT THI CỤ THỂ TẠI MỘT QUỐC GIA
if object_id('spThongKeDiem', 'p') is not null
	drop proc spThongKeDiem
go
create proc spThongKeDiem
	@ngaythi datetime, @quocgia nvarchar(20)
as
begin
	declare @Kq Table(PhanThi nvarchar(20), TenMucDiem varchar(20), 
				CanDuoi int, CanTren int, SoLuong int)
	insert into @Kq select PhanThi, TenMucDiem, CanDuoi, CanTren, 0
				from MUC_DIEM
	--select * from @Kq
	
	--Lay danh sach ket qua thi ung voi NgayThi va QuocGia
	declare @tDSKQ Table(DiemNghe int, DiemNoi int, DiemDoc int, DiemViet int)
	insert into @tDSKQ	select kq.DiemNghe, kq.DiemNoi, kq.DiemDoc, kq.DiemViet
				from DOT_THI dt, DIA_DIEM dd, CT_DOT_THI ctdt, DANG_KY dk, KET_QUA_THI kq
				where dt.NgayThi = @ngaythi
				and dd.QuocGia = @quocgia
				and dt.MaDotThi = ctdt.MaDotThi
				and dd.MaDiaDiem = ctdt.MaDiaDiem
				and ctdt. MaChiTietDotThi = dk.MaChiTietDotThi
				and dk.MaDangKy = kq.MaDangKy

	--Tao cursor tren bang @tDSKQ
	declare cur_DSKetQua cursor scroll
	for select * from @tDSKQ
	open cur_DSKetQua
	
	--Bien luu gia tri nghe, noi, doc, viet doc duoc tu cur_DSKetQua
	declare @diemnghe int, @diemnoi int, @diemdoc int, @diemviet int

	--Duyet cursor
	fetch next from cur_DSKetQua into @diemnghe, @diemnoi, @diemdoc, @diemviet
	while @@fetch_status = 0
	begin
		declare @TenMucDiem varchar(20)

		--NGHE
		select @TenMucDiem = TenMucDiem
		from @Kq 
		where PhanThi = N'Nghe'
		and CanDuoi <= @diemnghe
		and CanTren >= @diemnghe

		if @TenMucDiem is not null
		begin
			update @Kq
			set SoLuong = SoLuong + 1
			where PhanThi = N'Nghe'
			and TenMucDiem = @TenMucDiem
		end
		
		--NOI
		select @TenMucDiem = TenMucDiem
		from @Kq
		where PhanThi = N'Nói'
		and CanDuoi <= @diemnoi
		and CanTren >= @diemnoi

		if @TenMucDiem is not null
		begin
			update @Kq
			set SoLuong = SoLuong + 1
			where PhanThi = N'Nói'
			and TenMucDiem = @TenMucDiem
		end
		
		--DOC
		select @TenMucDiem = TenMucDiem
		from @Kq
		where PhanThi = N'Đọc'
		and CanDuoi <= @diemdoc
		and CanTren >= @diemdoc

		if @TenMucDiem is not null
		begin
			update @Kq
			set SoLuong = SoLuong + 1
			where PhanThi = N'Đọc'
			and TenMucDiem = @TenMucDiem
		end

		--VIET
		select @TenMucDiem = TenMucDiem
		from @Kq
		where PhanThi = N'Viết'
		and CanDuoi <= @diemviet
		and CanTren >= @diemviet

		if @TenMucDiem is not null
		begin
			update @Kq
			set SoLuong = SoLuong + 1
			where PhanThi = N'Viết'
			and TenMucDiem = @TenMucDiem
		end

		fetch next from cur_DSKetQua into @diemnghe, @diemnoi, @diemdoc, @diemviet	
	end
	
	select * from @Kq
	close cur_DSKetQua
	deallocate cur_DSKetQua
end
GO

exec spThongKeDiem '2008-06-01', 'Switzerland'

