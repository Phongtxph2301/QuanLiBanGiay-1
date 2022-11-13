using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface INhanVienRepositories
    {
        bool Add(NhanVien obj);
        bool Update(NhanVien obj);
        bool Delete(NhanVien obj);
        NhanVien GetById(Guid id);//Phương thức này lấy theo id
        List<NhanVien> GetAll();
    }
}
