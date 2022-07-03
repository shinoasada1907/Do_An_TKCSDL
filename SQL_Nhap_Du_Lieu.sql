USE MYPHAM
GO

--Thêm loai sản phẩm
INSERT INTO dbo.Loai_San_Pham
(
	MaLoai,
	TenLoaiSP
)
VALUES
(   'SRM',N'Sữa rửa mặt'),
(   'TT',N'Tẩy trang'),
(   'NHH',N'Toner'),
(   'MN',N'Mặt nạ'),
(   'S',N'Son'),
(   'CN',N'Kem chống nắng'),
(   'SR',N'Serum'),
(   'KD',N'Kem dưỡng');
GO
--thêm voucher
INSERT INTO dbo.voucher
(
	Ma_voucher,
	Ten_voucher,
	GiatriKM
)
VALUES
(   'NO',N'Không có voucher',0),
(   'G50',N'giảm giá 50%',50),
(   'KM20',N'khuyến mãi 20%',20),
(   'KM15',N'khuyến mãi 15%',15),
(   'KM3',N'khuyến mãi 3%',3),
(   'KM6',N'khuyến mãi 6%',6),
(   'KM10',N'khuyến mãi 10%',10),
(   'TANG',N'tặng',0);
GO

--Thêm sản phẩm 280000
INSERT INTO dbo.San_Pham
(
	MaSP,
	MaLoai,
	Ma_voucher,
	TenSP,
	GiaSP,
	Hang_SX,
	SLTon
)
VALUES 
(   'SP11','SRM','G50',N'Sữa rửa mặt Naruko',CAST(170000 AS DECIMAL(18,0)),N'NARUKO',5 ),
(   'SP12','SRM','G50',N'Sữa rửa mặt Laroche PoSay',CAST(280000 AS DECIMAL(18,0)),N'LAROCHE POSAY',7 ),
(   'SP13','SRM','G50',N'Sữa rửa mặt Vichy',CAST(400000 AS DECIMAL(18,0)),N'VICHY',2 ),
(   'SP14','SRM','G50',N'Sữa rửa mặt Bioderma',CAST(390000 AS DECIMAL(18,0)),N'BIODERMA',8 ),
(   'SP15','SRM','G50',N'Sữa rửa mặt Senka',CAST(70000 AS DECIMAL(18,0)),N'SENKA',6 ),
(   'SP16','SRM','G50',N'Sữa rửa mặt Eucerin',CAST(330000 AS DECIMAL(18,0)),N'EUCERIN',15 ),
(   'SP17','SRM','G50',N'Sữa rửa mặt Some By Mi',CAST(170000 AS DECIMAL(18,0)),N'SOME BY MI',22 ),
(   'SP18','SRM','G50',N'Sữa rửa mặt Cocoon',CAST(150000 AS DECIMAL(18,0)),N'COCOON',15 ),
(   'SP19','TT','KM20',N'Tẩy trang Naruko',CAST(230000 AS DECIMAL(18,0)),N'NARUKO',10 ),
(   'SP20','TT','KM20',N'Tẩy trang Laroche PoSay',CAST(330000 AS DECIMAL(18,0)),N'LAROCHE POSAY',17 ),
(   'SP21','TT','KM20',N'Tẩy trang Senka',CAST(80000 AS DECIMAL(18,0)),N'SENKA',19 ),
(   'SP22','TT','KM20',N'Tẩy trang Bioderma',CAST(445000 AS DECIMAL(18,0)),N'BIODERMA',33 ),
(   'SP23','TT','KM20',N'Tẩy trang Cocoon',CAST(140000 AS DECIMAL(18,0)),N'COCOON',17 ),
(   'SP24','NHH','KM15',N'Toner Naruko',CAST(230000 AS DECIMAL(18,0)),N'NARUKO',25 ),
(   'SP25','NHH','KM15',N'Toner Vichy',CAST(450000 AS DECIMAL(18,0)),N'VICHY',25 ),
(   'SP26','NHH','KM15',N'Toner Senka',CAST(90000 AS DECIMAL(18,0)),N'SENKA',20 ),
(   'SP27','NHH','KM15',N'Toner Eucerin',CAST(280000 AS DECIMAL(18,0)),N'Eucerin',15 ),
(   'SP28','NHH','KM15',N'Toner Bioderma',CAST(350000 AS DECIMAL(18,0)),N'BIODERMA',22 ),
(   'SP29','MN','KM15',N'Mặt Nạ Some By Mi',CAST(24000 AS DECIMAL(18,0)),N'SOME BY MI',30 ),
(   'SP30','MN','KM15',N'Mặt nạ Purita',CAST(12000 AS DECIMAL(18,0)),N'PURITA',50 ),
(   'SP31','MN','KM15',N'Mặt nạ Centella',CAST(37000 AS DECIMAL(18,0)),N'CENTELLA',70 ),
(   'SP32','MN','KM15',N'Mặt nạ Naruko',CAST(22000 AS DECIMAL(18,0)),N'NARUKO',80 ),
(   'SP33','S','KM6',N'Son Black rouge',CAST(150000 AS DECIMAL(18,0)),N'BLACK ROUGE',40 ),
(   'SP34','S','KM6',N'Son Bbia',CAST(180000 AS DECIMAL(18,0)),N'BBIA',35 ),
(   'SP35','S','KM6',N'Son 3CE',CAST(250000 AS DECIMAL(18,0)),N'3CE',90 ),
(   'SP36','S','KM6',N'Son Maybilline',CAST(220000 AS DECIMAL(18,0)),N'MAYBILLINE',20 ),
(   'SP37','CN','KM10',N'Kem chống nắng Naruko',CAST(300000 AS DECIMAL(18,0)),N'NARUKO',40 ),
(   'SP38','CN','KM10',N'Kem chống nắng Vichy',CAST(370000 AS DECIMAL(18,0)),N'VICHY',55 ),
(   'SP39','CN','KM10',N'Kem chống nắng Anessa',CAST(400000 AS DECIMAL(18,0)),N'ANESSA',100 ),
(   'SP40','CN','KM10',N'Kem chống nắng Some By Mi',CAST(250000 AS DECIMAL(18,0)),N'SOME BY MI',50 ),
(   'SP41','CN','KM10',N'Kem chống nắng Eucerin',CAST(450000 AS DECIMAL(18,0)),N'EUCERIN',75 ),
(   'SP42','SR','KM10',N'Serum Vichy',CAST(530000 AS DECIMAL(18,0)),N'VICHY',77 ),
(   'SP43','SR','KM10',N'Serum Some By Mi',CAST(270000 AS DECIMAL(18,0)),N'SOME BY MI',66 ),
(   'SP44','SR','KM15',N'Serum Centella',CAST(370000 AS DECIMAL(18,0)),N'CENTELLA',65 ),
(   'SP45','SR','KM15',N'Serum Caryophy',CAST(330000 AS DECIMAL(18,0)),N'CARYOPHY',33 ),
(   'SP46','KD','TANG',N'Kem dưỡng Cocoon',CAST(275000 AS DECIMAL(18,0)),N'COCOON',66 ),
(   'SP47','KD','TANG',N'Kem dưỡng Centella',CAST(350000 AS DECIMAL(18,0)),N'CENTELLA',66 ),
(   'SP48','KD','TANG',N'Kem dưỡng Vichy',CAST(600000 AS DECIMAL(18,0)),N'VICHY',77 ),
(   'SP49','KD','TANG',N'Kem dưỡng Eucerin',CAST(830000 AS DECIMAL(18,0)),N'EUCERIN',88 ),
(   'SP50','KD','TANG',N'Kem dưỡng Naruko',CAST(300000 AS DECIMAL(18,0)),N'NARUKO',96 );
GO

--Thêm thẻ hội viên
INSERT INTO dbo.The_Hoi_Vien(
	Loai_The,
	Gia_The,
	Tien_Giam,
	Thoi_Gian_The
)
VALUES
( N'Vàng',CAST(800000 AS DECIMAL(18,0)),CAST(80000 AS DECIMAL(18,0)),3),
( N'Bạc',CAST(600000 AS DECIMAL(18,0)),CAST(60000 AS DECIMAL(18,0)),4),
( N'Đồng',CAST(400000 AS DECIMAL(18,0)),CAST(40000 AS DECIMAL(18,0)),5);
GO

--thêm hội viên
INSERT INTO dbo.Hoi_Vien(
	MaHV,
	Loai_The,
	TenHV,
	GioiTinhHV,
	NgaysinhHV,
	Ngay_lap_The,
	SDT_HV
)
VALUES
( 001,N'Vàng',N'Nguyễn Thị Diễm My',N'Nữ','2001-01-23','2021-01-23','0405058792' ),
( 002,N'Bạc',N'Trần Thị Đại Nghĩa',N'Nữ','1999-11-30','2021-07-01','0805023723' ),
( 003,N'Đồng',N'Nguyễn Thành Tiến',N'Nữ','2002-09-08','2021-03-03','0305081587' ),
( 004,N'Bạc',N'Nguyễn Thị Thu Trang',N'Nữ','1994-11-07','2021-07-13','0905088794'),
( 005,N'Vàng',N'Nguyễn Hoàn Tín',N'Nam','2001-03-08','2021-09-09','0805081478' ),
( 006,N'Đồng',N'Trần Quốc Tuấn',N'Nam','1998-05-07','2021-10-01','0705081236' ),
( 007,N'Bạc',N'Hà Thị Thanh Thúy',N'Nữ','2003-03-07','2021-10-10','0405081459' ),
( 008,N'Vàng',N'Mạc Văn Khoa',N'Nam','1972-05-07','2021-07-17','0605080025' ),
( 009,N'Bạc',N'Trương Thị Lộ Liễu',N'Nam','2001-04-04','2021-12-12','0105081278' ),
( 010,N'Đồng',N'Nguyễn Thị Nam Tính',N'Nam','2001-06-08','2021-01-23','0205081448' ),
( 011,N'Bạc',N'Lý Mạc Sầu',N'Nam','1996-05-03','2021-11-11','0102090000' ),
( 012,N'Bạc',N'Lý Thị Mộng',N'Nữ','2006-04-09','2021-12-30','0589758469' ),
( 013,N'Bạc',N'Nguyễn Thị Mộng Tưởng',N'Nữ','1995-06-19','2021-08-18','0254789147' ),
( 014,N'Vàng',N'Harry Potter',N'Nam','1998-02-28','2021-05-09','0905031111' );
GO

--Thêm nhân viên
INSERT INTO dbo.Nhan_Vien
(
	MaNV,
	HoTenNV,
	Ngaysinh,
	GioiTinhNV,
	Chucvu,
	SDTNV,
	DiachiNV,
	LuongNV
)
VALUES
(   'NV01',N'Đặng Ngọc Chung','2001-01-23',N'Nam',N'Quản lý','0905083882',N'Tăng Nhơn Phú A, Thành phố Thủ Đức',CAST(8000000 AS DECIMAL(18,0)) ),
(   'NV02',N'Thu Trang','2002-12-08',N'Nữ',N'Kế Toán','0705083457',N'Bình Định',CAST(6500000 AS DECIMAL(18,0)) ),
(   'NV03',N'Nguyễn Thành Tiến','2001-02-14',N'Nam',N'Nhân Viên','0320268105',N'Tân Bình, Thành phố Hồ Chí Minh',CAST(5520000 AS DECIMAL(18,0)) ),
(   'NV04',N'Nguyễn Hoàn Tín','1999-08-13',N'Nam',N'Nhân viên','0934937954',N'Phú Yên',CAST(5520000 AS DECIMAL(18,0)) );
GO

--Thêm nhà cung cấp
INSERT INTO Nha_cung_cap(
	MaNCC,
	TenNCC
)
VALUES
(	'NB',N'Nhật Bản'),
(	'K',N'Hàn Quốc'),
(	'USA',N'Hoa Kỳ');
GO

--thêm phiếu nhập
INSERT INTO dbo.Phieu_Nhap_hang
(
	MaPhieu,
	MaNV,
	MaNCC,
	Ngaylap,
	Tongtien
)
VALUES
('PN01', 'NV01','NB', '2021-11-15',CAST(7600000 AS DECIMAL(18,0))),
('PN02', 'NV01','USA','2021-11-15',CAST(12800000 AS DECIMAL(18,0))),
('PN03', 'NV01','K', '2021-11-15',CAST(10300000 AS DECIMAL(18,0)))
GO


--Thêm chi tiết phiếu nhập
INSERT INTO dbo.Chi_Tiet_Phieu_Nhap
(
	MaPhieu,
	MaSP,
	MaLoai,
	Gia_Goc,
	SLNhap,
	Thanhtien
)
VALUES
(	'PN01', 'SP11', 'SRM', CAST(80000 AS DECIMAL(18,0)), 50, CAST(4000000 AS DECIMAL(18,0))),
(	'PN01', 'SP15', 'MN', CAST(30000 AS DECIMAL(18,0)), 20, CAST(600000 AS DECIMAL(18,0))),
(	'PN01', 'SP19', 'S', CAST(100000 AS DECIMAL(18,0)), 30, CAST(3000000 AS DECIMAL(18,0))),
(	'PN02', 'SP21', 'MN', CAST(40000 AS DECIMAL(18,0)), 20, CAST(800000 AS DECIMAL(18,0))),
(	'PN02', 'SP16', 'S', CAST(150000 AS DECIMAL(18,0)), 30, CAST(4500000 AS DECIMAL(18,0))),
(	'PN02', 'SP27', 'SR', CAST(150000 AS DECIMAL(18,0)), 50, CAST(7500000 AS DECIMAL(18,0))),
(	'PN03', 'SP17', 'SR', CAST(100000 AS DECIMAL(18,0)), 50, CAST(5000000 AS DECIMAL(18,0))),
(	'PN03', 'SP29', 'KD', CAST(10000 AS DECIMAL(18,0)), 30, CAST(300000 AS DECIMAL(18,0))),
(	'PN03', 'SP40', 'CN', CAST(100000 AS DECIMAL(18,0)), 50, CAST(5000000 AS DECIMAL(18,0)))
GO

--Thêm hóa đơn
INSERT INTO Hoa_Don(
	MaHD,
	MaKH,
	MaNV,
	MaHV,
	Ngay_lap_HD,
	Tongtien
)

VALUES
(	'HD01',NULL, 'NV02',001, '2021-11-30', CAST(585000 AS DECIMAL(18,0))),
(	'HD02','KH01', 'NV02', NULL, '2021-11-30', CAST(1410000 AS DECIMAL(18,0))),
(	'HD03','KH01', 'NV02', NULL, '2021-11-30', CAST(1080000 AS DECIMAL(18,0)))
GO

--Thêm chi tiết hóa đơn
INSERT INTO Chi_Tiet_Hoa_Don(
	MaHD,
	MaSP,
	Ma_voucher,
	SLMua,
	Thanhtien
)

VALUES
(	'HD01', 'SP22','NO', '1', CAST(445000 AS DECIMAL(18,0))),
(	'HD01', 'SP15','G50', '2', CAST(140000 AS DECIMAL(18,0))),
(	'HD02', 'SP11','NO', '2', CAST(240000 AS DECIMAL(18,0))),
(	'HD02', 'SP19','KM20', '1', CAST(230000 AS DECIMAL(18,0))),
(	'HD02', 'SP24','NO', '1', CAST(230000 AS DECIMAL(18,0))),
(	'HD03', 'SP32','NO', '5', CAST(110000 AS DECIMAL(18,0))),
(	'HD03', 'SP50','NO', '2', CAST(600000 AS DECIMAL(18,0))),
(	'HD03', 'SP17','NO', '2', CAST(340000 AS DECIMAL(18,0))),
(	'HD03', 'SP29','NO', '10', CAST(240000 AS DECIMAL(18,0))),
(	'HD03', 'SP40','NO', '2', CAST(500000 AS DECIMAL(18,0)));
GO

--phân quyền
INSERT INTO dbo.Phan_Quyen(
	MaPhanQuyen,
	TenQuyen
)
VALUES
(   'Quanly',N'Quản lý'),
(   'Nhanvien',N'Nhân viên')
GO

--Thêm tài khoản
INSERT INTO dbo.Tai_Khoan(
	username,
	passwords,
	MaNV,
	MaPhanquyen
)
VALUES
(   'ChungCT','1234','NV01','Quanly'),
(   'TrangCT','123','NV02','Nhanvien'),
(   'TienCT','123','NV03','Nhanvien'),
(   'TinCT','123','NV04','Nhanvien')
GO

SELECT * FROM Khach_Hang where SDTKH = '0372849352'
delete from Khach_Hang
INSERT INTO dbo.Khach_Hang(
	MaKH,
	TenKH,
	GioiTinh,
	Ngaysinh,
	SDTKH,
	DiachiKH
	)
VALUES
('KH01',N'Nguyễn Văn',N'Nam','2001-11-30','0372849352',N'TP.Hồ Chí Minh'),
('KH02',N'Nguyễn Thu Thảo',N'Nữ','1996-1-3','0372842532',N'TP.Hồ Chí Minh'),
('KH03',N'Nguyễn Thị Thu Hường',N'Nữ','1990-10-30','0932858945',N'TP.Hồ Chí Minh'),
('KH04',N'Hoàng Công Nhiên',N'Nam','1999-1-30','0982846357',N'TP.Hồ Chí Minh'),
('KH05',N'Hoàng Tiên',N'Nữ','2002-11-30','0935640907',N'TP.Hồ Chí Minh')
GO

select * from Hoa_Don a, Khach_Hang b where a.MaHV = b.MaKH and b.SDTKH= '0372842532'