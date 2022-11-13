namespace B_BUS.View_Models
{
    public class QLKhachHangView
    {
        public Guid Id { get; set; }
        public string MaKhachHang { get; set; } = null!;
        public string TenKhachHang { get; set; } = null!;
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; } = null!;
        public string Sdt { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string SoCCCD { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;
    }
}
