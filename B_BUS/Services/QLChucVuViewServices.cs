using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChucVuViewServices : IQLChucVuViewServices
    {
        private readonly IChucVureposiries _cvrp;

        public QLChucVuViewServices()
        {
            _cvrp = new ChucVuRepositories();
        }
        public string Add(QLChucVuView khv)
        {
            //ADD
            ChucVu kh = new()
            {
                Id = khv.Id,
                MaChucVu = khv.MaChucVu,
                TenChucVu = khv.TenChucVu,
                TrangThai = khv.TrangThai,


            };
            return _cvrp.Add(kh) ? "thêm thành công" : "thêm thất bại";
        }

        public string Update(QLChucVuView khv)
        {
            //Update
            ChucVu? x = _cvrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaChucVu = khv.MaChucVu;
            x.TenChucVu = khv.TenChucVu;
            x.TrangThai = khv.TrangThai;

            return _cvrp.Update(x) ? "sửa thành công" : "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            ChucVu? x = _cvrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            return _cvrp.Delete(x) ? "Xóa Thành Công" : "Xóa thất Bại";
        }

        public List<QLChucVuView> Getall()
        {
            //Getall
            return (from a in _cvrp.GetAll()
                    select new QLChucVuView()
                    {
                        Id = a.Id,
                        MaChucVu = a.MaChucVu,
                        TenChucVu = a.TenChucVu,
                        TrangThai = a.TrangThai,

                    }).ToList();
        }
    }
}
