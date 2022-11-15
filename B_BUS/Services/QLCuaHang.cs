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
    public class QLCuaHang:IQLCuaHang

    {
        //bien
        public IGenericRepository<CuaHang> igcuaHang;

        public QLCuaHang()
        {
            igcuaHang = new GenericRepository<CuaHang>();
        }
        public bool Add(CuaHang obj)
        {
            //add
            return igcuaHang.Add(obj);
        }

        public bool Update(CuaHang obj)
        {
            //update
            return igcuaHang.Update(obj);
        }

        public bool Delete(CuaHang obj)
        {
            //delete
            return igcuaHang.Delete(obj);
        }

        public List<CuaHangView> GetAllView()
        {
            // getall
            List<CuaHangView> lst = (from a in igcuaHang.GetAll()
                select new CuaHangView()
                {
                    CuaHang = a,
                }).ToList();
            return lst;
        }
    }
}
