using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChucVu:IServices.IQLChucVu
    { //bien
        public IGenericRepository<ChucVu> igChucvu;

        public QLChucVu()
        {
            igChucvu = new GenericRepository<ChucVu>();
        }
        public bool Add(ChucVu obj)
        {
            //add
            return igChucvu.Add(obj);
        }

        public bool Update(ChucVu obj)
        {
            //update
            return igChucvu.Update(obj);
        }

        public bool Delete(ChucVu obj)
        {
            //delete
            return igChucvu.Delete(obj);
        }

        public List<ChucVuView> GetAllView()
        {
            // getall
            List<ChucVuView> lst = (from a in igChucvu.GetAll()
                select new ChucVuView()
                {
                    ChucVu = a,
                }).ToList();
            return lst;
        }
    }
}
