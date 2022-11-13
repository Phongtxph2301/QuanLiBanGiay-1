namespace B_BUS.View_Models
{
    public class QLHoaDonChiTietView
    {
        //hoa don chi tiet
        public Guid IdHDCT { get; set; }
        public Guid IdChiTietGiay { get; set; }
        public Guid IdHoaDon { get; set; }
        public float DonGia { get; set; } = 0!;
        public int TrangThaiHDCT { get; set; } = 0!;

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
        //chi tiet giay
        public Guid IdCTG { get; set; }
        public Guid IdMauSac { get; set; }
        public Guid IdNsx { get; set; }
        public Guid IdSize { get; set; }
        public Guid IdHangGiay { get; set; }
        public Guid IdChieuCaoDeGiay { get; set; }
        public Guid IdGiay { get; set; }
        public string MoTa { get; set; } = null!;
        public float GiaBan { get; set; } = 0!;
        public float GiaNhap { get; set; } = 0!;
        public int SoLuongTon { get; set; } = 0!;
        public int TrangThaiCTG { get; set; } = 0!;
    }
}
