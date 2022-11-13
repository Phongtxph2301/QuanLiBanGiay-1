using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChiTietTheLoaiServices
    {
        string Add(QLChiTietTheLoaiView khv);
        string Update(QLChiTietTheLoaiView khv);
        string Delete(QLChiTietTheLoaiView khv);
        List<QLChiTietTheLoaiView> Getall();
    }
}
