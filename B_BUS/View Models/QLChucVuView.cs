namespace B_BUS.View_Models
{
    public class QLChucVuView
    {
        public Guid Id { get; set; }

        public string MaChucVu { get; set; } = null!;
        public string TenChucVu { get; set; } = null!;
        public int TrangThai { get; set; } = 0!;
    }
}
