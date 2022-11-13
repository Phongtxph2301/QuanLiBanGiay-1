using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLHoaDonServices : IQLHoaDonServices
    {
        public IHoaDonRepositories _IHoaDonRepositories;
        public IKhachHangRepsitories _iKhachHangRepsitories;
        public INhanVienRepositories _inhanVienRepositories;
        public QLHoaDonServices()
        {
            _IHoaDonRepositories = new HoaDonRepositories();
            _iKhachHangRepsitories = new KhachHangRepositories();
            _inhanVienRepositories = new NhanVienRepositories();
        }
        public string Add(QLHoaDonView khv)
        {
            if (khv == null)
            {
                return "thêm không thành công";
            }

            HoaDon b = new()
            {
                MaHoaDon = khv.MaHoaDon,
                ThoiGianTao = khv.ThoiGianTao,
                ThoiGianThanhToan = khv.ThoiGianThanhToan,
                IdKhachHang = khv.IdKhachHang,
                IdNhanVien = khv.IdNhanVien,
                GiamGia = khv.GiamGia,
                GhiChu = khv.GhiChu,
                TrangThai = khv.TrangThaiHD

            };
            return _IHoaDonRepositories.Add(b) ? "thêm thành công" : "thêm thành công";
        }

        public string Update(QLHoaDonView khv)
        {
            if (khv == null)
            {
                return "sửa không thành công";
            }

            HoaDon b = new()
            {
                Id = khv.IdHD,
                MaHoaDon = khv.MaHoaDon,
                ThoiGianTao = khv.ThoiGianTao,
                ThoiGianThanhToan = khv.ThoiGianThanhToan,
                IdKhachHang = khv.IdKhachHang,
                IdNhanVien = khv.IdNhanVien,
                GiamGia = khv.GiamGia,
                GhiChu = khv.GhiChu,
                TrangThai = khv.TrangThaiHD

            };
            return _IHoaDonRepositories.Update(b) ? "sửa thành công" : "sửa thành công";
        }

        public string Delete(QLHoaDonView khv)
        {
            if (khv == null)
            {
                return "xóa không thành công";
            }

            HoaDon b = new()
            {
                Id = khv.IdHD,
                MaHoaDon = khv.MaHoaDon,
                ThoiGianTao = khv.ThoiGianTao,
                ThoiGianThanhToan = khv.ThoiGianThanhToan,
                IdKhachHang = khv.IdKhachHang,
                IdNhanVien = khv.IdNhanVien,
                GiamGia = khv.GiamGia,
                GhiChu = khv.GhiChu,
                TrangThai = khv.TrangThaiHD

            };
            return _IHoaDonRepositories.Delete(b) ? "xóa thành công" : "xóa thành công";
        }

        public List<QLHoaDonView> Getall()
        {
            List<QLHoaDonView> lstHoaDonViews = new();
            lstHoaDonViews = (from a in _IHoaDonRepositories.GetAll()
                              join b in _iKhachHangRepsitories.GetAll() on a.IdKhachHang equals b.Id
                              join c in _inhanVienRepositories.GetAll() on a.IdNhanVien equals c.Id
                              select new QLHoaDonView()
                              {

                              }).ToList();
            return lstHoaDonViews;
        }
    }
}
