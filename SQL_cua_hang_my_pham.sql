﻿USE master
GO

IF(EXISTS(SELECT name FROM master.sys.databases WHERE name='MYPHAM'))
DROP DATABASE MYPHAM
GO

CREATE DATABASE MYPHAM
GO

USE MYPHAM
GO

CREATE TABLE San_Pham(--bảng sản phẩm
	MaSP CHAR(10) NOT NULL,--id sản phẩm
	MaLoai CHAR(10) NOT NULL,--id loại sản phẩm, khóa ngoại
	Ma_voucher CHAR(10),--mã voucher, khóa ngoại
	TenSP NVARCHAR(100) NOT NULL,
	GiaSP DECIMAL(18,0) NOT NULL,
	Hang_SX NVARCHAR(100) NOT NULL,
	SLTon INT NOT NULL,--số lượng tồn
	CONSTRAINT PK_PRODUCT PRIMARY KEY (MaSP))
	GO

CREATE TABLE Khach_Hang(--bảng khách hàng
	MaKH CHAR(10) NOT NULL,--mã khách
	TenKH NVARCHAR(100) NOT NULL,--tên khách
	GioiTinh NVARCHAR(10) NOT NULL,
	Ngaysinh DATE NOT NULL,
	SDTKH CHAR(10) NOT NULL,
	DiachiKH NVARCHAR(MAX) NOT NULL,
	CONSTRAINT PK_CUSTOMER PRIMARY KEY (MaKH))
	GO

	--bảng loại sản phẩm
CREATE TABLE Loai_San_Pham(
	MaLoai CHAR(10) NOT NULL,
	TenLoaiSP NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_PRODUCT_SORT PRIMARY KEY (MaLoai))
	GO

	--bảng voucher
CREATE TABLE voucher(
	Ma_voucher CHAR(10) NOT NULL,
	Ten_voucher NVARCHAR(100) NOT NULL,
	GiatriKM DECIMAL(18,0) NOT NULL,
	CONSTRAINT PK_VOUCHER PRIMARY KEY (Ma_voucher))
	GO

	--bảng hội viên
CREATE TABLE Hoi_Vien(
	MaHV INT NOT NULL,
	Loai_The NVARCHAR(50) NOT NULL,
	TenHV NVARCHAR(100) NOT NULL,
	GioiTinhHV NVARCHAR(10) NOT NULL,
	NgaysinhHV DATE NOT NULL,
	Ngay_lap_The DATE NOT NULL,--ngày lập thẻ
	SDT_HV CHAR(10) NOT NULL,
	CONSTRAINT PK_MEMBER PRIMARY KEY (MaHV))
	GO

	--bảng thẻ hội viên
CREATE TABLE The_Hoi_Vien(
	Loai_The NVARCHAR(50) NOT NULL,--loại thẻ
	Gia_The DECIMAL(18,0) NOT NULL,
	Tien_Giam DECIMAL(18,0) NOT NULL,
	Thoi_Gian_The INT NOT NULL,
	CONSTRAINT PK_CARD PRIMARY KEY (Loai_The))
	GO

	--bảng phiếu nhập
CREATE TABLE Phieu_Nhap_hang(
	MaPhieu CHAR(10) NOT NULL,
	MaNV CHAR(10) NOT NULL,--mã nhân viên
	MaNCC CHAR(10) NOT NULL,
	Ngaylap DATE NOT NULL,--YYYY-MM-DD
	Tongtien DECIMAL(18,0),
	CONSTRAINT PK_IMPORT_PAPER PRIMARY KEY (MaPhieu))
	GO

	--bảng chi tiết phiếu nhập
CREATE TABLE Chi_Tiet_Phieu_Nhap(
	MaPhieu CHAR(10) NOT NULL,
	MaSP CHAR(10) NOT NULL,
	MaLoai CHAR(10) NOT NULL,
	Gia_Goc DECIMAL(18,0) NOT NULL,--giá gốc
	SLNhap INT NOT NULL,--số lượng nhập
	Thanhtien DECIMAL(18,0) ,
	CONSTRAINT PK_DETAILS_PAPER PRIMARY KEY (MaPhieu,MaSP))
	GO

	--bảng nhà cung cấp
CREATE TABLE Nha_cung_cap(
	MaNCC CHAR(10) NOT NULL,
	TenNCC NVARCHAR(100) NOT NULL,
	CONSTRAINT PK_SUPPLIER PRIMARY KEY (MaNCC))
	GO

	--bảng nhân viên
CREATE TABLE Nhan_Vien(
	MaNV CHAR(10) NOT NULL,
	HoTenNV NVARCHAR(100) NOT NULL,
	Ngaysinh DATE NOT NULL,
	GioiTinhNV NVARCHAR(10) NOT NULL,
	Chucvu NVARCHAR(50) NOT NULL,--chức vụ
	SDTNV CHAR(10) NOT NULL,
	DiachiNV NVARCHAR(MAX) NOT NULL,
	LuongNV DECIMAL(10,0) NOT NULL,--lương
	CONSTRAINT PK_STAFF PRIMARY KEY (MaNV))
	GO

	--bảng hóa đơn
CREATE TABLE Hoa_Don(
	MaHD CHAR(10) NOT NULL,
	MaKH CHAR(10) NULL,
	MaNV CHAR(10) NOT NULL,
	MaHV INT NULL,
	Ngay_lap_HD DATE NOT NULL,
	Tongtien DECIMAL(18,0),
	CONSTRAINT PK_BILL PRIMARY KEY (MaHD))
	GO

	--bảng chi tiết hóa đơn
CREATE TABLE Chi_Tiet_Hoa_Don(
	MaHD CHAR(10) NOT NULL,
	MaSP CHAR(10) NOT NULL,
	Ma_voucher NVARCHAR(50) NOT NULL,
	SLMua INT NOT NULL,
	Thanhtien DECIMAL(18,0),
	CONSTRAINT PK_DETAILS_BILL PRIMARY KEY (MaHD,MaSP))
	GO

	--bảng tài khoản
CREATE TABLE Tai_Khoan(
	username CHAR(50) NOT NULL,
	passwords CHAR(50) NOT NULL,
	MaNV CHAR(10) NOT NULL,
	MaPhanquyen CHAR(10) NOT NULL,--mã phân quyền
	CONSTRAINT PK_ACCOUT PRIMARY KEY (username))
	GO

	--bảng phân quyền
CREATE TABLE Phan_Quyen(
	MaPhanQuyen CHAR(10) NOT NULL,
	TenQuyen NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_DECENTRALIZATION PRIMARY KEY (MaPhanQuyen))
	GO

--khóa ngoại bảng sản phẩm
ALTER TABLE San_Pham ADD CONSTRAINT FK_PRODUCT_SORT FOREIGN KEY (MaLoai) REFERENCES Loai_San_Pham(MaLoai)
GO
ALTER TABLE San_Pham ADD CONSTRAINT FK_VOUCHER_PRODUCT FOREIGN KEY (Ma_voucher) REFERENCES voucher(Ma_voucher)
GO

--khóa ngoại bảng hội viên
ALTER TABLE Hoi_Vien ADD CONSTRAINT FK_CARD_MEMBER FOREIGN KEY (Loai_The) REFERENCES The_Hoi_Vien(Loai_The)
GO

--khóa ngoại bảng phiếu nhập
ALTER TABLE Phieu_Nhap_hang ADD CONSTRAINT FK_STAFF_IMPORT_PAPER FOREIGN KEY (MaNV) REFERENCES Nhan_Vien(MaNV)
GO
ALTER TABLE Phieu_Nhap_hang ADD CONSTRAINT FK_SUPPLIER FOREIGN KEY (MaNCC) REFERENCES Nha_cung_cap(MaNCC)
GO

--khóa ngoại bảng chi tiết phiếu nhập
ALTER TABLE Chi_Tiet_Phieu_Nhap ADD CONSTRAINT FK_IMPORT_PAPER FOREIGN KEY (MaPhieu) REFERENCES Phieu_Nhap_hang(MaPhieu)
GO
ALTER TABLE Chi_Tiet_Phieu_Nhap ADD CONSTRAINT FK_PRODUCT FOREIGN KEY (MaSP) REFERENCES San_Pham(MaSP)
GO
ALTER TABLE Chi_Tiet_Phieu_Nhap ADD CONSTRAINT FK_LOAI FOREIGN KEY (MaLoai) REFERENCES Loai_San_Pham(MaLoai)

--khóa ngoại bảng hóa đơn
ALTER TABLE Hoa_Don ADD CONSTRAINT FK_ID_CUSTOMER FOREIGN KEY (MaKH) REFERENCES Khach_Hang(MaKH)
GO
ALTER TABLE Hoa_Don ADD CONSTRAINT FK_ID_STAFF FOREIGN KEY (MaNV) REFERENCES Nhan_Vien(MaNV)
GO
ALTER TABLE Hoa_Don ADD CONSTRAINT FK_ID_MEMBER FOREIGN KEY (MaHV) REFERENCES Hoi_Vien(MaHV)
GO

--khóa ngoại bảng chi tiêt hóa đơn
ALTER TABLE Chi_Tiet_Hoa_Don ADD CONSTRAINT FK_ID_BILL FOREIGN KEY (MaHD) REFERENCES Hoa_Don(MaHD)
GO
ALTER TABLE Chi_Tiet_Hoa_Don ADD CONSTRAINT FK_ID_PRODUCT FOREIGN KEY (MaSP) REFERENCES San_Pham(MaSP)
GO
--ALTER TABLE Chi_Tiet_Hoa_Don ADD CONSTRAINT FK_ID_VOUCHER FOREIGN KEY (Ma_voucher) REFERENCES voucher(Ma_voucher)
--GO

--khóa ngoại bảng tải khoản
ALTER TABLE Tai_Khoan ADD CONSTRAINT FK_ACCOUT_ID_STAFF FOREIGN KEY (MaNV) REFERENCES Nhan_Vien(MaNV)
GO
ALTER TABLE Tai_Khoan ADD CONSTRAINT FK_ID_DECENTRALIZATION FOREIGN KEY (MaPhanQuyen) REFERENCES Phan_Quyen(MaPhanQuyen)
GO