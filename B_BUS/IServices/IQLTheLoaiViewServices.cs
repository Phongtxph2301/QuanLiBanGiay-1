using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLTheLoaiViewServices
    {
        string Add(QLTheLoaiView khv);
        string Update(QLTheLoaiView khv);
        string Delete(Guid idGuid);
        List<QLTheLoaiView> Getall();
    }
}
