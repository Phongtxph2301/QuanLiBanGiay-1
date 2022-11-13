using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface IChucVureposiries
    {
        bool Add(ChucVu obj);
        bool Update(ChucVu obj);
        bool Delete(ChucVu obj);
        ChucVu GetById(Guid id);//Phương thức này lấy theo id
        List<ChucVu> GetAll();
    }
}
