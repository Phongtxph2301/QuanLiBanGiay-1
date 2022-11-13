using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLNsxViewServices : IQLNsxViewServices
    {
        private readonly INsxRepositories _Nsxrp;
        private readonly List<Nsx> _list;
        public QLNsxViewServices()
        {
            _Nsxrp = new NsxRepositories();
            _list = new List<Nsx>();
        }
        public string Add(QLNsxView khv)
        {
            //ADD
            Nsx kh = new()
            {
                Id = khv.Id,
                MaNsx = khv.MaNsx,
                TenNsx = khv.TenNsx,
                DiaChi = khv.DiaChi,

            };
            return _Nsxrp.Add(kh) ? "thêm thành công" : "thêm thất bại";
        }

        public string Update(QLNsxView khv)
        {
            //Update
            Nsx? x = _Nsxrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaNsx = khv.MaNsx;
            x.TenNsx = khv.TenNsx;
            x.DiaChi = khv.DiaChi;

            return _Nsxrp.Update(x) ? "sửa thành công" : "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            Nsx? x = _Nsxrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            return _Nsxrp.Delete(x) ? "Xóa Thành Công" : "Xóa thất Bại";
        }

        public List<QLNsxView> Getall()
        {
            //Getall
            return (from a in _Nsxrp.GetAll()
                    select new QLNsxView()
                    {
                        Id = a.Id,
                        MaNsx = a.MaNsx,
                        TenNsx = a.TenNsx,
                        DiaChi = a.DiaChi,

                    }).ToList();
        }
    }
}
