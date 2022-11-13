using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class ChieuCaoDeGiayRepositories : IChieuCaoDeGiayRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public ChieuCaoDeGiayRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }

        public bool Add(ChieuCaoDeGiay obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.ChieuCaoDeGiay.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChieuCaoDeGiay obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            ChieuCaoDeGiay? tempobj = _dbContext.ChieuCaoDeGiay.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaKichCo = obj.MaKichCo;
            tempobj.KichCo = obj.KichCo;

            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChieuCaoDeGiay obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            ChiTietGiay? tempobj = _dbContext.ChiTietGiay.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public ChieuCaoDeGiay? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.ChieuCaoDeGiay.FirstOrDefault(x => x.Id == id);
        }

        public List<ChieuCaoDeGiay> GetAll()
        {
            return _dbContext.ChieuCaoDeGiay.ToList();
        }
    }
}
