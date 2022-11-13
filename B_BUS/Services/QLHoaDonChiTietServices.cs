using A_DAL.Entities;
using A_DAL.IRepositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLHoaDonChiTietServices : IQLHoaDonChiTietServices
    {
        public IHoaDonChiTietrepositories _IHoaDonChiTietrepositories;
        public IHoaDonRepositories _IHoaDonRepositories;
        public IChiTietGiayRepositories _iChiTietGiayRepositories;
        public QLHoaDonChiTietServices()
        {

        }
        public string Add(QLHoaDonChiTietView khv)
        {
            if (khv == null)
            {
                return "thêm không thành công";
            }

            HoaDonChiTiet b = new()
            {

                IdChiTietGiay = khv.IdChiTietGiay,
                IdHoaDon = khv.IdHoaDon,
                DonGia = khv.DonGia,
                TrangThai = khv.TrangThaiHDCT,

            };
            return _IHoaDonChiTietrepositories.Add(b) ? "thêm thành công" : "thêm thành công";
        }

        public string Update(QLHoaDonChiTietView khv)
        {
            if (khv == null)
            {
                return "sửa không thành công";
            }

            HoaDonChiTiet b = new()
            {
                Id = khv.IdHDCT,
                IdChiTietGiay = khv.IdChiTietGiay,
                IdHoaDon = khv.IdHoaDon,
                DonGia = khv.DonGia,
                TrangThai = khv.TrangThaiHDCT,

            };
            return _IHoaDonChiTietrepositories.Update(b) ? "sửa thành công" : "sửa thành công";
        }

        public string Delete(QLHoaDonChiTietView khv)
        {
            if (khv == null)
            {
                return "xóa không thành công";
            }

            HoaDonChiTiet b = new()
            {
                Id = khv.IdHDCT,
                IdChiTietGiay = khv.IdChiTietGiay,
                IdHoaDon = khv.IdHoaDon,
                DonGia = khv.DonGia,
                TrangThai = khv.TrangThaiHDCT,

            };
            return _IHoaDonChiTietrepositories.Delete(b) ? "xóa thành công" : "xóa thành công";
        }

        public List<QLHoaDonChiTietView> Getall()
        {
            List<QLHoaDonChiTietView> lstHoaDonViews = new();
            lstHoaDonViews = (from a in _IHoaDonChiTietrepositories.GetAll()
                              join b in _IHoaDonRepositories.GetAll() on a.IdHoaDon equals b.Id
                              join c in _iChiTietGiayRepositories.GetAll() on a.IdChiTietGiay equals c.Id
                              select new QLHoaDonChiTietView()
                              {

                              }).ToList();
            return lstHoaDonViews;
        }
    }
}
