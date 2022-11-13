using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class HangGiayrepositories : IHangGiayRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public HangGiayrepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(HangGiay obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.HangGiay.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(HangGiay obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            HangGiay? tempobj = _dbContext.HangGiay.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaHangGiay = obj.MaHangGiay;
            tempobj.TenHangGiay = obj.TenHangGiay;
            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HangGiay obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            HangGiay? tempobj = _dbContext.HangGiay.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public HangGiay? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.HangGiay.FirstOrDefault(x => x.Id == id);
        }

        public List<HangGiay> GetAll()
        {
            return _dbContext.HangGiay.ToList();
        }
    }
}
