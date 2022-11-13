using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class HoaDonRepositories : IHoaDonRepositories
    {
        public NahidaShoesDbContext _dbContext;

        public HoaDonRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }


        public bool Add(HoaDon obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.HoaDon.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(HoaDon obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            HoaDon? tempobj = _dbContext.HoaDon.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.MaHoaDon = obj.MaHoaDon;
            tempobj.ThoiGianTao = obj.ThoiGianThanhToan;
            tempobj.IdKhachHang = obj.IdKhachHang;
            tempobj.IdNhanVien = obj.IdNhanVien;
            tempobj.GiamGia = obj.GiamGia;
            tempobj.GhiChu = obj.GhiChu;
            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDon obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            HoaDon? tempobj = _dbContext.HoaDon.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public HoaDon? GetById(Guid id)
        {
            return id == null ? null : _dbContext.HoaDon.FirstOrDefault(x => x.Id == id);
        }

        public List<HoaDon> GetAll()
        {
            return _dbContext.HoaDon.ToList();
        }
    }
}
