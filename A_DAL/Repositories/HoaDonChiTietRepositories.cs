using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class HoaDonChiTietRepositories : IHoaDonChiTietrepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public HoaDonChiTietRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(HoaDonChiTiet obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.HoaDonChiTiet.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(HoaDonChiTiet obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            HoaDonChiTiet? tempobj = _dbContext.HoaDonChiTiet.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdChiTietGiay = obj.IdChiTietGiay;
            tempobj.IdHoaDon = obj.IdHoaDon;
            tempobj.DonGia = obj.DonGia;

            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            HoaDonChiTiet? tempobj = _dbContext.HoaDonChiTiet.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public HoaDonChiTiet? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.HoaDonChiTiet.FirstOrDefault(x => x.Id == id);
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _dbContext.HoaDonChiTiet.ToList();
        }
    }
}
