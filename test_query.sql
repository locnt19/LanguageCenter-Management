Select DD.MaLop, DD.MaHV, HV.HoTen, L.PhongHoc, L.MaTKB, DD.SoNgayVang, KQ.Nghe, KQ.Noi, KQ.Doc, KQ.Viet From DiemDanh DD, Lop L, HocVien HV, KetQua KQ Where L.MaLop = 'LOP01' and DD.MaLop = L.MaLop and KQ.MaHV = HV.MaHV and L.MaLop = KQ.MaLop

Update KetQua Set Nghe=1, Noi=1, Doc=1, Viet=1 Where MaHV='HV02'

SELECT * FROM KetQua

Update DiemDanh Set SoNgayVang=10 Where MaHV='HV01' and MaLop='LOP01'
SELECT * FROM DiemDanh

SELECT BL.MaBienLai, BL.MaHV, CT.KhoaHoc, CT.HocPhi, BL.TongThanhToan, BL.NguoiLap, BL.NgayLap FROM BienLai BL, ChiTietBienLai CT WHERE BL.MaBienLai = CT.MaBienLai AND BL.MaBienLai = 'BL01'

SELECT BL.MaBienLai, BL.MaHV, HV.HoTen as HoTenHV, CT.KhoaHoc, CT.HocPhi, BL.TongThanhToan, BL.NguoiLap, NV.HoTen as HoTenNV, BL.NgayLap FROM HocVien HV, NhanVien NV, BienLai BL, ChiTietBienLai CT WHERE BL.MaBienLai = CT.MaBienLai AND BL.MaHV = HV.MaHV AND BL.NguoiLap = NV.MaNV AND ( BL.MaBienLai like '%toán 1%' OR HV.HoTen like '%toán 1%' OR NV.HoTen like '%toán 1%')

SELECT BL.MaBienLai, BL.MaHV, HV.HoTen as HoTenHV, CT.KhoaHoc, CT.HocPhi, BL.TongThanhToan, BL.NguoiLap, NV.HoTen as HoTenNV, BL.NgayLap FROM HocVien HV, NhanVien NV, BienLai BL, ChiTietBienLai CT WHERE BL.MaBienLai = CT.MaBienLai AND BL.MaHV = HV.MaHV AND BL.NguoiLap = NV.MaNV AND ( BL.MaBienLai like '%toán 1%' OR HV.HoTen like '%toán 1%' OR NV.HoTen like '%toán 1%')

select * from ChiTietBienLai