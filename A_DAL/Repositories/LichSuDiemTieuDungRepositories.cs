using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class LichSuDiemTieuDungRepositories : ILichSuDiemTieuDungRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public LichSuDiemTieuDungRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(LichSuDiemTieuDung obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.LichSuDiemTieuDung.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(LichSuDiemTieuDung obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            LichSuDiemTieuDung? tempobj = _dbContext.LichSuDiemTieuDung.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdHoaDon = obj.IdHoaDon;
            tempobj.IdDiemTieuDung = obj.IdDiemTieuDung;
            tempobj.IdQuyDoi = obj.IdQuyDoi;
            tempobj.GiaTriQuyDoi = obj.GiaTriQuyDoi;
            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(LichSuDiemTieuDung obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            LichSuDiemTieuDung? tempobj = _dbContext.LichSuDiemTieuDung.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public LichSuDiemTieuDung? GetById(Guid id)
        {
            return id == null ? null : _dbContext.LichSuDiemTieuDung.FirstOrDefault(x => x.Id == id);
        }

        public List<LichSuDiemTieuDung> GetAll()
        {
            return _dbContext.LichSuDiemTieuDung.ToList();
        }
    }
}
