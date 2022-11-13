namespace B_BUS.View_Models
{
    public class QLSizeView
    {
        public Guid Id { get; set; }

        public string MaSize { get; set; } = null!;
        public string TenSize { get; set; } = null!;
        public int SoSize { get; set; } = 0!;
        public int TrangThai { get; set; } = 0!;
    }
}
