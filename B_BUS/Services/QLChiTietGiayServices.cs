using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChiTietGiayServices : IQLChiTietGiayServices
    {
        public IChiTietGiayRepositories _IChiTietGiayRepositories;
        public IMauSacRepositories _IMauSacRepositories;
        public INsxRepositories _INsxRepositories;
        public ISizeRepositories _ISizeRepositories;
        public IGiayRepositories _IGiayRepositories;
        public IHangGiayRepositories _IHangGiayRepositories;
        public IChieuCaoDeGiayRepositories _IChieuCaoDeGiayRepositories;

        public QLChiTietGiayServices()
        {
            _IChieuCaoDeGiayRepositories = new ChieuCaoDeGiayRepositories();
            _IMauSacRepositories = new MauSacrepositories();
            _IChiTietGiayRepositories = new ChiTietGiayRepositories();
            _IGiayRepositories = new GiayRepositories();
            _IHangGiayRepositories = new HangGiayrepositories();
            _ISizeRepositories = new SizeRepositories();
            _INsxRepositories = new NsxRepositories();
        }
        public string Add(QLChiTietGiayView khv)
        {
            if (khv == null)
            {
                return "thêm không thành công";
            }

            ChiTietGiay b = new()
            {

                IdMauSac = khv.IdMauSac,
                IdNsx = khv.IdNsx,
                IdSize = khv.IdSize,
                IdHangGiay = khv.IdHangGiay,
                IdChieuCaoDeGiay = khv.IdChieuCaoDeGiay,
                IdGiay = khv.IdGiay,
                MoTa = khv.MoTa,
                GiaBan = khv.GiaBan,
                GiaNhap = khv.GiaNhap,
                SoLuongTon = khv.SoLuongTon,
                TrangThai = khv.TrangThaiCTG,

            };
            return _IChiTietGiayRepositories.Add(b) ? "thêm thành công" : "thêm thành công";
        }

        public string Update(QLChiTietGiayView khv)
        {
            if (khv == null)
            {
                return "sửa không thành công";
            }

            ChiTietGiay b = new()
            {
                Id = khv.IdCTG,
                IdMauSac = khv.IdMauSac,
                IdNsx = khv.IdNsx,
                IdSize = khv.IdSize,
                IdHangGiay = khv.IdHangGiay,
                IdChieuCaoDeGiay = khv.IdChieuCaoDeGiay,
                IdGiay = khv.IdGiay,
                MoTa = khv.MoTa,
                GiaBan = khv.GiaBan,
                GiaNhap = khv.GiaNhap,
                SoLuongTon = khv.SoLuongTon,
                TrangThai = khv.TrangThaiCTG,

            };
            return _IChiTietGiayRepositories.Update(b) ? "sửa thành công" : "sửa thành công";
        }

        public string Delete(QLChiTietGiayView khv)
        {
            if (khv == null)
            {
                return "xóa không thành công";
            }

            ChiTietGiay b = new()
            {
                Id = khv.IdCTG,
                IdMauSac = khv.IdMauSac,
                IdNsx = khv.IdNsx,
                IdSize = khv.IdSize,
                IdHangGiay = khv.IdHangGiay,
                IdChieuCaoDeGiay = khv.IdChieuCaoDeGiay,
                IdGiay = khv.IdGiay,
                MoTa = khv.MoTa,
                GiaBan = khv.GiaBan,
                GiaNhap = khv.GiaNhap,
                SoLuongTon = khv.SoLuongTon,
                TrangThai = khv.TrangThaiCTG,

            };
            return _IChiTietGiayRepositories.Delete(b) ? "xóa thành công" : "xóa thành công";
        }

        public List<QLChiTietGiayView> Getall()
        {
            List<QLChiTietGiayView> lstChiTietGiayView = new();
            lstChiTietGiayView = (from a in _IChiTietGiayRepositories.GetAll()
                                  join b in _IMauSacRepositories.GetAll() on a.IdMauSac equals b.Id
                                  join c in _INsxRepositories.GetAll() on a.IdNsx equals c.Id
                                  join d in _ISizeRepositories.GetAll() on a.IdSize equals d.Id
                                  join e in _IGiayRepositories.GetAll() on a.IdGiay equals e.Id
                                  join f in _IHangGiayRepositories.GetAll() on a.IdHangGiay equals f.Id
                                  join g in _IChieuCaoDeGiayRepositories.GetAll() on a.IdChieuCaoDeGiay equals g.Id
                                  select new QLChiTietGiayView()
                                  {
                                      IdCTG = a.Id,
                                      TenGiay = e.TenGiay,
                                      TenMauSac = b.TenMauSac,
                                      TenHangGiay = f.TenHangGiay,
                                      TenNsx = c.TenNsx,
                                      SoSize = d.SoSize,
                                      KichCo = g.KichCo,
                                      GiaNhap = a.GiaNhap,
                                      GiaBan = a.GiaBan,
                                      SoLuongTon = a.SoLuongTon,
                                      MoTa = a.MoTa,
                                  }).ToList();
            return lstChiTietGiayView;
        }
    }
}
