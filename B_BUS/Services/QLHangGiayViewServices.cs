using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLHangGiayViewServices : IQLHangGiayViewServices
    {
        private readonly IHangGiayRepositories _hanggiayrp;

        public QLHangGiayViewServices()
        {
            _hanggiayrp = new HangGiayrepositories();
        }
        public string Add(QLHangGiayView khv)
        {
            //ADD
            HangGiay kh = new()
            {
                Id = khv.Id,
                MaHangGiay = khv.MaHangGiay,
                TenHangGiay = khv.TenHangGiay,
                TrangThai = khv.TrangThai,


            };
            return _hanggiayrp.Add(kh) ? "thêm thành công" : "thêm thất bại";
        }

        public string Update(QLHangGiayView khv)
        {
            //Update
            HangGiay? x = _hanggiayrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaHangGiay = khv.MaHangGiay;
            x.TenHangGiay = khv.TenHangGiay;
            x.TrangThai = khv.TrangThai;

            return _hanggiayrp.Update(x) ? "sửa thành công" : "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            HangGiay? x = _hanggiayrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            return _hanggiayrp.Delete(x) ? "Xóa Thành Công" : "Xóa thất Bại";
        }

        public List<QLHangGiayView> Getall()
        {
            //Getall
            return (from a in _hanggiayrp.GetAll()
                    select new QLHangGiayView()
                    {
                        Id = a.Id,
                        MaHangGiay = a.MaHangGiay,
                        TenHangGiay = a.TenHangGiay,
                        TrangThai = a.TrangThai,

                    }).ToList();
        }
    }
}
