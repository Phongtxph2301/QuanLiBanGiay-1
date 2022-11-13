using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class ChucVuRepositories : IChucVureposiries
    {
        private readonly NahidaShoesDbContext _dbContext;

        public ChucVuRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(ChucVu obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.ChucVu.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChucVu obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            ChucVu? tempobj = _dbContext.ChucVu.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaChucVu = obj.MaChucVu;
            tempobj.TenChucVu = obj.TenChucVu;
            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChucVu obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            ChucVu? tempobj = _dbContext.ChucVu.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public ChucVu? GetById(Guid id)
        {
            return id == null ? null : _dbContext.ChucVu.FirstOrDefault(x => x.Id == id);
        }

        public List<ChucVu> GetAll()
        {
            return _dbContext.ChucVu.ToList();
        }
    }
}
