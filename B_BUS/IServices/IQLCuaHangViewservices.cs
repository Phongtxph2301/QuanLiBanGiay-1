using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLCuaHangViewservices
    {
        string Add(QLCuaHangView khv);
        string Update(QLCuaHangView khv);
        string Delete(Guid idGuid);
        List<QLCuaHangView> Getall();
    }
}
