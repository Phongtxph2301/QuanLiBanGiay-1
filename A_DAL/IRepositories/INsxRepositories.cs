using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface INsxRepositories
    {
        bool Add(Nsx obj);
        bool Update(Nsx obj);
        bool Delete(Nsx obj);
        Nsx GetByiD(Guid id);
        List<Nsx> GetAll();
    }
}
