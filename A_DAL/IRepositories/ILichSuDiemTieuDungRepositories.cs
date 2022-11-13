using A_DAL.Entities;

namespace A_DAL.IRepositories
{
    public interface ILichSuDiemTieuDungRepositories
    {
        bool Add(LichSuDiemTieuDung obj);
        bool Update(LichSuDiemTieuDung obj);
        bool Delete(LichSuDiemTieuDung obj);
        LichSuDiemTieuDung GetById(Guid id);//Phương thức này lấy theo id
        List<LichSuDiemTieuDung> GetAll();
    }
}
