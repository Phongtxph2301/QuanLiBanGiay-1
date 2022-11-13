using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IDiemTieuDungRepositories
    {
        bool Add(DiemTieuDung obj);
        bool Update(DiemTieuDung obj);
        bool Delete(DiemTieuDung obj);
        DiemTieuDung GetById(Guid id);//Phương thức này lấy theo id
        List<DiemTieuDung> GetAll();
    }
}
