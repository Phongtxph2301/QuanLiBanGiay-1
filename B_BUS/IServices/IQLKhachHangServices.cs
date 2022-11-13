using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLKhachHangServices
    {
        string Add(QLKhachHangView khv);
        string Update(QLKhachHangView khv);
        string Delete(QLKhachHangView khv);
        List<QLKhachHangView> Getall();
    }
}
