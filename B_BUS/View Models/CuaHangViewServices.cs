using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;

namespace B_BUS.View_Models
{
    public class CuaHangViewServices : IQLCuaHangViewservices
    {
        private readonly ICuaHangRepositories _chrp;

        public CuaHangViewServices()
        {
            _chrp = new CuaHangrepositories();
        }

        public string Add(QLCuaHangView khv)
        {
            //ADD
            CuaHang kh = new()
            {
                Id = khv.Id,
                MaCuaHang = khv.MaCuaHang,
                TenCuaHang = khv.TenCuaHang,
                DiaChi = khv.DiaChi,
                TrangThai = khv.TrangThai,


            };
            return _chrp.Add(kh) ? "thêm thành công" : "thêm thất bại";
        }

        public string Update(QLCuaHangView khv)
        {
            //Update
            CuaHang? x = _chrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            x.Id = khv.Id;

            x.MaCuaHang = khv.MaCuaHang;
            x.TenCuaHang = khv.TenCuaHang;
            x.TrangThai = khv.TrangThai;

            return _chrp.Update(x) ? "sửa thành công" : "sửa thất bại";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            CuaHang? x = _chrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            return _chrp.Delete(x) ? "Xóa Thành Công" : "Xóa thất Bại";
        }

        public List<QLCuaHangView> Getall()
        {
            //Getall
            return (from a in _chrp.GetAll()
                    select new QLCuaHangView()
                    {
                        Id = a.Id,
                        MaCuaHang = a.MaCuaHang,
                        TenCuaHang = a.TenCuaHang,
                        DiaChi = a.DiaChi,
                        TrangThai = a.TrangThai,

                    }).ToList();
        }
    }
}
