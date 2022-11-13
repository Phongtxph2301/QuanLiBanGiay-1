namespace B_BUS.View_Models
{
    public class QLHoaDonView
    {
        //hoa don
        public Guid IdHD { get; set; }
        public string MaHoaDon { get; set; } = null!;
        public DateTime ThoiGianTao { get; set; }
        public DateTime ThoiGianThanhToan { get; set; }
        public Guid IdKhachHang { get; set; }
        public Guid IdNhanVien { get; set; }
        public float GiamGia { get; set; } = 0!;
        public string GhiChu { get; set; } = null!;
        public int TrangThaiHD { get; set; } = 0!;


        //khach hang

        public Guid IdKH { get; set; }
        public string MaKhachHang { get; set; } = null!;
        public string TenKhachHang { get; set; } = null!;
        public DateTime NgaySinhKH { get; set; }
        public string DiaChiKH { get; set; } = null!;
        public string SdtKH { get; set; } = null!;
        public string EmailKH { get; set; } = null!;
        public string SoCCCDKH { get; set; } = null!;
        public int TrangThaiKH { get; set; } = 0!;
        //nhan vien
        public Guid IdNV { get; set; }
        public Guid IdChucVu { get; set; }
        public Guid IdCuaHang { get; set; }
        public string MaNhanVien { get; set; } = null!;
        public string TenNhanVien { get; set; } = null!;
        public string MatKhauNV { get; set; } = null!;
        public DateTime NgaySinhNV { get; set; }
        public string DiaChiNV { get; set; } = null!;
        public string EmailNV { get; set; } = null!;
        public string SdtNV { get; set; } = null!;
        public int GioiTinhNV { get; set; } = 0!;
        public int TrangThaiNv { get; set; } = 0!;
    }
}
