CREATE DATABASE QuanLyTrungTamNgoaiNgu
GO

USE QuanLyTrungTamNgoaiNgu
GO

CREATE TABLE HocVien
(
  MaHV char(10) PRIMARY KEY,
  HoTen nvarchar(50) NOT NULL,
  GioiTinh int NOT NULL,
  NgaySinh date NOT NULL,
  Email char(50) NOT NULL,
  Sdt char(11) NOT NULL,
  DiaChi nvarchar(max),
  STT int DEFAULT 1
)


INSERT INTO HocVien (MaHV, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi) VALUES ('HV01', N'Nguyễn Đức Công Kiệt', 1, '01/02/1998', 'congkiet@gmail.com', '0123456789', N'TP. HCM')
INSERT INTO HocVien (MaHV, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi) VALUES ('HV02', N'Đoàn Ngọc Long', 1, '06/02/1998', 'ngoclong@gmail.com', '0123456789', N'TP. HCM')
INSERT INTO HocVien (MaHV, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi) VALUES ('HV03', N'Trần Như Gia Bảo', 1, '12/12/1998', 'giabao@gmail.com', '0123456789', N'TP. HCM')
INSERT INTO HocVien (MaHV, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi) VALUES ('HV04', N'Nguyễn Tấn Liêm', 1, '11/12/1999', 'tanliem@gmail.com', '0123456789', N'TP. HCM')
INSERT INTO HocVien (MaHV, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi) VALUES ('HV05', N'Nguyễn Minh Nhân', 1, '12/20/2000', 'minhnhan@gmail.com', '0123456789', N'TP. HCM')
INSERT INTO HocVien (MaHV, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi) VALUES ('HV06', N'Nguyễn Quốc Toản', 1, '11/02/2000', 'quoctoan@gmail.com', '0123456789', N'TP. HCM')

CREATE TABLE LoaiTaiKhoan
(
	MaLoai char(10) PRIMARY KEY,
	TenLoai nvarchar(20) NOT NULL,
	MoTa nvarchar(50) NOT NULL,
	STT int DEFAULT 1
)
INSERT INTO LoaiTaiKhoan(MaLoai, TenLoai, MoTa) VALUES('.', N'Root', N'Root')
INSERT INTO LoaiTaiKhoan(MaLoai, TenLoai, MoTa) VALUES('QT', N'Quản trị', N'Tương tác được với Tài Khoản của Nhân Viên')
INSERT INTO LoaiTaiKhoan(MaLoai, TenLoai, MoTa) VALUES('QL', N'Quản lý', N'Tương tác được với Nhân Viên, Phòng Học, Học Viên')
INSERT INTO LoaiTaiKhoan(MaLoai, TenLoai, MoTa) VALUES('NV', N'Nhân viên', 'MoTa')
INSERT INTO LoaiTaiKhoan(MaLoai, TenLoai, MoTa) VALUES('GV', N'Giáo viên', 'MoTa')
INSERT INTO LoaiTaiKhoan(MaLoai, TenLoai, MoTa) VALUES('GVV', N'Giáo vụ', 'MoTa')
INSERT INTO LoaiTaiKhoan(MaLoai, TenLoai, MoTa) VALUES('KT', N'Kế toán', 'MoTa')

CREATE TABLE TaiKhoan 
(
	TenTK char(32) PRIMARY KEY,
	MatKhau char(32) NOT NULL,
	LoaiTK char(10) FOREIGN KEY REFERENCES LoaiTaiKhoan(MaLoai),
	STT int DEFAULT 1
)
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('root', 'root', '.')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('admin', 'admin', 'QT')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('quanly1', 'quanly1', 'QL')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('quanly2', 'quanly2', 'QL')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('nhanvien1', 'nhanvien1', 'NV')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('nhanvien2', 'nhanvien2', 'NV')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('giaovien1', 'giaovien1', 'GV')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('giaovien2', 'giaovien2', 'GV')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('giaovu1', 'giaovu1', 'GVV')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('giaovu2', 'giaovu2', 'GVV')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('ketoan1', 'ketoan1', 'KT')
INSERT INTO TaiKhoan(TenTK, MatKhau, LoaiTK) VALUES('ketoan2', 'ketoan2', 'KT')

CREATE TABLE ChucVu
(
  MaCV char(10) PRIMARY KEY,
  TenCV nvarchar(30) NOT NULL,
  LuongCB float NOT NULL,
  STT int DEFAULT 1
 )

INSERT INTO ChucVu(MaCV, TenCV, LuongCB) VALUES('QT', N'Quản trị', 5000000)
INSERT INTO ChucVu(MaCV, TenCV, LuongCB) VALUES('QL', N'Quản lý', 4000000)
INSERT INTO ChucVu(MaCV, TenCV, LuongCB) VALUES('NV', N'Nhân viên', 3000000)
INSERT INTO ChucVu(MaCV, TenCV, LuongCB) VALUES('GV', N'Giáo viên', 3000000)
INSERT INTO ChucVu(MaCV, TenCV, LuongCB) VALUES('GVV', N'Giáo vụ', 3000000)
INSERT INTO ChucVu(MaCV, TenCV, LuongCB) VALUES('KT', N'Kế toán', 3000000)

CREATE TABLE NhanVien
(
  MaNV char(10) PRIMARY KEY,
  TenTK char(32) FOREIGN KEY REFERENCES TaiKhoan(TenTK),
  HoTen nvarchar(50) NOT NULL,
  GioiTinh int NOT NULL,
  NgaySinh date NOT NULL,
  Email char(50) NOT NULL,
  Sdt char(11) NOT NULL,
  DiaChi nvarchar(max),
  ChucVu char(10) FOREIGN KEY REFERENCES ChucVu(MaCV),
  NgayVaoLam date NOT NULL,
  Luong float,
  HeSoLuong float NOT NULL,
  STT int DEFAULT 1
)

INSERT INTO NhanVien(MaNV, TenTK, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi, ChucVu, NgayVaoLam, Luong, HeSoLuong) VALUES('NV01', 'admin', N'Nguyễn Thành Lộc', 1, '09/19/1998', 'locnt19@gmail.com', '0123456789', N'Đất Đỏ', 'QT', '08/10/2016', 20000000, 1.9)
INSERT INTO NhanVien(MaNV, TenTK, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi, ChucVu, NgayVaoLam, Luong, HeSoLuong) VALUES('NV02', 'quanly1', N'Lê Minh Hiếu', 1, '07/02/1998', 'hieuabc@gmail.com', '0123456789', N'Bến Tre', 'QL', '08/10/2016', 15000000, 1.7)
INSERT INTO NhanVien(MaNV, TenTK, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi, ChucVu, NgayVaoLam, Luong, HeSoLuong) VALUES('NV03', 'quanly2', N'Lê Minh Phương', 1, '04/02/1998', 'phuongxyz@gmail.com', '0123456789', N'Tây Ninh', 'QL', '08/10/2016', 10000000, 1.7)
INSERT INTO NhanVien(MaNV, TenTK, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi, ChucVu, NgayVaoLam, Luong, HeSoLuong) VALUES('NV04', 'giaovien1', N'Giáo viên 1', 0, '09/19/1998', 'giaovien1@gmail.com', '0123456789', 'BR-VT', 'GV', '08/10/2016', 20000000, 1.9)
INSERT INTO NhanVien(MaNV, TenTK, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi, ChucVu, NgayVaoLam, Luong, HeSoLuong) VALUES('NV05', 'giaovien2', N'Giáo viên 2', 0, '07/02/1998', 'giaovien2@gmail.com', '0123456789', N'Bến Tre', 'GV', '08/10/2016', 15000000, 1.7)
INSERT INTO NhanVien(MaNV, TenTK, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi, ChucVu, NgayVaoLam, Luong, HeSoLuong) VALUES('NV06', 'giaovu1', N'Giáo vụ 1', 1, '04/02/1998', 'giaovu1@gmail.com', '0123456789', N'Tây Ninh', 'GVV', '08/10/2016', 10000000, 1.5)
INSERT INTO NhanVien(MaNV, TenTK, HoTen, GioiTinh, NgaySinh, Email, Sdt, DiaChi, ChucVu, NgayVaoLam, Luong, HeSoLuong) VALUES('NV07', 'giaovu2', N'Giáo vụ 2', 1, '04/02/1998', 'giaovu2@gmail.com', '0123456789', N'Tây Nguyên', 'GVV', '08/10/2016', 10000000, 1.5)


CREATE TABLE CaHoc
(
	MaCa char(10) PRIMARY KEY,
	MoTa nvarchar(50) NOT NULL,
	STT int DEFAULT 1
)

INSERT INTO CaHoc(MaCa, MoTa) VALUES('CA01', N'Sáng từ 8:00-9:30')
INSERT INTO CaHoc(MaCa, MoTa) VALUES('CA02', N'Sáng từ 10:00-11:30')
INSERT INTO CaHoc(MaCa, MoTa) VALUES('CA03', N'Chiều từ 17:30-19:00')
INSERT INTO CaHoc(MaCa, MoTa) VALUES('CA04', N'Sáng từ 19:30-21:00')

CREATE TABLE KhoaHoc
(
	MaKH char(10) PRIMARY KEY,
	TenKH nvarchar(50) NOT NULL,
	MoTa nvarchar(50) NOT NULL,
	HocPhi float NOT NULL,
	STT int DEFAULT 1
)

INSERT INTO KhoaHoc(MaKH, TenKH, MoTa, HocPhi) VALUES('KH01', 'IELTS', N'Khóa học IELTS', 3600000)
INSERT INTO KhoaHoc(MaKH, TenKH, MoTa, HocPhi) VALUES('KH02', 'TOEIC', N'Khóa học TOEIC', 3200000)
INSERT INTO KhoaHoc(MaKH, TenKH, MoTa, HocPhi) VALUES('KH03', 'TOEFL', N'Khóa học TOEFL', 3200000)
INSERT INTO KhoaHoc(MaKH, TenKH, MoTa, HocPhi) VALUES('KH04', N'Tiếng Anh giao tiếp cơ bản', N'Khóa học Tiếng Anh giao tiếp cơ bản', 2350000)
INSERT INTO KhoaHoc(MaKH, TenKH, MoTa, HocPhi) VALUES('KH05', N'Tiếng Nhật giao tiếp cơ bản', N'Khóa học Tiếng Nhật giao tiếp cơ bản', 2350000)
INSERT INTO KhoaHoc(MaKH, TenKH, MoTa, HocPhi) VALUES('KH06', N'Tiếng Trung giao tiếp cơ bản', N'Khóa học Tiếng Trung giao tiếp cơ bản', 2350000)

CREATE TABLE Phong
(
	MaPhong char(10) PRIMARY KEY,	
	MoTa nvarchar(50) NOT NULL,
	STT int DEFAULT 1
)

INSERT INTO Phong(MaPhong, MoTa) VALUES('F1.1', N'Phòng Đào tạo F1.1')
INSERT INTO Phong(MaPhong, MoTa) VALUES('F1.2', N'Phòng Kế toán F1.2')
INSERT INTO Phong(MaPhong, MoTa) VALUES('F1.3', N'Phòng Quản lý F1.3')
INSERT INTO Phong(MaPhong, MoTa) VALUES('F2.1', N'Phòng học F2.1')
INSERT INTO Phong(MaPhong, MoTa) VALUES('F2.2', N'Phòng học F2.2')
INSERT INTO Phong(MaPhong, MoTa) VALUES('F2.3', N'Phòng học F2.3')
INSERT INTO Phong(MaPhong, MoTa) VALUES('F3.1', N'Phòng học F3.1')
INSERT INTO Phong(MaPhong, MoTa) VALUES('F3.2', N'Phòng học F3.2')
INSERT INTO Phong(MaPhong, MoTa) VALUES('F3.3', N'Phòng học F3.3')


CREATE TABLE ChiTietKhoaHoc
(
	MaKH char(10) FOREIGN KEY REFERENCES KhoaHoc(MaKH),
	MaPhong char(10) FOREIGN KEY REFERENCES Phong(MaPhong),
	MaCa char(10) FOREIGN KEY REFERENCES CaHoc(MaCa),
	NgayBatDau date NOT NULL,
	STT int DEFAULT 1,
	PRIMARY KEY(MaKH, MaPhong, MaCa)
)

INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH01', 'F2.1', 'CA01', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH01', 'F2.1', 'CA03', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH01', 'F3.2', 'CA01', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH02', 'F3.2', 'CA02', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH02', 'F2.2', 'CA01', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH02', 'F2.2', 'CA04', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH03', 'F2.1', 'CA02', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH03', 'F2.1', 'CA04', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH03', 'F3.2', 'CA04', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH04', 'F3.1', 'CA02', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH04', 'F2.2', 'CA02', '11/05/2018')
INSERT INTO ChiTietKhoaHoc(MaKH, MaPhong, MaCa, NgayBatDau) VALUES('KH04', 'F2.2', 'CA03', '11/05/2018')

CREATE TABLE BienLai
(
	MaBienLai char(10) PRIMARY KEY,
	MaHV char(10) FOREIGN KEY REFERENCES HocVien(MaHV),
	TongThanhToan float NOT NULL,
	NguoiLap char(10) FOREIGN KEY REFERENCES NhanVien(MaNV),
	NgayLap Date NOT NULL
)

INSERT INTO BienLai(MaBienLai, MaHV, TongThanhToan, NguoiLap, NgayLap) VALUES('BL01', 'HV01', 6800000, 'NV06', '10/31/2018')
INSERT INTO BienLai(MaBienLai, MaHV, TongThanhToan, NguoiLap, NgayLap) VALUES('BL02', 'HV02', 6400000, 'NV06', '10/31/2018')
INSERT INTO BienLai(MaBienLai, MaHV, TongThanhToan, NguoiLap, NgayLap) VALUES('BL03', 'HV03', 3600000, 'NV06', '10/31/2018')
INSERT INTO BienLai(MaBienLai, MaHV, TongThanhToan, NguoiLap, NgayLap) VALUES('BL04', 'HV04', 2350000, 'NV07', '10/31/2018')
INSERT INTO BienLai(MaBienLai, MaHV, TongThanhToan, NguoiLap, NgayLap) VALUES('BL05', 'HV05', 5950000, 'NV07', '10/31/2018')
INSERT INTO BienLai(MaBienLai, MaHV, TongThanhToan, NguoiLap, NgayLap) VALUES('BL06', 'HV06', 2350000, 'NV07', '10/31/2018')

CREATE TABLE ChiTietBienLai
(
	MaBienLai char(10) FOREIGN KEY REFERENCES BienLai(MaBienLai),
	KhoaHoc char(10) FOREIGN KEY REFERENCES KhoaHoc(MaKH),
	HocPhi float NOT NULL,
	PRIMARY KEY(MaBienLai, KhoaHoc)
)
INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES('BL01', 'KH01', 3600000)
INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES('BL01', 'KH02', 3200000)
INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES('BL02', 'KH03', 3200000)
INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES('BL02', 'KH02', 3200000)
INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES('BL03', 'KH01', 3600000)
INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES('BL04', 'KH04', 2350000)
INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES('BL05', 'KH01', 3600000)
INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES('BL05', 'KH06', 2350000)
INSERT INTO ChiTietBienLai(MaBienLai, KhoaHoc, HocPhi) VALUES('BL06', 'KH05', 2350000)

CREATE TABLE ThoiKhoaBieu
(
	MaTKB char(10) PRIMARY KEY,
	MaCa char(10) FOREIGN KEY REFERENCES CaHoc(MaCa),
	MaKH char(10) FOREIGN KEY REFERENCES KhoaHoc(MaKH),
	MaGV char(10) FOREIGN KEY REFERENCES NhanVien(MaNV),
	NgayBatDau date NOT NULL,
	NgayKiemTra date NOT NULL,
	KyNang char(10) NOT NULL,
	STT int DEFAULT 1
)

INSERT INTO ThoiKhoaBieu(MaTKB, MaCa, MaKH, MaGV, NgayBatDau, NgayKiemTra, KyNang) VALUES('TKB01', 'CA01', 'KH01', 'NV04', '11/05/2018', '12/05/2018', 'Nghe')
INSERT INTO ThoiKhoaBieu(MaTKB, MaCa, MaKH, MaGV, NgayBatDau, NgayKiemTra, KyNang) VALUES('TKB02', 'CA02', 'KH02', 'NV04', '11/05/2018', '12/05/2018', 'Noi')
INSERT INTO ThoiKhoaBieu(MaTKB, MaCa, MaKH, MaGV, NgayBatDau, NgayKiemTra, KyNang) VALUES('TKB03', 'CA03', 'KH03', 'NV05', '11/05/2018', '12/05/2018', 'Doc')
INSERT INTO ThoiKhoaBieu(MaTKB, MaCa, MaKH, MaGV, NgayBatDau, NgayKiemTra, KyNang) VALUES('TKB04', 'CA04', 'KH04', 'NV05', '11/05/2018', '12/05/2018', 'Viet')

CREATE TABLE Lop
(
	MaLop char(10) PRIMARY KEY,
	MaTKB char(10) FOREIGN KEY REFERENCES ThoiKhoaBieu(MaTKB),
	PhongHoc char(10) FOREIGN KEY REFERENCES Phong(MaPhong),
	STT int DEFAULT 1
)

INSERT INTO Lop(MaLop, MaTKB, PhongHoc) VALUES('LOP01', 'TKB01', 'F2.1')
INSERT INTO Lop(MaLop, MaTKB, PhongHoc) VALUES('LOP02', 'TKB02', 'F2.2')

CREATE TABLE ChiTietLop
(
	MaLop char(10) FOREIGN KEY REFERENCES Lop(MaLop),
	MaHV char(10) FOREIGN KEY REFERENCES HocVien(MaHV),
	STT int DEFAULT 1,
	PRIMARY KEY (MaLop, MaHV)
)

INSERT INTO ChiTietLop(MaLop, MaHV) VALUES('LOP01', 'HV01')
INSERT INTO ChiTietLop(MaLop, MaHV) VALUES('LOP01', 'HV02')
INSERT INTO ChiTietLop(MaLop, MaHV) VALUES('LOP01', 'HV03')
INSERT INTO ChiTietLop(MaLop, MaHV) VALUES('LOP01', 'HV04')
INSERT INTO ChiTietLop(MaLop, MaHV) VALUES('LOP01', 'HV05')
INSERT INTO ChiTietLop(MaLop, MaHV) VALUES('LOP01', 'HV06')
INSERT INTO ChiTietLop(MaLop, MaHV) VALUES('LOP02', 'HV01')
INSERT INTO ChiTietLop(MaLop, MaHV) VALUES('LOP02', 'HV03')
INSERT INTO ChiTietLop(MaLop, MaHV) VALUES('LOP02', 'HV05')

CREATE TABLE DiemDanh
(
	MaLop char(10) FOREIGN KEY REFERENCES Lop(MaLop),
	MaHV char(10) FOREIGN KEY REFERENCES HocVien(MaHV),
	SoNgayVang int DEFAULT 0,
	STT int DEFAULT 1,
	PRIMARY KEY (MaLop, MaHV)
)

INSERT INTO DiemDanh(MaLop, MaHV, SoNgayVang) VALUES('LOP01', 'HV01', 0)
INSERT INTO DiemDanh(MaLop, MaHV, SoNgayVang) VALUES('LOP01', 'HV02', 1)
INSERT INTO DiemDanh(MaLop, MaHV, SoNgayVang) VALUES('LOP01', 'HV03', 0)
INSERT INTO DiemDanh(MaLop, MaHV, SoNgayVang) VALUES('LOP01', 'HV04', 1)
INSERT INTO DiemDanh(MaLop, MaHV, SoNgayVang) VALUES('LOP01', 'HV05', 0)
INSERT INTO DiemDanh(MaLop, MaHV, SoNgayVang) VALUES('LOP01', 'HV06', 2)
INSERT INTO DiemDanh(MaLop, MaHV, SoNgayVang) VALUES('LOP02', 'HV01', 3)
INSERT INTO DiemDanh(MaLop, MaHV, SoNgayVang) VALUES('LOP02', 'HV03', 1)
INSERT INTO DiemDanh(MaLop, MaHV, SoNgayVang) VALUES('LOP02', 'HV05', 0)

CREATE TABLE KetQua
(
	MaLop char(10) FOREIGN KEY REFERENCES Lop(MaLop),
	MaHV char(10) FOREIGN KEY REFERENCES HocVien(MaHV),
	Nghe float DEFAULT 0,
	Noi float DEFAULT 0,
	Doc float DEFAULT 0,
	Viet float DEFAULT 0,
	STT int DEFAULT 1,
	PRIMARY KEY (MaLop, MaHV)
)

INSERT INTO KetQua(MaLop, MaHV, Nghe, Noi, Doc, Viet) VALUES('LOP01', 'HV01', 9, 9, 9, 9)
INSERT INTO KetQua(MaLop, MaHV, Nghe, Noi, Doc, Viet) VALUES('LOP01', 'HV02', 1, 2, 3, 4)
INSERT INTO KetQua(MaLop, MaHV, Nghe, Noi, Doc, Viet) VALUES('LOP01', 'HV03', 6, 8, 4, 5)
INSERT INTO KetQua(MaLop, MaHV, Nghe, Noi, Doc, Viet) VALUES('LOP01', 'HV04', 8, 7, 5, 0)
INSERT INTO KetQua(MaLop, MaHV, Nghe, Noi, Doc, Viet) VALUES('LOP01', 'HV05', 9, 0, 5, 1)
INSERT INTO KetQua(MaLop, MaHV, Nghe, Noi, Doc, Viet) VALUES('LOP01', 'HV06', 7, 4, 6, 2)
INSERT INTO KetQua(MaLop, MaHV, Nghe, Noi, Doc, Viet) VALUES('LOP02', 'HV01', 7, 5, 8, 5)
INSERT INTO KetQua(MaLop, MaHV, Nghe, Noi, Doc, Viet) VALUES('LOP02', 'HV03', 5, 5, 5, 5)
INSERT INTO KetQua(MaLop, MaHV, Nghe, Noi, Doc, Viet) VALUES('LOP02', 'HV05', 2, 3, 4, 5)