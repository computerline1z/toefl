
--TRIGGER CHO BẢNG GOI_DIEM
IF OBJECT_ID('tgGoiDiem_ins', 'tr') IS NOT NULL
	DROP TRIGGER tgGoiDiem_ins
GO
CREATE TRIGGER tgGoiDiem_ins
ON GOI_DIEM 
FOR INSERT 
AS
BEGIN
		DECLARE @PhiGoiDiem SMALLMONEY 
		SELECT @PhiGoiDiem = PhiGoiDiem FROM THAM_SO
		
		UPDATE DANG_KY
		SET TongTienGoiDiem = TongTienGoiDiem + @PhiGoiDiem 
		FROM INSERTED i, DANG_KY dk
		WHERE i.MaDangKy = dk.MaDangKy
		
		IF @@ERROR <> 0
			RAISERROR(N'Lỗi update Tổng Tiền trong bảng DANG_KY', 16, 1)
		
	END 
END

IF OBJECT_ID('tgGoiDiem_del', 'tr') IS NOT NULL
	DROP TRIGGER tgGoiDiem_del
GO
CREATE TRIGGER tgGoiDiem_del
ON GOI_DIEM 
FOR DELETE 
AS
BEGIN
		DECLARE @PhiGoiDiem SMALLMONEY 
		SELECT @PhiGoiDiem = PhiGoiDiem FROM THAM_SO
		
		UPDATE DANG_KY
		SET TongTienGoiDiem = TongTienGoiDiem - @PhiGoiDiem 
		FROM DELETED d, DANG_KY dk
		WHERE d.MaDangKy = dk.MaDangKy
		
		IF @@ERROR <> 0
			RAISERROR(N'Lỗi update Tổng Tiền trong bảng DANG_KY', 16, 1)
		
END

IF OBJECT_ID('tgGoiDiem_upd', 'tr') IS NOT NULL
	DROP TRIGGER tgGoiDiem_upd
GO
CREATE TRIGGER tgGoiDiem_upd
ON GOI_DIEM 
FOR UPDATE 
AS
BEGIN
	IF UPDATE(MaDangKy) 
	IF EXISTS(SELECT * FROM INSERTED i, DELETED d WHERE i.MaDangKy <> d.MaDangKy)
	BEGIN 
		DECLARE @PhiGoiDiem SMALLMONEY 
		SELECT @PhiGoiDiem = PhiGoiDiem FROM THAM_SO
		
		UPDATE DANG_KY
		SET TongTienGoiDiem = TongTienGoiDiem + @PhiGoiDiem 
		FROM INSERTED i, DANG_KY dk
		WHERE i.MaDangKy = dk.MaDangKy
		
		IF @@ERROR <> 0
			RAISERROR(N'Lỗi update Tổng Tiền trong bảng DANG_KY', 16, 1)
		
		UPDATE DANG_KY
		SET TongTienGoiDiem = TongTienGoiDiem - @PhiGoiDiem 
		FROM DELETED d, DANG_KY dk
		WHERE d.MaDangKy = dk.MaDangKy
		
		IF @@ERROR <> 0
			RAISERROR(N'Lỗi update Tổng Tiền trong bảng DANG_KY', 16, 1)
	END 
END



--TRIGGER CHO BẢNG DANG_KY
IF OBJECT_ID('tgDangKy_ins_up', 'tr') IS NOT NULL
	DROP TRIGGER tgDangKy_ins_up
GO
CREATE TRIGGER tgDangKy_ins_up
ON DANG_KY
FOR INSERT, UPDATE 
AS
BEGIN
	IF UPDATE(LePhiThi) OR UPDATE(TongTienGoiDiem) OR UPDATE(TongTienThu)
		IF EXISTS(SELECT * FROM INSERTED i
			WHERE i.TongTienThu <> (i.LePhiThi + i.TongTienGoiDiem))
		BEGIN
			UPDATE DANG_KY
			SET TongTienThu = dk.LePhiThi + dk.TongTienGoiDiem
			FROM DANG_KY dk, INSERTED i
			WHERE dk.MaDangKy = i.MaDangKy
		END
	
	
END

