using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChieuCaoDeGiayViewServices : IQLChieuCaoDeGiayViewServices
    {
        private readonly IChieuCaoDeGiayRepositories _ccdgrp;

        public QLChieuCaoDeGiayViewServices()
        {
            _ccdgrp = new ChieuCaoDeGiayRepositories();
        }
        public string Add(QLChieuCaoDeGiayView khv)
        {
            //ADD
            ChieuCaoDeGiay kh = new()
            {
                //Id = khv.Id,
                //MaKichCo = khv.MaKichCo,
                //KichCo = khv.KichCo,
                //TrangThai = khv.TrangThai,


            };
            return _ccdgrp.Add(kh) ? "thêm thành công" : "thêm thất bại";
        }

        public string Update(QLChieuCaoDeGiayView khv)
        {
            ////Update
            //ChieuCaoDeGiay? x = _ccdgrp.GetAll().FirstOrDefault(c => c.Id == khv.Id);
            ////x.Id = khv.Id;

            ////x.MaKichCo = khv.MaKichCo;
            ////x.KichCo = khv.KichCo;
            ////x.TrangThai = khv.TrangThai;

            //return _ccdgrp.Update(x) ? "sửa thành công" : "sửa thất bại";
            return "a";
        }

        public string Delete(Guid idGuid)
        {
            //Delete
            ChieuCaoDeGiay? x = _ccdgrp.GetAll().FirstOrDefault(c => c.Id == idGuid);
            return _ccdgrp.Delete(x) ? "Xóa Thành Công" : "Xóa thất Bại";
        }

        public List<QLChieuCaoDeGiayView> Getall()
        {
            //Getall
            return (from a in _ccdgrp.GetAll()
                    select new QLChieuCaoDeGiayView()
                    {
                        ChieuCaoDeGiay = a

                    }).ToList();
        }
    }
}
