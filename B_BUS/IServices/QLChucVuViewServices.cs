using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface QLChucVuViewServices
    {
        string Add(QLChucVuView khv);
        string Update(QLChucVuView khv);
        string Delete(Guid idGuid);
        List<QLChucVuView> Getall();
    }
}
