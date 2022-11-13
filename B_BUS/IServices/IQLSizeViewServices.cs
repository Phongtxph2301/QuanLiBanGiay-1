using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLSizeViewServices
    {
        string Add(QLSizeView khv);
        string Update(QLSizeView khv);
        string Delete(Guid idGuid);
        List<QLSizeView> Getall();
    }
}
