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
    public class QLGiay:IQLGiay
    {
        //bien
        public IGenericRepository<Giay> igiay;
        public QLGiay()
        {
            igiay = new GenericRepository<Giay>();
        }
        public bool Add(Giay obj)
        {
            //add
            return igiay.Add(obj);
        }

        public bool Update(Giay obj)
        {
            //update
            return igiay.Update(obj);
        }

        public bool Delete(Giay obj)
        {
            //delete
            return igiay.Delete(obj);
        }

        public List<GiayView> GetAllView()
        {
            // getall
            List<GiayView> lst = (from a in igiay.GetAll()
                select new GiayView()
                {
                    Giay = a,
                }).ToList();
            return lst;
        }
    }
}
