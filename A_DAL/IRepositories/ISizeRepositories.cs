using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface ISizeRepositories
    {
        bool Add(Size obj);
        bool Update(Size obj);
        bool Delete(Size obj);
        Size GetByiD(Guid id);
        List<Size> GetAll();
    }
}
