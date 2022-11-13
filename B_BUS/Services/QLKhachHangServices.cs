using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLKhachHangServices : IQLKhachHangServices
    {
        private readonly IKhachHangRepsitories _iKhachHangRepsitories;

        public QLKhachHangServices()
        {
            _iKhachHangRepsitories = new KhachHangRepositories();
        }
        public string Add(QLKhachHangView khv)
        {
            if (khv == null)
            {
                return "thêm không thành công";
            }

            KhachHang b = new()
            {
                DiaChi = khv.DiaChi,
                Email = khv.Email,
                MaKhachHang = khv.MaKhachHang,
                TenKhachHang = khv.TenKhachHang,
                NgaySinh = khv.NgaySinh,
                Sdt = khv.Sdt,
                SoCCCD = khv.SoCCCD,
                TrangThai = khv.TrangThai,

            };
            return _iKhachHangRepsitories.Add(b) ? "thêm thành công" : "thêm thành công";
        }

        public string Update(QLKhachHangView khv)
        {
            if (khv == null)
            {
                return "sửa không thành công";
            }

            KhachHang b = new()
            {
                Id = khv.Id,
                DiaChi = khv.DiaChi,
                Email = khv.Email,
                MaKhachHang = khv.MaKhachHang,
                TenKhachHang = khv.TenKhachHang,
                NgaySinh = khv.NgaySinh,
                Sdt = khv.Sdt,
                SoCCCD = khv.SoCCCD,
                TrangThai = khv.TrangThai,

            };
            return _iKhachHangRepsitories.Update(b) ? "sửa thành công" : "sửa thành công";
        }

        public string Delete(QLKhachHangView khv)
        {
            if (khv == null)
            {
                return "xóa không thành công";
            }

            KhachHang b = new()
            {
                Id = khv.Id,
                DiaChi = khv.DiaChi,
                Email = khv.Email,
                MaKhachHang = khv.MaKhachHang,
                TenKhachHang = khv.TenKhachHang,
                NgaySinh = khv.NgaySinh,
                Sdt = khv.Sdt,
                SoCCCD = khv.SoCCCD,
                TrangThai = khv.TrangThai,

            };
            return _iKhachHangRepsitories.Delete(b) ? "xóa thành công" : "xóa thành công";
        }

        public List<QLKhachHangView> Getall()
        {
            List<QLKhachHangView> lstKhachHangViews = new();
            lstKhachHangViews = (from a in _iKhachHangRepsitories.GetAll()
                                 select new QLKhachHangView()
                                 {
                                     Id = a.Id,
                                     DiaChi = a.DiaChi,
                                     Email = a.Email,
                                     MaKhachHang = a.MaKhachHang,
                                     TenKhachHang = a.TenKhachHang,
                                     NgaySinh = a.NgaySinh,
                                     Sdt = a.Sdt,
                                     SoCCCD = a.SoCCCD,
                                     TrangThai = a.TrangThai,
                                 }).ToList();
            return lstKhachHangViews;
        }
    }
}
