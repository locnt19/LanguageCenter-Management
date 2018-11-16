Select DD.MaLop, DD.MaHV, HV.HoTen, L.PhongHoc, L.MaTKB, DD.SoNgayVang, KQ.Nghe, KQ.Noi, KQ.Doc, KQ.Viet From DiemDanh DD, Lop L, HocVien HV, KetQua KQ Where L.MaLop = 'LOP01' and DD.MaLop = L.MaLop and KQ.MaHV = HV.MaHV and L.MaLop = KQ.MaLop

Update KetQua Set Nghe=1, Noi=1, Doc=1, Viet=1 Where MaHV='HV02'

SELECT * FROM KetQua

Update DiemDanh Set SoNgayVang=10 Where MaHV='HV01' and MaLop='LOP01'
SELECT * FROM DiemDanh