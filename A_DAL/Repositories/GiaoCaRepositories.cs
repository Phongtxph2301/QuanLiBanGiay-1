using A_DAL.Context;
using A_DAL.Entities;
using A_DAL.IRepositories;

namespace A_DAL.Repositories
{
    public class GiaoCaRepositories : IGiaoCaRepositories
    {
        private readonly NahidaShoesDbContext _dbContext;

        public GiaoCaRepositories()
        {
            _dbContext = new NahidaShoesDbContext();
        }
        public bool Add(GiaoCa obj)
        {
            //add
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            _ = _dbContext.GiaoCa.Add(obj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Update(GiaoCa obj)
        {
            //Update
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            GiaoCa? tempobj = _dbContext.GiaoCa.FirstOrDefault(x => x.Id == obj.Id);
            tempobj.IdNhanVien = obj.IdNhanVien;
            tempobj.ThoiGianBatDau = obj.ThoiGianBatDau;
            tempobj.ThoiGianBatDau = obj.ThoiGianBatDau;
            tempobj.ThoiGianKetThuc = obj.ThoiGianKetThuc;
            tempobj.TienLai = obj.TienLai;
            tempobj.TienDuTru = obj.TienDuTru;
            tempobj.TienPhatSinh = obj.TienPhatSinh;
            tempobj.ChuThich = obj.ChuThich;
            tempobj.TrangThai = obj.TrangThai;
            _ = _dbContext.Update(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public bool Delete(GiaoCa obj)
        {
            //Delete
            if (obj == null)
            {
                return false;
            }
            //  obj.Id=Guid.NewGuid();// Tự Động Gen khóa Chính
            GiaoCa? tempobj = _dbContext.GiaoCa.FirstOrDefault(x => x.Id == obj.Id);
            _ = _dbContext.Remove(tempobj);
            _ = _dbContext.SaveChanges();
            return true;
        }

        public GiaoCa? GetByiD(Guid id)
        {
            return id == null ? null : _dbContext.GiaoCa.FirstOrDefault(x => x.Id == id);
        }

        public List<GiaoCa> GetAll()
        {
            return _dbContext.GiaoCa.ToList();
        }
    }
}
