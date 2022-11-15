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
     public class QLNhanVien :IQLNhanVien
    {
        //bien
        public IGenericRepository<NhanVien> igNhanVien;
        //bien
        public IGenericRepository<ChucVu> igChucVu;
        //bien
        public IGenericRepository<CuaHang> igCuaHag;

        public QLNhanVien()
        {
            igNhanVien = new GenericRepository<NhanVien>();
            igChucVu = new GenericRepository<ChucVu>();
            igCuaHag = new GenericRepository<CuaHang>();
        }
        public bool Add(NhanVien obj)
        {
            //add
            return igNhanVien.Add(obj);
        }

        public bool Update(NhanVien obj)
        {
            //update
            return igNhanVien.Update(obj);
        }

        public bool Delete(NhanVien obj)
        {
            //delete
            return igNhanVien.Delete(obj);
        }

        public List<NhanVienView> GetAllView()
        {
            // getall
            List<NhanVienView> lst = (from a in igNhanVien.GetAll() join b in igChucVu.GetAll() on a.IdChucVu equals b.Id
                join c in igCuaHag.GetAll() on a.IdCuaHang equals c.Id 
                select new NhanVienView()
                {
                    NhanVien = a,
                    ChucVu = b, 
                    CuaHang = c
                }).ToList();
            return lst;
        }
    }
}
