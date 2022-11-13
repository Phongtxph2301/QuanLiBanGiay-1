using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class SizeRepositories : ISizeRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public SizeRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(Size obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.Size.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(Size obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            Size? tempobj = _dbContext.Size.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaSize = obj.MaSize;
            tempobj.TenSize = obj.TenSize;
            tempobj.SoSize = obj.SoSize;
            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Size obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            Size? tempobj = _dbContext.Size.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public Size? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.Size.FirstOrDefault(x => x.Id == id);
        }

        public List<Size> GetAll()
        {
            return _dbContext.Size.ToList();
        }
    }
}
