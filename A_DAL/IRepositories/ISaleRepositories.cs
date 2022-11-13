using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    internal interface ISaleRepositories
    {
        bool Add(Sale obj);
        bool Update(Sale obj);
        bool Delete(Sale obj);
        Sale GetByiD(Guid id);
        List<Sale> GetAll();
    }
}
