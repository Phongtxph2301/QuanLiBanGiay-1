using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface ICuaHangRepositories
    {
        bool Add(CuaHang obj);
        bool Update(CuaHang obj);
        bool Delete(CuaHang obj);
        CuaHang GetById(Guid id);//Phương thức này lấy theo id
        List<CuaHang> GetAll();
    }
}
