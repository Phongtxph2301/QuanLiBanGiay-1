using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLSizeViewServices : IQLSizeViewServices
    {
        private readonly ISizeRepositories _sizerp;

        public QLSizeViewServices()
        {
            _sizerp = new SizeRepositories();
        }
        public string Add(QLSizeView khv)
        {
            //ADD
            Size kh = new()
            {
                Id = khv.Id,
                MaSize = khv.MaSize,
                TenSize = khv.TenSize,
                SoSize = khv.SoSize,
                TrangThai = khv.TrangThai,


            };
            return _sizerp.Add(kh) ? "thêm thành công" : "thêm thất bại";
        }

        public string Update(QLSizeView khv)
        {
            //Update
            Size? x = _sizerp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaSize = khv.MaSize;
            x.TenSize = khv.TenSize;
            x.SoSize = khv.SoSize;
            x.TrangThai = khv.TrangThai;

            return _sizerp.Update(x) ? "sửa thành công" : "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            Size? x = _sizerp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            return _sizerp.Delete(x) ? "Xóa Thành Công" : "Xóa thất Bại";
        }

        public List<QLSizeView> Getall()
        {
            //Getall
            return (from a in _sizerp.GetAll()
                    select new QLSizeView()
                    {
                        Id = a.Id,
                        MaSize = a.MaSize,
                        TenSize = a.TenSize,
                        TrangThai = a.TrangThai,

                    }).ToList();
        }
    }
}
