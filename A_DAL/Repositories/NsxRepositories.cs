using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class NsxRepositories : INsxRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;
        public NsxRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(Nsx obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.Nsx.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(Nsx obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            Nsx? tempobj = _dbContext.Nsx.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.DiaChi = obj.DiaChi;
            tempobj.MaNsx = obj.MaNsx;
            tempobj.TenNsx = obj.TenNsx;


            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Nsx obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            Nsx? tempobj = _dbContext.Nsx.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public Nsx? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.Nsx.FirstOrDefault(x => x.Id == id);
        }

        public List<Nsx> GetAll()
        {
            return _dbContext.Nsx.ToList();
        }
    }
}
