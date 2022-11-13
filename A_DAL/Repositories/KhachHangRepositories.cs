using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class KhachHangRepositories : IKhachHangRepsitories

    {
        private readonly NahidaShoesDbContext _dbContext;

        public KhachHangRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(KhachHang obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.KhachHang.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(KhachHang obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            KhachHang? tempobj = _dbContext.KhachHang.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaKhachHang = obj.MaKhachHang;
            tempobj.TenKhachHang = obj.TenKhachHang;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.Sdt = obj.Sdt;
            tempobj.Email = obj.Email;
            tempobj.SoCCCD = obj.SoCCCD;
            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(KhachHang obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            KhachHang? tempobj = _dbContext.KhachHang.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public KhachHang? GetById(Guid id)
        {
            return id == null ? null : _dbContext.KhachHang.FirstOrDefault(x => x.Id == id);
        }

        public List<KhachHang> GetAll()
        {
            return _dbContext.KhachHang.ToList();
        }
    }
}
