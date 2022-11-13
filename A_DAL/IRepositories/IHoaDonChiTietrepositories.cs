using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IHoaDonChiTietrepositories
    {
        bool Add(HoaDonChiTiet obj);
        bool Update(HoaDonChiTiet obj);
        bool Delete(HoaDonChiTiet obj);
        HoaDonChiTiet GetByiD(Guid id);
        List<HoaDonChiTiet> GetAll();
    }
}
