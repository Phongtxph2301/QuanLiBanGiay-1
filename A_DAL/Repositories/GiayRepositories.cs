using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class GiayRepositories : IGiayRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public GiayRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(Giay obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.Giay.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(Giay obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            Giay? tempobj = _dbContext.Giay.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaGiay = obj.MaGiay;
            tempobj.TenGiay = obj.TenGiay;

            tempobj.TrangThai = obj.TrangThai;

            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Giay obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            Giay? tempobj = _dbContext.Giay.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public Giay? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.Giay.FirstOrDefault(x => x.Id == id);
        }

        public List<Giay> GetAll()
        {
            return _dbContext.Giay.ToList();
        }
    }
}
