

----------------------------------------------------
--ĐĂNG NHẬP
----------------------------------------------------
if object_id('sp_DangNhap', 'p') is not null
drop proc sp_DangNhap
go
create proc sp_DangNhap
	@username varchar(20), @password varchar(20), @mathisinh varchar(10) out
as
begin
	select @mathisinh = mathisinh from ACCOUNT 
			where username = @username
			and password = @password
end				

--declare @mathisinh varchar(20)
--exec sp_DangNhap 'nghi', 'nghi', @mathisinh out
--select @mathisinh


----------------------------------------------------
--Lấy thông tin thí sinh với mã thí sinh tương ứng
----------------------------------------------------
if object_id('sp_LayThongTinThiSinh', 'p') is not null
drop proc sp_LayThongTinThiSinh
go
create proc sp_LayThongTinThiSinh
	@mathisinh varchar(10)
as
begin
	select ho, tenlot, ten, ngaysinh, CMND, passportID, DiaChi, Email
	from THI_SINH
	where mathisinh = @mathisinh
end	

--exec sp_LayThongTinThiSinh '0003'			


----------------------------------------------------
-- Đăng ký tài khoản thí sinh
----------------------------------------------------
if object_id('sp_DangKyTaiKhoan', 'p') is not null
drop proc sp_DangKyTaiKhoan
go
create proc sp_DangKyTaiKhoan
	@mathisinh varchar(10), @ho nvarchar(20), @tenlot nvarchar(20), @ten nvarchar(20),
	@ngaysinh datetime, @cmnd nvarchar, @passportID nvarchar(10), @diachi nvarchar(30),
	@email nvarchar(30), @username nvarchar(20), @password nvarchar(20)
as
begin
	insert into THI_SINH values(@mathisinh, @ho, @tenlot, @ten, @ngaysinh, @cmnd, @passportID,
					@diachi, @email)
	IF @@ERROR <>0 -- vd lỗi 547, ai làm cái này thì tự xét kĩ hơn
	BEGIN
		RAISERROR(N'Lỗi...??...', 16, 1)
		ROLLBACK
		return
	END

	insert into ACCOUNT values(@mathisinh, @username, @password)
	if @@error <> 0
	begin
		RAISERROR(N'Lỗi...??...', 16, 1)
		ROLLBACK
		return
	end
end

--In bảng điểm của thí sinh trong 1 lần thi cụ thể
--input : @madangky
--output : Bang diem
if object_id('sp_LietKeBangDiem', 'p') is not null
drop proc sp_LietKeBangDiem
go
create proc sp_LietKeBangDiem
	@madangky varchar(10)
as
begin
	select diemnghe, diemnoi, diemdoc, diemviet 
	from DANG_KY dk, KET_QUA_THI kq
	where dk.madangky = kq.madangky
end

--Xác định mã đăng ký khi biết mã thí sinh và ngày thi
--input : @mathisinh, @ngaythi
--output : @madangky
if object_id('sp_LayMaDangKy', 'p') is not null
drop proc sp_LayMaDangKy
go
create proc sp_LayMaDangKy
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

--Trong 1 tháng thông kê số lượng thí sinh dự thi theo từng địa điểm của từng quốc gia
--input : tháng năm
--output : bảng 
if object_id('sp_ThongKeThiSinhTheoDiaDiem', 'p') is not null
drop proc sp_ThongKeThiSinhTheoDiaDiem
go
create proc sp_ThongKeThiSinhTheoDiaDiem
	@thang int, @nam int
as
begin
	select dd.QuocGia, dd.TenDiaDiem, sum(ctdt.SoLuongDangKy)
	from DOT_THI dt, CT_DOT_THI ctdt, DIA_DIEM dd
	where datepart(month, dt.NgayThi) - @thang = 0
	and datepart(year, dt.NgayThi) - @nam = 0
	and dt.MaDotThi = ctdt.MaDotThi
	and dd.MaDiaDiem = ctdt.MaDiaDiem
	group by dd.QuocGia, dd.TenDiaDiem
	
end


--THỐNG KÊ ĐIỂM THI TRONG MỘT ĐỢT THI CỤ THỂ TẠI MỘT QUỐC GIA
if object_id('fn_ThongKeDiem', 'IF') is not null
	drop function fn_ThongKeDiem
go
create function fn_ThongKeDiem(@ngaythi datetime, @quocgia nvarchar(20))
	returns @Kq Table(TenPhanThi nvarchar(10), TenMucDiem varchar(20), 
				CanDuoi int, CanTren int, SoLuong int)
as
begin
	
	insert into @Kq select 'nghe', TenMucDiem, CanDuoi, CanTren, 0
				from MUC_DIEM_NGHE
	insert into @Kq  select 'noi', TenMucDiem, CanDuoi, CanTren, 0
				from MUC_DIEM_NOI	
	insert into @Kq  select 'doc', TenMucDiem, CanDuoi, CanTren, 0
				from MUC_DIEM_DOC	
	insert into @Kq  select 'viet', TenMucDiem, CanDuoi, CanTren, 0
				from MUC_DIEM_VIET	
	
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
	declare cur_DSKetQua cursor scroll read_only
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
		from MUC_DIEM_NGHE
		where CanDuoi < @diemnghe
		and CanTren > @diemnghe

		if @TenMucDiem <> null
		begin
			update @Kq
			set SoLuong = SoLuong + 1
			where TenPhanThi = 'nghe'
			and TenMucDiem = @TenMucDiem
		end
		
		--NOI
		select @TenMucDiem = TenMucDiem
		from MUC_DIEM_NOI
		where CanDuoi < @diemnghe
		and CanTren > @diemnghe

		if @TenMucDiem <> null
		begin
			update @Kq
			set SoLuong = SoLuong + 1
			where TenPhanThi = 'noi'
			and TenMucDiem = @TenMucDiem
		end
		
		--DOC
		select @TenMucDiem = TenMucDiem
		from MUC_DIEM_DOC
		where CanDuoi < @diemnghe
		and CanTren > @diemnghe

		if @TenMucDiem <> null
		begin
			update @Kq
			set SoLuong = SoLuong + 1
			where TenPhanThi = 'doc'
			and TenMucDiem = @TenMucDiem
		end

		--VIET
		select @TenMucDiem = TenMucDiem
		from MUC_DIEM_VIET
		where CanDuoi < @diemnghe
		and CanTren > @diemnghe

		if @TenMucDiem <> null
		begin
			update @Kq
			set SoLuong = SoLuong + 1
			where TenPhanThi = 'viet'
			and TenMucDiem = @TenMucDiem
		end
		
	end
	
	return
end
go

select * from fn_ThongKeDiem('3/14/2008', 'vn')
