use QuanLyNhanSu

GO

CREATE TABLE tbUsers(
	Username nvarchar(50) NOT NULL,
	Pass NVARCHAR(50),
	Quyen NCHAR(10),
	Ten NVARCHAR(50),
)

CREATE TABLE tbQuyen(
	MaQuyen INT NOT NULL,
	TenQuyen NVARCHAR(50) NOT NULL
)


INSERT INTO tbUsers
(
    Username,
    Pass,
    Quyen,
    Ten
)
VALUES
(	'admin',
	'asd123',
	'Admin',
	N'Tú'
)

CREATE TABLE tbTTNVCoBan(
	MaBoPhan char(10) NOT NULL,
	MaPhong char(10) NOT NULL,
	MaNV nvarchar(50) PRIMARY KEY NOT NULL,
	HoTen nvarchar(50),
	MaLuong nvarchar(50),
	NgaySinh DATE,
	GioiTinh nvarchar(5),
	TTHonNhan nvarchar(50),
	CCCD nvarchar(50),
	NoiCap nvarchar(50),
	ChucVu nvarchar(50),
	LoaiHD nvarchar(50),
	ThoiGian nvarchar(10),
	NgayKy DATE,
	NgayHetHan DATE,
	GhiChu nvarchar(MAX)
)

CREATE TABLE tbTTCaNhan(
	MaNV nvarchar(50) NOT NULL,
	HoTen nvarchar(50),
	NgaySinh DATE,
	NguyenQuan nvarchar(50),
	DCThuongChu nvarchar(100),
	DCTamChu nvarchar(100),
	SDT char(12),
	DanToc nvarchar(30),
	TonGiao nvarchar(20),
	QuocTich nvarchar(20),
	HocVan nvarchar(30),
	GhiChu nvarchar(MAX)
)

CREATE TABLE tbBoPhan(
	MaBoPhan char(10) PRIMARY KEY NOT NULL,
	TenBoPhan nchar(10) 