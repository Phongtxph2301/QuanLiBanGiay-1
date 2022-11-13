namespace B_BUS.View_Models
{
    public class QLChiTietTheLoaiView
    {
        //chi  tiet the loai
        public Guid IdCTTL { get; set; }
        public Guid IdTheLoai { get; set; }
        public Guid IdChiTietGiay { get; set; }
        public int TrangThaiCTTL { get; set; } = 0!;

        //the loai

        public Guid IdTL { get; set; }

        public string MaTheLoai { get; set; } = null!;
        public string TenTheLoai { get; set; } = null!;
        public Guid IdPhanCap { get; set; }
        public int TrangThaiTL { get; set; } = 0!;
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
