using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLTheLoaiViewSerices : IQLTheLoaiViewServices
    {
        private readonly ITheLoaiRepositories _tlrp;

        public QLTheLoaiViewSerices()
        {
            _tlrp = new TheLoaiRepositories();
        }

        public string Add(QLTheLoaiView khv)
        {
            //ADD
            TheLoai kh = new()
            {
                Id = khv.Id,
                MaTheLoai = khv.MaTheLoai,
                TenTheLoai = khv.TenTheLoai,
                IdPhanCap = khv.IdPhanCap,
                TrangThai = khv.TrangThai,


            };
            return _tlrp.Add(kh) ? "thêm thành công" : "thêm thất bại";
        }

        public string Update(QLTheLoaiView khv)
        {
            //Update
            TheLoai? x = _tlrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaTheLoai = khv.MaTheLoai;
            x.TenTheLoai = khv.TenTheLoai;
            x.IdPhanCap = khv.IdPhanCap;
            x.TrangThai = khv.TrangThai;

            return _tlrp.Update(x) ? "sửa thành công" : "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            TheLoai? x = _tlrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            return _tlrp.Delete(x) ? "Xóa Thành Công" : "Xóa thất Bại";
        }

        public List<QLTheLoaiView> Getall()
        {
            //Getall
            return (from a in _tlrp.GetAll()
                    select new QLTheLoaiView()
                    {
                        Id = a.Id,
                        MaTheLoai = a.MaTheLoai,
                        TenTheLoai = a.TenTheLoai,
                        IdPhanCap = a.IdPhanCap,
                        TrangThai = a.TrangThai,

                    }).ToList();
        }
    }
}
