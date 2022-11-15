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
    public class QLHoaDonChiTiet:IQLHoaDonChiTiet
    {
        //bien
        public IGenericRepository<HoaDonChiTiet> igHoaDonchotiet;
        //bien
        public IGenericRepository<ChiTietGiay> igChiTietGiay; //bien
        public IGenericRepository<HoaDon> igHoaDon;

        public QLHoaDonChiTiet()
        {
            igHoaDonchotiet = new GenericRepository<HoaDonChiTiet>();
            igChiTietGiay = new GenericRepository<ChiTietGiay>();
            igHoaDon = new GenericRepository<HoaDon>();
        }

        public bool Add(HoaDonChiTiet obj)
        {
            //add
            return igHoaDonchotiet.Add(obj);
        }

        public bool Update(HoaDonChiTiet obj)
        {
            //update
            return igHoaDonchotiet.Update(obj);
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            //delete
            return igHoaDonchotiet.Delete(obj);
        }

        public List<HoaDonChiTietView> GetAllView()
        {
            // getall
            List<HoaDonChiTietView> lst = (from a in igHoaDonchotiet.GetAll() join b in igChiTietGiay.GetAll() on a.IdChiTietGiay equals b.Id
                join c in igHoaDon.GetAll() on a.IdHoaDon equals c.Id 
                select new HoaDonChiTietView()
                {
                    HoaDonChiTiet = a,
                    ChTietGiay = b,
                    HoaDon = c
                }).ToList();
            return lst;
        }
    }
}
