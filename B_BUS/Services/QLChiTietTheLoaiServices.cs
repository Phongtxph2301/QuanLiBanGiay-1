using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChiTietTheLoaiServices : IQLChiTietTheLoaiServices
    {
        public IChiTietTheLoai _IChiTietTheLoai;
        public ITheLoaiRepositories _ITheLoaiRepositories;
        public IChiTietGiayRepositories _IChiTietGiayRepositories;
        public QLChiTietTheLoaiServices()
        {
            _IChiTietTheLoai = new ChiTietTheLoaiRepositories();
            _ITheLoaiRepositories = new TheLoaiRepositories();
            _IChiTietGiayRepositories = new ChiTietGiayRepositories();
        }
        public string Add(QLChiTietTheLoaiView khv)
        {
            if (khv == null)
            {
                return "thêm không thành công";
            }

            ChiTietTheLoai b = new()
            {
                IdTheLoai = khv.IdTheLoai,
                IdChiTietGiay = khv.IdChiTietGiay,
                TrangThai = khv.TrangThaiCTTL,
            };
            return _IChiTietTheLoai.Add(b) ? "thêm thành công" : "thêm thành công";
        }

        public string Update(QLChiTietTheLoaiView khv)
        {
            if (khv == null)
            {
                return "sửa không thành công";
            }

            ChiTietTheLoai b = new()
            {
                Id = khv.IdCTTL,
                IdTheLoai = khv.IdTheLoai,
                IdChiTietGiay = khv.IdChiTietGiay,
                TrangThai = khv.TrangThaiCTTL,
            };
            return _IChiTietTheLoai.Update(b) ? "sửa thành công" : "sửa thành công";
        }

        public string Delete(QLChiTietTheLoaiView khv)
        {
            if (khv == null)
            {
                return "xóa không thành công";
            }

            ChiTietTheLoai b = new()
            {
                Id = khv.IdCTTL,
                IdTheLoai = khv.IdTheLoai,
                IdChiTietGiay = khv.IdChiTietGiay,
                TrangThai = khv.TrangThaiCTTL,
            };
            return _IChiTietTheLoai.Delete(b) ? "xóa thành công" : "xóa thành công";
        }

        public List<QLChiTietTheLoaiView> Getall()
        {
            List<QLChiTietTheLoaiView> lstHoaDonViews = new();
            lstHoaDonViews = (from a in _IChiTietTheLoai.GetAll()
                              join b in _ITheLoaiRepositories.GetAll() on a.IdTheLoai equals b.Id
                              join c in _IChiTietGiayRepositories.GetAll() on a.IdChiTietGiay equals c.Id
                              select new QLChiTietTheLoaiView()
                              {

                              }).ToList();
            return lstHoaDonViews;
        }
    }
}
