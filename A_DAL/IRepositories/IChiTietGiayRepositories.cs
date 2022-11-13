using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IChiTietGiayRepositories
    {
        bool Add(ChiTietGiay obj);
        bool Update(ChiTietGiay obj);
        bool Delete(ChiTietGiay obj);
        ChiTietGiay GetByiD(Guid id);
        List<ChiTietGiay> GetAll();
    }
}
