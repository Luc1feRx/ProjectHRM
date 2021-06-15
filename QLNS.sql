CREATE DATABASE QuanLyNhanSu

go

USE QuanLyNhanSu

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
	MaBoPhan nvarchar(10) NOT NULL,
	MaPhong nvarchar(10) NOT NULL,
	MaNV nvarchar(10) PRIMARY KEY NOT NULL,
	HoTen nvarchar(50),
	MaLuong nvarchar(50),
	NgaySinh DATE,
	GioiTinh nvarchar(5),
	TTHonNhan nvarchar(50),
	CCCD INT,
	NoiCap nvarchar(50),
	MaCV INT NOT NULL,
	ChucVu nvarchar(50),
	MaHD INT NOT NULL,
	LoaiHD nvarchar(50),
	ThoiGian nvarchar(10),
	NgayKy DATE,
	NgayHetHan DATE,
	GhiChu nvarchar(MAX)
)

CREATE TABLE tbTTCaNhan(
	MaNV nvarchar(10) NOT NULL,
	HoTen nvarchar(50),
	NoiSinh nvarchar(50),
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

CREATE TABLE tbChucVu(
	MaCV INT PRIMARY KEY NOT NULL,
	ChucVu NVARCHAR(30) NOT NULL
)

CREATE TABLE tbLoaiHD(
	MAHD INT PRIMARY KEY NOT NULL,
	LoaiHD NVARCHAR(30) NOT NULL
)

CREATE TABLE tbThaiSan(
	MaBoPhan NVARCHAR(10) NOT NULL,
	MaPhong NVARCHAR(10) NOT NULL,
	MaNV NVARCHAR(10) NOT NULL,
	HoTen NVARCHAR(50),
	NgaySinh DATETIME,
	NgayVeSom DATETIME,
	NgayNghiSinh DATETIME,
	NgayLamTroLai DATETIME,
	TroCapCTY INT,
	GhiChu nvarchar(MAX)
)

CREATE TABLE tbTangLuong(
	MaNV NVARCHAR(10) NOT NULL,
	HoTen NVARCHAR(50),
	GioiTinh nvarchar(5),
	ChucVu nvarchar(50),
	MaLuongCu NVARCHAR(10),
	MaLuongMoi NVARCHAR(10),
	NgayTang DATETIME,
	LyDo nvarchar(MAX)
)

CREATE TABLE tbBangLuongCTY(
	MaLuong NVARCHAR(10) PRIMARY KEY NOT NULL,
	LCB INT,
	PCChucVu INT,
	NgayNhap DATETIME,
	LCBMoi INT,
	NgaySua DATETIME,
	LyDo NVARCHAR(MAX),
	PCCVuMoi INT,
	NgaySuaPC DATETIME,
	GhiChu NVARCHAR(MAX)
)


CREATE TABLE tbBH(
	MaNV NVARCHAR(10) NOT NULL,
	MaLuong NVARCHAR(10) NOT NULL,
	MaSoBH NVARCHAR(10) NOT NULL,
	NgayCapSo DATETIME,
	NoiCapSo NVARCHAR(50),
	GhiChu NVARCHAR(MAX)
)

CREATE TABLE tbPhongBan(
	MaBoPhan NVARCHAR(10) NOT NULL,
	MaPhong NVARCHAR(10) PRIMARY KEY NOT NULL,
	TenPhong NVARCHAR(50),
	NgayThanhLap DATETIME,
	GhiChu NVARCHAR(MAX)

)

CREATE TABLE tbNVThoiViec(
	HoTen NVARCHAR(50),
	CCCD INT PRIMARY KEY NOT NULL,
	NgayThoiViec DATETIME,
	LyDo nvarchar(MAX)
)

CREATE TABLE tbHoSoThuViec(
	MaPhong NVARCHAR(10) NOT NULL,
	MaNVTV NVARCHAR(10) NOT NULL,
	HoTen nvarchar(50),
	NgaySinh DATE,
	GioiTinh nvarchar(5),
	DiaChi NVARCHAR(30),
	HocVan NVARCHAR(30),
	ViTriThuViec NVARCHAR(30),
	NgayTV DATETIME,
	GhiChu NVARCHAR(MAX)
)

CREATE TABLE tbBoPhan(
	MaBoPhan NVARCHAR(10) PRIMARY KEY NOT NULL,
	TenBoPhan NVARCHAR(30),
	NgayThanhLap DATETIME,
	GhiChu NVARCHAR(MAX)
)

CREATE TABLE tbBangCongThuViec(
	TenBoPhan NVARCHAR(30),
	TenPhong NVARCHAR(50),
	MaNVTV NVARCHAR(10) NOT NULL,
	LuongThuViec INT,
	Thang NVARCHAR(10),
	Nam NVARCHAR(10),
	SoNgayCong INT,
	SoNgayNghi INT,
	SoGioLamThem INT,
	Luong FLOAT,
	GhiChu NVARCHAR(MAX)
)

CREATE TABLE tbBangCongNhanVienCTY(
	MaNV NVARCHAR(10) NOT NULL,
	TenPhong NVARCHAR(50),
	HoTen nvarchar(50),
	MaLuong NVARCHAR(10),
	LCB INT,
	PCChucVu INT,
	PhuCapKhac INT,
	Thuong NVARCHAR(50),
	KyLuat NVARCHAR(50),
	Thang NVARCHAR(10),
	Nam NVARCHAR(20),
	SoNgayCong INT,
	SoNgayNghi INT,
	SoGioLamThem INT,
	Luong INT,
	GhiChu NVARCHAR(MAX)
)



 update TblCongKhoiDieuHanh set TenPhong = (select top(1) TenPhong from TblPhongBan a,TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.MaPhong=N'kt01      ' group by TenPhong) where MaNV='078'

 insert into TblThoiViec(MaNV,HoTen,CMTND,LyDo) select MaNV,HoTen,CMTND,GhiChu from TblTTNVCoBan where MaNV='120'

INSERT INTO TblTTNVCoBan VALUES(N'mb01      ',N'kt02      ',N'010',N'Nguyễn Mai Anh',N'ml2       ',CONVERT(NVARCHAR(30),'09/14/1991', 103), N'Nữ',N'rồi',N'13092423',N'Bắc Ninh',N'Nhân Viên',N'kinh tế',N'36 tháng','07/01/2018','07/01/2021',N'')

select ChucVu from tblChucVu

insert into TblTTNVCoBan values('System.Byte[]',N'mb01      ',N'kt02      ',N'035',N'Tus',N'ml1       ',N' 06 / 04 / 2021 ',N'Nam',N'qrqt',N'32523623',N'qwr',N'wtw',N'ey',N'eue',N' 06 / 04 / 2021 ',N' 06 / 04 / 2021 ',N'')

insert into TblBoPhan values(N'mb06 ',N'qe',Convert(NVARCHAR(20), '6/23/2021',103),N'      wer    ')

select * from TblPhongBan b,TblHoSoThuViec a where a.MaPhong=b.MaPhong and MaNVTV='002       '

delete from TblSoBH where MaNV = '046'

update TblSoBH set NgayCapSo=N' 05 / 27 / 2019 ',NoiCapSo=N'Bắc Ninh',GhiChu=N'qe' where MaNV=N'010'

select p.MaPhong from TblBoPhan b,TblPhongBan p where b.MaBoPhan=p.MaBoPhan and p.MaBoPhan=N'mb04'


select GioiTinh from TblTTNVCoBan where MaNV='004'


update TblCongKhoiDieuHanh set TenPhong = (select top(1) TenPhong from TblPhongBan a,TblTTNVCoBan b where a.MaPhong=b.MaPhong and a.MaPhong=N'kt01      ' group by TenPhong) where MaNV='010'

UPDATE TblPhongBan set MaBoPhan=N'mb05      ', MaPhongBan=N'ktt01     ', TenPhong=N'Kinh te',NgayThanhLap=convert(datetime,' 30 / 06 / 2021 ',103),GhiChu=N'qrq' where MaPhong=N'ktt01     '