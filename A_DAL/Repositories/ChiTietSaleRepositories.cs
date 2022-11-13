using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class ChiTietSaleRepositories : IChiTietSaleRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public ChiTietSaleRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(ChiTietSale obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.ChiTietSale.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChiTietSale obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            ChiTietSale? tempobj = _dbContext.ChiTietSale.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdSale = obj.IdSale;
            tempobj.IdChiTietGiay = obj.IdChiTietGiay;
            tempobj.TrangThai = obj.TrangThai;

            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietSale obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            ChiTietSale? tempobj = _dbContext.ChiTietSale.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public ChiTietSale? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.ChiTietSale.FirstOrDefault(x => x.Id == id);
        }

        public List<ChiTietSale> GetAll()
        {
            return _dbContext.ChiTietSale.ToList();
        }
    }
}
