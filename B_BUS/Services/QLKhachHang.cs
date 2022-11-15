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
    public class QLKhachHang:IQLKhachHang
    {
        //bien
        public IGenericRepository<KhachHang> igCKhachhang;

        public QLKhachHang()
        {
            igCKhachhang = new GenericRepository<KhachHang>();
        }
        public bool Add(KhachHang obj)
        {
            //add
            return igCKhachhang.Add(obj);
        }

        public bool Update(KhachHang obj)
        {
            //update
            return igCKhachhang.Update(obj);
        }

        public bool Delete(KhachHang obj)
        {
            return igCKhachhang.Delete(obj);
        }

        public List<KhachHangView> GetAllView()
        {
            // getall
            List<KhachHangView> lst = (from a in igCKhachhang.GetAll()
                select new KhachHangView()
                {
                    Khach = a,
                }).ToList();
            return lst;
        }
    }
}
