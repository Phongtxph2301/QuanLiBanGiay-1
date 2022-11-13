using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLNsxViewServices
    {
        string Add(QLNsxView khv);
        string Update(QLNsxView khv);
        string Delete(Guid idGuid);
        List<QLNsxView> Getall();
    }
}
