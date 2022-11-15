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
    public class QlPhuongThucThanhToan :IQLPhuongThucThanhToan
    {
        //bien
        public IGenericRepository<PhuongThucThanhToan> igPhuongthucThanhtoan;
        public QlPhuongThucThanhToan()
        {
            igPhuongthucThanhtoan = new GenericRepository<PhuongThucThanhToan>();
        }
        public bool Add(PhuongThucThanhToan obj)
        {
            //add
            return igPhuongthucThanhtoan.Add(obj);
        }

        public bool Update(PhuongThucThanhToan obj)
        {
            //update
            return igPhuongthucThanhtoan.Update(obj);
        }

        public bool Delete(PhuongThucThanhToan obj)
        {
            //delete
            return igPhuongthucThanhtoan.Delete(obj);
        }

        public List<PhuongThucThanhToanView> GetAllView()
        {
            // getall
            List<PhuongThucThanhToanView> lst = (from a in igPhuongthucThanhtoan.GetAll()
                select new PhuongThucThanhToanView()
                {
                    PhuongThucThanhToan = a,
                }).ToList();
            return lst;
        }
    }
}
