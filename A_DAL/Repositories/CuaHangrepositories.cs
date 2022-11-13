using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class CuaHangrepositories : ICuaHangRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public CuaHangrepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(CuaHang obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.CuaHang.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(CuaHang obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            CuaHang? tempobj = _dbContext.CuaHang.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.DiaChi = obj.DiaChi;
            tempobj.MaCuaHang = obj.MaCuaHang;
            tempobj.TenCuaHang = obj.TenCuaHang;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(CuaHang obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            CuaHang? tempobj = _dbContext.CuaHang.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public CuaHang? GetById(Guid id)
        {
            return id == null ? null : _dbContext.CuaHang.FirstOrDefault(x => x.Id == id);
        }

        public List<CuaHang> GetAll()
        {
            return _dbContext.CuaHang.ToList();
        }
    }
}
