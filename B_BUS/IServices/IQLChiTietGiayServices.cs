using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChiTietGiayServices
    {
        string Add(QLChiTietGiayView khv);
        string Update(QLChiTietGiayView khv);
        string Delete(QLChiTietGiayView khv);
        List<QLChiTietGiayView> Getall();
    }
}
