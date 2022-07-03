use MYPHAM
go

--THỦ TỤC
--BẢNG SẢN PHẨM
--thêm sản phẩm
CREATE PROC INSERT_SP(@MaSP CHAR(10), @MaLoai CHAR(10), @Ma_voucher CHAR(10), @TenSP NVARCHAR(100), @GiaSP DECIMAL(18,0), @ThuongHieu NVARCHAR(100), @SlTon INT)
AS
BEGIN
	INSERT INTO San_Pham VALUES(@MaSP, @MaLoai, @Ma_voucher, @TenSP, @GiaSP, @ThuongHieu, @SlTon)
END
GO
--xóa sản phẩm
CREATE PROC DELETE_SP(@MaSP CHAR(10))
AS
BEGIN
	DELETE FROM San_Pham WHERE MaSP = @MaSP
END
GO
--update sản phẩm
CREATE PROC UPDATE_SP(@MaSP CHAR(10), @MaLoai CHAR(10), @Ma_voucher CHAR(10), @TenSP NVARCHAR(100), @GiaSP DECIMAL(18,0), @ThuongHieu NVARCHAR(100), @SlTon INT)
AS
BEGIN
	UPDATE San_Pham SET MaLoai = @MaLoai, Ma_voucher = @Ma_voucher, TenSP = @TenSP, GiaSP = @GiaSP, Hang_SX = @ThuongHieu, SLTon = @SlTon WHERE MaSP = @MaSP
END
GO
--update voucher
CREATE PROC UPDATE_MA_VOUCHER(@MAVOUCHER CHAR(10))
AS
BEGIN
	UPDATE San_Pham SET Ma_voucher = 'NO' WHERE Ma_voucher = @MAVOUCHER
END
GO


--BẢNG KHÁCH HÀNG
--thêm khách hàng
CREATE PROC INSERT_KH(@MAKH CHAR(10), @TENKH NVARCHAR(100), @GIOITINH NVARCHAR(10), @NGAYSINH DATE, @SDTKH CHAR(10), @DIACHIKH NVARCHAR(MAX))
AS
BEGIN
	INSERT INTO Khach_Hang VALUES(@MAKH, @TENKH, @GIOITINH, @NGAYSINH, @SDTKH, @DIACHIKH)
END
GO

--Xóa khách hàng
CREATE PROC  DELETE_KH(@MAKH CHAR(10))
AS
BEGIN
	DELETE FROM Khach_Hang WHERE MaKH = @MAKH
END
GO

--update khách hàng
CREATE PROC UPDATE_KH(@MAKH CHAR(10), @TENKH NVARCHAR(100), @GIOITINH NVARCHAR(10), @NGAYSINH DATE, @SDTKH CHAR(10), @DIACHIKH NVARCHAR(MAX))
AS
BEGIN
	UPDATE Khach_Hang SET TenKH = @TENKH, GioiTinh = @GIOITINH, Ngaysinh = @NGAYSINH, SDTKH = @SDTKH, DiachiKH = @DIACHIKH WHERE MaKH = @MAKH
END
GO


--LOẠI SẢN PHẨM
--thêm loại sản phẩm
CREATE PROC INSERT_LSP(@MALOAI CHAR(10), @TENLOAI NVARCHAR(50))
AS
BEGIN
	INSERT INTO Loai_San_Pham VALUES(@MALOAI, @TENLOAI)
END
GO

--Xóa loại sản phẩm
CREATE PROC  DELETE_LSP(@MALOAI CHAR(10))
AS
BEGIN
	DELETE FROM Loai_San_Pham WHERE MaLoai = @MALOAI
END
GO

--update loại sản phẩm
CREATE PROC UPDATE_LSP(@MALOAI CHAR(10), @TENLOAI NVARCHAR(50))
AS
BEGIN
	UPDATE Loai_San_Pham SET TenLoaiSP = @TENLOAI WHERE MaLoai = @MALOAI
END
GO


--VOUCHER
--thêm voucher
CREATE PROC INSERT_VOUCHER(@MAVOUCHER CHAR(10), @TENVOUCHER NVARCHAR(100), @GiatriKM DECIMAL(18,0))
AS
BEGIN
	INSERT INTO voucher VALUES(@MAVOUCHER, @TENVOUCHER, @GiatriKM)
END
GO

--Xóa voucher
CREATE PROC  DELETE_VOUCHER(@MAVOUCHER CHAR(10))
AS
BEGIN
	UPDATE San_Pham SET Ma_voucher = 'NO' WHERE Ma_voucher = @MAVOUCHER
	DELETE FROM voucher WHERE Ma_voucher = @MAVOUCHER
END
GO

--update voucher
CREATE PROC UPDATE_VOUCHER(@MAVOUCHER CHAR(10), @TENVOUCHER NVARCHAR(100), @GiatriKM DECIMAL(18,0))
AS
BEGIN
	UPDATE voucher SET Ten_voucher = @TENVOUCHER, GiatriKM = @GiatriKM WHERE Ma_voucher = @MAVOUCHER
END
GO



--HỘI VIÊN
--thêm hội viên
CREATE PROC INSERT_HV(@MAHV CHAR(10), @lOAITHE NVARCHAR(30), @TENHV NVARCHAR(100), @GIOITINH NVARCHAR(10), @NGAYSINH DATE, @NGAYLAPTHE DATE, @SDTHV CHAR(10))
AS
BEGIN
	 INSERT INTO Hoi_Vien VALUES(@MAHV, @lOAITHE, @TENHV, @GIOITINH, @NGAYSINH, @NGAYLAPTHE, @SDTHV)
END
GO

--xóa hội viên
CREATE PROC DELETE_HV(@MAHV CHAR(10))
AS
BEGIN
	DELETE FROM Hoi_Vien WHERE MaHV = @MAHV
END
GO

--sửa hội viên
CREATE PROC UPDATE_HV(@MAHV CHAR(10), @lOAITHE NVARCHAR(30), @TENHV NVARCHAR(100), @GIOITINH NVARCHAR(10), @NGAYSINH DATE, @NGAYLAPTHE DATE, @SDTHV CHAR(10))
AS
BEGIN
	UPDATE Hoi_Vien SET Loai_The = @lOAITHE, TenHV = @TENHV, GioiTinhHV = @GIOITINH, NgaysinhHV = @NGAYSINH, Ngay_lap_The = @NGAYLAPTHE, SDT_HV = @SDTHV WHERE  MaHV = @MAHV
END
GO


--TẢI KHOẢN
--thêm tài khoản
CREATE PROC INSERT_TK(@USERNAME CHAR(50), @PASS CHAR(50), @MANV CHAR(10), @MAQUYEN CHAR(10))
AS
BEGIN
	INSERT INTO Tai_Khoan VALUES(@USERNAME, @PASS, @MANV, @MAQUYEN)
END
GO
--sửa tài khoản
CREATE PROC UPDATE_TK(@USERNAME CHAR(50), @PASS CHAR(50), @MANV CHAR(10), @MAQUYEN CHAR(10))
AS
BEGIN
	UPDATE Tai_Khoan SET passwords = @PASS, MaNV = @MANV, MaPhanquyen = @MAQUYEN WHERE username = @USERNAME
END
GO
--xóa tài khoản
CREATE PROC DELETE_TK(@USERNAME CHAR(50))
AS
BEGIN
	DELETE FROM Tai_Khoan WHERE username = @USERNAME
END
GO

--THẺ HỘI VIÊN
--them thẻ
CREATE PROC INSERT_THV(@LOAITHE CHAR(50), @GIATHE DECIMAL(18,0), @TIENGIAM DECIMAL(18,0), @THOIGIANTHE INT)
AS
BEGIN
	INSERT INTO The_Hoi_Vien VALUES(@LOAITHE, @GIATHE, @TIENGIAM, @THOIGIANTHE)
END
GO
--cập nhật thẻ
CREATE PROC UPDATE_THV(@LOAITHE CHAR(50), @GIATHE DECIMAL(18,0), @TIENGIAM DECIMAL(18,0), @THOIGIANTHE INT)
AS
BEGIN
	UPDATE The_Hoi_Vien SET Gia_The = @GIATHE, Tien_Giam = @TIENGIAM, Thoi_Gian_The = @THOIGIANTHE WHERE Loai_The = @LOAITHE
END
GO
--xóa thẻ
CREATE PROC DELETE_THV(@LOAITHE CHAR(50))
AS
BEGIN
	DELETE FROM The_Hoi_Vien WHERE Loai_The = @LOAITHE
END
GO


--PHIẾU NHẬP HÀNG
--thêm phiếu nhập
CREATE PROC INSERT_PNH(@MaPhieu CHAR(10), @MaNV CHAR(10), @MaNCC CHAR(10), @Ngaylap DATE, @Tongtien DECIMAL(18,0))
AS
BEGIN
	INSERT INTO Phieu_Nhap_hang VALUES(@MaPhieu, @MaNV, @MaNCC, @Ngaylap, @Tongtien)
END
GO

--update phiếu nhập hàng
CREATE PROC UPDATE_PNH(@MaPhieu CHAR(10), @MaNV CHAR(10), @MaNCC CHAR(10), @Ngaylap DATE, @Tongtien DECIMAL(18,0))
AS
BEGIN
	UPDATE Phieu_Nhap_hang SET MaNV = @MaNV, MaNCC = @MaNCC, Ngaylap = @Ngaylap,Tongtien = @Tongtien WHERE MaPhieu = @MaPhieu
END
GO
--update tổng tiền
CREATE PROC UPDATE_TONGTIEN(@MaPhieu CHAR(10), @Tongtien DECIMAL(18,0))
AS
BEGIN
	UPDATE Phieu_Nhap_hang SET Tongtien = @Tongtien WHERE MaPhieu = @MaPhieu
END
GO
--xóa phiếu nhập
CREATE PROC DELETE_PNH(@MaPhieu CHAR(10))
AS
BEGIN
	DELETE FROM Phieu_Nhap_hang WHERE MaPhieu = @MaPhieu
END
GO


--CHI TIẾT PHIẾU NHẬP
--thêm phiếu
CREATE PROC INSERT_CTPN(@MaPhieu CHAR(10), @MaSP CHAR(10), @MaLoai CHAR(10), @Gia_Goc DECIMAL(18,0), @SLNhap INT, @Thanhtien DECIMAL(18,0))
AS
BEGIN
	INSERT INTO Chi_Tiet_Phieu_Nhap VALUES(@MaPhieu, @MaSP, @MaLoai, @Gia_Goc, @SLNhap, @Thanhtien)
END
GO
--update phiếu
CREATE PROC UPDATE_CTPN(@MaPhieu CHAR(10), @MaSP CHAR(10), @MaLoai CHAR(10), @Gia_Goc DECIMAL(18,0), @SLNhap INT, @Thanhtien DECIMAL(18,0))
AS
BEGIN
	UPDATE Chi_Tiet_Phieu_Nhap SET MaSP = @MaSP, MaLoai = @MaLoai, Gia_Goc = @Gia_Goc, SLNhap = @SLNhap, Thanhtien = @Thanhtien WHERE MaPhieu = @MaPhieu
END
GO
--xóa phiếu
CREATE PROC DELETE_CTPN(@MaPhieu CHAR(10))
AS
BEGIN
	DELETE FROM Chi_Tiet_Phieu_Nhap WHERE MaPhieu = @MaPhieu
END
GO


--NHÀ CUNG CẤP
--thêm nhà cung cấp
CREATE PROC INSERT_NCC(@MaNCC CHAR(10), @TenNCC NVARCHAR(100))
AS
BEGIN
	INSERT INTO Nha_cung_cap VALUES(@MaNCC, @TenNCC)
END
GO
--sửa nhà cung cấp
CREATE PROC UPDATE_NCC(@MaNCC CHAR(10), @TenNCC NVARCHAR(100))
AS
BEGIN
	UPDATE Nha_cung_cap SET MaNCC = @MaNCC, TenNCC = @TenNCC WHERE MaNCC = @MaNCC
END
GO
--xóa nhà cung cấp
CREATE PROC DELETE_NCC(@MaNCC CHAR(10))
AS
BEGIN
	DELETE FROM Nha_cung_cap WHERE MaNCC = @MaNCC
END
GO


--NHÂN VIÊN
--thêm nhân viên
CREATE PROC INSERT_NV(@MaNV CHAR(10), @HoTenNV NVARCHAR(100), @Ngaysinh DATE, @GioiTinhNV NVARCHAR(10), @Chucvu NVARCHAR(50), @SDTNV CHAR(10), @DiachiNV NVARCHAR(MAX), @LuongNV DECIMAL(10,0))
AS
BEGIN
	INSERT INTO Nhan_Vien VALUES(@MaNV, @HoTenNV, @Ngaysinh, @GioiTinhNV, @Chucvu, @SDTNV, @DiachiNV, @LuongNV)
END
GO
--sửa nhân viên
CREATE PROC UPDATE_NV(@MaNV CHAR(10), @HoTenNV NVARCHAR(100), @Ngaysinh DATE, @GioiTinhNV NVARCHAR(10), @Chucvu NVARCHAR(50), @SDTNV CHAR(10), @DiachiNV NVARCHAR(MAX), @LuongNV DECIMAL(10,0))
AS
BEGIN
	UPDATE Nhan_Vien SET HoTenNV = @HoTenNV, Ngaysinh = @Ngaysinh, GioiTinhNV = @GioiTinhNV, Chucvu = @Chucvu, SDTNV = @SDTNV, DiachiNV = @DiachiNV, LuongNV = @LuongNV WHERE MaNV = @MaNV
END
GO

--sửa chức vụ
CREATE PROC UPDATE_ChucvuNV(@MaNV CHAR(10), @Chucvu NVARCHAR(50))
AS
BEGIN
	UPDATE Nhan_Vien SET Chucvu = @Chucvu WHERE MaNV = @MaNV
END
GO
--xóa nhân viên
CREATE PROC DELETE_NV(@MaNV CHAR(10))
AS
BEGIN
	DELETE FROM Nhan_Vien WHERE MaNV = @MaNV
END
GO


--HÓA ĐƠN
--thêm hóa đơn khách hàng
CREATE PROC INSERT_HD_KH(@MaHD CHAR(10), @MaKH CHAR(10), @MaNV CHAR(10), @Ngay_lap_HD DATE, @Tongtien DECIMAL(18,0))
AS
BEGIN
	INSERT INTO Hoa_Don(MaHD,MaKH,MaNV,Ngay_lap_HD,Tongtien) VALUES(@MaHD, @MaKH, @MaNV, @Ngay_lap_HD, @Tongtien)
END
GO
--sửa hóa đơn
CREATE PROC UPDATE_HD(@MaHD CHAR(10), @MaKH CHAR(10), @MaNV CHAR(10), @MaHV INT, @Ngay_lap_HD DATE, @Tongtien DECIMAL(18,0))
AS
BEGIN
	UPDATE Hoa_Don SET MaKH = @MaKH, MaNV = @MaNV, MaHV = @MaHV, Ngay_lap_HD = @Ngay_lap_HD, Tongtien = @Tongtien WHERE MaHD = @MaHD
END
GO
--xóa hóa đơn
CREATE PROC DELETE_HD(@MaHD CHAR(10))
AS
BEGIN
	DELETE FROM Hoa_Don WHERE MaHD = @MaHD
END
GO

--Thêm hóa đơn hội viên
CREATE PROC INSERT_HD_HV(@MaHD CHAR(10), @MaNV CHAR(10), @MaHV INT, @Ngay_lap_HD DATE, @Tongtien DECIMAL(18,0))
AS
BEGIN
	INSERT INTO Hoa_Don(MaHD,MaNV,MaHV,Ngay_lap_HD,Tongtien) VALUES(@MaHD, @MaNV, @MaHV, @Ngay_lap_HD, @Tongtien)
END
GO


--CHI TIẾT HÓA ĐƠN
--thêm chi tiết hóa đơn
CREATE PROC INSERT_CTHD(@MaHD CHAR(10), @MaSP CHAR(10), @Ma_voucher NVARCHAR(50), @SLMua INT, @Thanhtien DECIMAL(18,0))
AS
BEGIN
	INSERT INTO Chi_Tiet_Hoa_Don VALUES(@MaHD, @MaSP, @Ma_voucher, @SLMua, @Thanhtien)
END
GO
--sửa chi tiết hóa đơn
CREATE PROC UPDATE_CTHD(@MaHD CHAR(10), @MaSP CHAR(10), @Ma_voucher NVARCHAR(50), @SLMua INT, @Thanhtien DECIMAL(18,0))
AS
BEGIN
	UPDATE Chi_Tiet_Hoa_Don SET MaSP = @MaSP, Ma_voucher = @Ma_voucher, SLMua = @SLMua, Thanhtien = @Thanhtien WHERE MaHD = @MaHD
END
GO
--xóa chi tiết hóa đơn
CREATE PROC DELETE_CTHD(@MaHD CHAR(10))
AS
BEGIN
	DELETE FROM Chi_Tiet_Hoa_Don WHERE MaHD = @MaHD
END
GO
drop procedure UPDATE_CTHD
--update voucher
CREATE PROC UPDATE_HD_VOUCHER(@Ma_voucher NVARCHAR(50))
AS
BEGIN
	UPDATE Chi_Tiet_Hoa_Don SET Ma_voucher = 'NO' WHERE Ma_voucher = @Ma_voucher
END
GO

--PHÂN QUYỀN
select * from Phan_Quyen
go
select MaPhanQuyen from Phan_Quyen where TenQuyen = N'Quản lý'
go
select TenQuyen from Phan_Quyen where MaPhanQuyen = 'Nhanvien'
go
select MaPhanQuyen from Phan_Quyen
go
select TenQuyen from Phan_Quyen
go

select Ma_voucher from voucher
go


--TRIGGER
--Trigger cập nhật số lượng sản phẩm sau khi nhập hàng
CREATE TRIGGER capnhatslton ON Chi_Tiet_Phieu_Nhap FOR INSERT
AS
BEGIN
	UPDATE San_Pham SET SLTon = SLTon + (SELECT SLNhap FROM inserted WHERE San_Pham.MaSP = MaSP)
	FROM San_Pham
	JOIN inserted ON San_Pham.MaSP = inserted.MaSP
END
GO

--Trigger cập nhật số lượng sản phẩm sau khi lập hóa đơn
CREATE TRIGGER capnhatsanpham ON Chi_Tiet_Hoa_Don FOR INSERT
AS
BEGIN
	UPDATE San_Pham SET SLTon = SLTon - (SELECT SLMua FROM inserted WHERE San_Pham.MaSP = MaSP)
	FROM San_Pham
	JOIN inserted ON San_Pham.MaSP = inserted.MaSP
END
GO


/*select a.MaHD, b.HoTenNV, c.TenKH, a.Ngay_lap_HD, a.Tongtien  from Hoa_Don a, Nhan_Vien b, Khach_Hang c where a.MaNV = b.MaNV and a.MaKH = c.MaKH
select * from San_Pham
select GiaSP from San_Pham where MaSP = 'SP11'
SELECT TOP 1 MaHD FROM Hoa_Don ORDER BY MaHD DESC 
select * from Hoa_Don

select b.Tien_Giam from Hoi_Vien a, The_Hoi_Vien b where a.Loai_The = b. Loai_The and a.MaHV = 1*/