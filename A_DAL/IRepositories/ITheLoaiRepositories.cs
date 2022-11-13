using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface ITheLoaiRepositories
    {
        bool Add(TheLoai obj);
        bool Update(TheLoai obj);
        bool Delete(TheLoai obj);
        TheLoai GetByiD(Guid id);
        List<TheLoai> GetAll();

    }
}
