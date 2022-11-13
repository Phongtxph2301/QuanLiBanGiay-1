using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLMauSacViewServices : IQLMauSacViewServices
    {
        private readonly IMauSacRepositories _MauSacRp;
        private readonly List<QLMauSacview> _ListMauView;

        public QLMauSacViewServices()
        {
            _MauSacRp = new MauSacrepositories();
            _ListMauView = new List<QLMauSacview>();
        }

        public string Add(QLMauSacview khv)
        {
            //ADD
            MauSac kh = new()
            {
                Id = khv.Id,
                MaMauSac = khv.MaMauSac,
                TenMauSac = khv.TenMauSac,
                TrangThai = khv.TrangThai,


            };
            return _MauSacRp.Add(kh) ? "thêm thành công" : "thêm thất bại";
        }

        public string Update(QLMauSacview khv)
        {
            //Update
            MauSac? x = _MauSacRp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaMauSac = khv.MaMauSac;
            x.TenMauSac = khv.TenMauSac;
            x.TrangThai = khv.TrangThai;

            return _MauSacRp.Update(x) ? "sửa thành công" : "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            MauSac? x = _MauSacRp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            return _MauSacRp.Delete(x) ? "Xóa Thành Công" : "Xóa thất Bại";
        }

        public List<QLMauSacview> Getall()
        {
            //Getall
            return (from a in _MauSacRp.GetAll()
                    select new QLMauSacview()
                    {
                        Id = a.Id,
                        MaMauSac = a.MaMauSac,
                        TenMauSac = a.TenMauSac,
                        TrangThai = a.TrangThai,

                    }).ToList();
        }
    }
}
