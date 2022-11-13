namespace B_BUS.View_Models
{
    public class QLChiTietGiayView
    {
        //chi tiet giay
        public Guid IdCTG { get; set; }
        public Guid IdMauSac { get; set; }
        public Guid IdNsx { get; set; }
        public Guid IdSize { get; set; }
        public Guid IdHangGiay { get; set; }
        public Guid IdChieuCaoDeGiay { get; set; }
        public Guid IdGiay { get; set; }
        public string? MoTa { get; set; } = null!;
        public float GiaBan { get; set; } = 0!;
        public float GiaNhap { get; set; } = 0!;
        public int SoLuongTon { get; set; } = 0!;
        public int TrangThaiCTG { get; set; } = 0!;
        //mau sac
        public Guid IdMS { get; set; }
        public string MaMauSac { get; set; } = null!;
        public string TenMauSac { get; set; } = null!;
        public int TrangThaiMS { get; set; } = 0!;
        //nsx
        public Guid IdNSX { get; set; }
        public string MaNsx { get; set; } = null!;
        public string TenNsx { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        //size
        public Guid IdSIZE { get; set; }

        public string MaSize { get; set; } = null!;
        public string TenSize { get; set; } = null!;
        public int SoSize { get; set; } = 0!;
        public int TrangThaiSIZE { get; set; } = 0!;
        //giay
        public Guid IdGIAY { get; set; }
        public string MaGiay { get; set; } = null!;
        public string TenGiay { get; set; } = null!;
        public int TrangThaiGIAY { get; set; } = 0!;
        //hang giay
        public Guid IdHG { get; set; }
        public string MaHangGiay { get; set; } = null!;
        public string TenHangGiay { get; set; } = null!;
        public int TrangThaiHG { get; set; } = 0!;
        //chieu cao de giay
        public Guid IdCCDG { get; set; }
        public string MaKichCo { get; set; } = null!;
        public int KichCo { get; set; } = 0!;
        public int TrangThaiCCDG { get; set; } = 0!;
    }
}
