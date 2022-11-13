namespace B_BUS.View_Models
{
    public class QLCuaHangView
    {
        public Guid Id { get; set; }

        public string MaCuaHang { get; set; } = null!;
        public string TenCuaHang { get; set; } = null!;
        public string DiaChi { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;
    }
}
