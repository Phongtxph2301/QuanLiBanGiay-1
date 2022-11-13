using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class TheLoaiRepositories : ITheLoaiRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;
        public TheLoaiRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(TheLoai obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.TheLoai.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(TheLoai obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            TheLoai? tempobj = _dbContext.TheLoai.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaTheLoai = obj.MaTheLoai;
            tempobj.TenTheLoai = obj.TenTheLoai;
            tempobj.IdPhanCap = obj.IdPhanCap;
            tempobj.TrangThai = obj.TrangThai;


            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(TheLoai obj)
        {
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            TheLoai? tempobj = _dbContext.TheLoai.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public TheLoai? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.TheLoai.FirstOrDefault(x => x.Id == id);
        }

        public List<TheLoai> GetAll()
        {
            return _dbContext.TheLoai.ToList();
        }
    }
}
