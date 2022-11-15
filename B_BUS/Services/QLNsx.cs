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
    public class QLNsx:IQLNsx
    {
        //bien
        public IGenericRepository<Nsx> ignsxview;

        public QLNsx()
        {
            ignsxview = new GenericRepository<Nsx>();
        }
        public bool Add(Nsx obj)
        {
            //add
            return ignsxview.Add(obj);
        }

        public bool Update(Nsx obj)
        {
            //update
            return ignsxview.Update(obj);
        }

        public bool Delete(Nsx obj)
        {
            //delete
            return ignsxview.Delete(obj);
        }

        public List<NsxView> GetAllView()
        {
            // getall
            List<NsxView> lst = (from a in ignsxview.GetAll()
                select new NsxView()
                {
                    Nsx = a,
                }).ToList();
            return lst;
        }
    }
}
