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
    public class QLHoaDon:IQLHoaDon
    {
        //bien
        public IGenericRepository<HoaDon> igHoaDon;
        //bien
        public IGenericRepository<NhanVien> igNhanVien;
        //bien
        public IGenericRepository<KhachHang> igKhachhang;
        public QLHoaDon()
        {
            igHoaDon = new GenericRepository<HoaDon>();
            igNhanVien = new GenericRepository<NhanVien>();
            igKhachhang = new GenericRepository<KhachHang>();
        }
        public bool Add(HoaDon obj)
        {
            //add
            return igHoaDon.Add(obj);
        }

        public bool Update(HoaDon obj)
        {
            //update
            return igHoaDon.Update(obj);
        }

        public bool Delete(HoaDon obj)
        {
            //delete
            return igHoaDon.Delete(obj);
        }

        public List<HoaDonView> GetAllView()
        {
            // getall
            List<HoaDonView> lst = (from a in igHoaDon.GetAll() join b in igNhanVien.GetAll() on a.IdNhanVien equals b.Id
                join c in igKhachhang.GetAll() on a.IdKhachHang equals c.Id      
                select new HoaDonView()
                {
                    HoaDon = a,
                    NhanVien = b,
                    KhachHang = c
                }).ToList();
            return lst;
        }
    }
}
