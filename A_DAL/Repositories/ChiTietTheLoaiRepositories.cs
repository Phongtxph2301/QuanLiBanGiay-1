using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class ChiTietTheLoaiRepositories : IChiTietTheLoai
    {
        private readonly NahidaShoesDbContext _dbContext;

        public ChiTietTheLoaiRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(ChiTietTheLoai obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.ChiTietTheLoai.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(ChiTietTheLoai obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            ChiTietTheLoai? tempobj = _dbContext.ChiTietTheLoai.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdTheLoai = obj.IdTheLoai;
            tempobj.IdChiTietGiay = obj.IdChiTietGiay;
            tempobj.TrangThai = obj.TrangThai;

            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(ChiTietTheLoai obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            ChiTietTheLoai? tempobj = _dbContext.ChiTietTheLoai.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public ChiTietTheLoai? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.ChiTietTheLoai.FirstOrDefault(x => x.Id == id);
        }

        public List<ChiTietTheLoai> GetAll()
        {
            return _dbContext.ChiTietTheLoai.ToList();
        }
    }
}
