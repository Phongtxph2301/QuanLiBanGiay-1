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
    public class QLMauSac :IQLMauSac    
    {
        //bien
        public IGenericRepository<MauSac> _igmausac;

        public QLMauSac()
        {
            _igmausac = new GenericRepository<MauSac>();
        }
        public bool Add(MauSac obj)
        {
            //add
            return _igmausac.Add(obj);
        }

        public bool Update(MauSac obj)
        {
            //update
            return _igmausac.Update(obj);
        }

        public bool Delete(MauSac obj)
        {
            //delete
            return _igmausac.Delete(obj);
        }

        public List<MauSacView> GetAllView()
        {
           // getall
            List<MauSacView> lst = (from a in _igmausac.GetAll()
                select new MauSacView()
                {
                    MauSac = a,
                }).ToList();
            return lst;
        }
    }
}
