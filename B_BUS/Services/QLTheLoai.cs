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
    public class QLTheLoai:IQLTheLoai
    {
        //bien
        public IGenericRepository<TheLoai> igTheLoai;

        public QLTheLoai()
        {
            igTheLoai = new GenericRepository<TheLoai>();
        }
        public bool Add(TheLoai obj)
        {
            //add
            return igTheLoai.Add(obj);
        }

        public bool Update(TheLoai obj)
        {
            //update
            return igTheLoai.Update(obj);
        }

        public bool Delete(TheLoai obj)
        {
            //delete
            return igTheLoai.Delete(obj);
        }

        public List<TheLoaiView> GetAllView()
        {
            // getall
            List<TheLoaiView> lst = (from a in igTheLoai.GetAll()
                select new TheLoaiView()
                {
                    TheLoai = a,
                }).ToList();
            return lst;
        }
    }
}
