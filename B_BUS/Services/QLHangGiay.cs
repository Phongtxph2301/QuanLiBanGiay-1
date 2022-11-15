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
    public class QLHangGiay:IQLHangGiay
    {
        //bien
        public IGenericRepository<HangGiay> _iHangGiay;

        public QLHangGiay()
        {
            _iHangGiay = new GenericRepository<HangGiay>();
        }
        public bool Add(HangGiay obj)
        {
            //add
            return _iHangGiay.Add(obj);
        }

        public bool Update(HangGiay obj)
        {
            //update
            return _iHangGiay.Update(obj);
        }

        public bool Delete(HangGiay obj)
        {
            //delete
            return _iHangGiay.Delete(obj);
        }

        public List<HangGiayView> GetAllView()
        {
           // getall
            List<HangGiayView> lst = (from a in _iHangGiay.GetAll()
                select new HangGiayView()
                {
                    HangGiay = a,
                }).ToList();
            return lst;
        }
    }
}
