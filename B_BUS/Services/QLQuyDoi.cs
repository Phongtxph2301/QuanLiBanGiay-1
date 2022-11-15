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
    public class QLQuyDoi:IQLQuyDoi
    {
        //bien
        public IGenericRepository<QuyDoi> igQuyDoi;

        public QLQuyDoi()
        {
            igQuyDoi = new GenericRepository<QuyDoi>();
        }
        public bool Add(QuyDoi obj)
        {
            //add
            return igQuyDoi.Add(obj);
        }

        public bool Update(QuyDoi obj)
        {
            //update
            return igQuyDoi.Update(obj);
        }

        public bool Delete(QuyDoi obj)
        {
            //delete
            return igQuyDoi.Delete(obj);
        }

        public List<QuyDoiView> GetAllView()
        {
            // getall
            List<QuyDoiView> lst = (from a in igQuyDoi.GetAll()
                select new QuyDoiView()
                {
                    QuyDoi = a,
                }).ToList();
            return lst;
        }
    }
}
