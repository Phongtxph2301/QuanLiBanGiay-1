using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLHoaDonServices
    {
        string Add(QLHoaDonView khv);
        string Update(QLHoaDonView khv);
        string Delete(QLHoaDonView khv);
        List<QLHoaDonView> Getall();
    }
}
