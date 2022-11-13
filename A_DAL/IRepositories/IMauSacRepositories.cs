using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IMauSacRepositories
    {
        bool Add(MauSac obj);
        bool Update(MauSac obj);
        bool Delete(MauSac obj);
        MauSac GetByiD(Guid id);
        List<MauSac> GetAll();
    }
}
