using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLHoaDonChiTietServices
    {
        string Add(QLHoaDonChiTietView khv);
        string Update(QLHoaDonChiTietView khv);
        string Delete(QLHoaDonChiTietView khv);
        List<QLHoaDonChiTietView> Getall();
    }
}
