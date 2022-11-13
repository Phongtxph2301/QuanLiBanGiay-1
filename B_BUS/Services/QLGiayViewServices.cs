using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLGiayViewServices : IQLGiayViewServices
    {
        private readonly IGiayRepositories _giayrp;

        public QLGiayViewServices()
        {
            _giayrp = new GiayRepositories();
        }
        public string Add(QLGiayView khv)
        {
            //ADD
            Giay kh = new()
            {
                Id = khv.Id,
                MaGiay = khv.MaGiay,
                TenGiay = khv.TenGiay,
                TrangThai = khv.TrangThai,


            };
            return _giayrp.Add(kh) ? "thêm thành công" : "thêm thất bại";
        }

        public string Update(QLGiayView khv)
        {
            //Update
            Giay? x = _giayrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaGiay = khv.MaGiay;
            x.TenGiay = khv.TenGiay;
            x.TrangThai = khv.TrangThai;

            return _giayrp.Update(x) ? "sửa thành công" : "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            Giay? x = _giayrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            return _giayrp.Delete(x) ? "Xóa Thành Công" : "Xóa thất Bại";
        }

        public List<QLGiayView> Getall()
        {
            //Getall
            return (from a in _giayrp.GetAll()
                    select new QLGiayView()
                    {
                        Id = a.Id,
                        MaGiay = a.MaGiay,
                        TenGiay = a.TenGiay,
                        TrangThai = a.TrangThai,

                    }).ToList();
        }
    }
}
