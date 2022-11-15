using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChiTietThanhToan :IQLChiTietThanhToan
    {

        //bien
        public IGenericRepository<ChiTietThanhToan> igChTiet; 
        public IGenericRepository<PhuongThucThanhToan> igPhuongThuc;
        //bien
        public IGenericRepository<HoaDon> igHoaDon;

        public QLChiTietThanhToan()
        {
            igChTiet = new GenericRepository<ChiTietThanhToan>();
            igPhuongThuc = new GenericRepository<PhuongThucThanhToan>();
            igHoaDon = new GenericRepository<HoaDon>();
        }
        public bool Add(ChiTietThanhToan obj)
        {
            //add
            return igChTiet.Add(obj);
        }

        public bool Update(ChiTietThanhToan obj)
        {
            //update
            return igChTiet.Update(obj);
        }

        public bool Delete(ChiTietThanhToan obj)
        {
            //delete
            return igChTiet.Delete(obj);
        }

        public List<ChiTietThanhToanView> GetAllView()
        {
            // getall
            List<ChiTietThanhToanView> lst = (from a in igChTiet.GetAll() join b in igPhuongThuc.GetAll() on a.IdPhuongThucThanhToan equals b.Id
                join c in igHoaDon.GetAll() on a.IdHoaDon equals c.Id 
                select new ChiTietThanhToanView()
                {
                    ChiTietThanhToan = a,
                    PhuongThucThanhToan = b,
                    HoaDon = c
                }).ToList();
            return lst;
        }
    }
}
