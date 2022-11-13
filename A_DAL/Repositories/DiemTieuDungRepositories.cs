using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class DiemTieuDungRepositories : IDiemTieuDungRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public DiemTieuDungRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(DiemTieuDung obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.DiemTieuDung.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(DiemTieuDung obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            DiemTieuDung? tempobj = _dbContext.DiemTieuDung.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaDiemTieuDung = obj.MaDiemTieuDung;
            tempobj.IdKhachHang = obj.IdKhachHang;
            tempobj.SoDiem = obj.SoDiem;
            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(DiemTieuDung obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            DiemTieuDung? tempobj = _dbContext.DiemTieuDung.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public DiemTieuDung? GetById(Guid id)
        {
            return id == null ? null : _dbContext.DiemTieuDung.FirstOrDefault(x => x.Id == id);
        }

        public List<DiemTieuDung> GetAll()
        {
            return _dbContext.DiemTieuDung.ToList();
        }
    }
}
