using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class MauSacrepositories : IMauSacRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public MauSacrepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(MauSac obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.MauSac.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(MauSac obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            MauSac? tempobj = _dbContext.MauSac.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaMauSac = obj.MaMauSac;
            tempobj.TenMauSac = obj.TenMauSac;

            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(MauSac obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            MauSac? tempobj = _dbContext.MauSac.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public MauSac? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.MauSac.FirstOrDefault(x => x.Id == id);
        }

        public List<MauSac> GetAll()
        {
            return _dbContext.MauSac.ToList();
        }
    }
}
