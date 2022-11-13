using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class SaleRepositories : ISaleRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public SaleRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(Sale obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.Sale.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(Sale obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            Sale? tempobj = _dbContext.Sale.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaGiamGia = obj.MaGiamGia;
            tempobj.TenChuongTrinh = obj.TenChuongTrinh;
            tempobj.LuaChonGiamGia = obj.LuaChonGiamGia;
            tempobj.NgayBatDau = obj.NgayBatDau;
            tempobj.NgayKetThuc = obj.NgayKetThuc;
            tempobj.TrangThai = obj.TrangThai;

            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(Sale obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            Sale? tempobj = _dbContext.Sale.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public Sale? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.Sale.FirstOrDefault(x => x.Id == id);
        }

        public List<Sale> GetAll()
        {
            return _dbContext.Sale.ToList();
        }
    }
}
