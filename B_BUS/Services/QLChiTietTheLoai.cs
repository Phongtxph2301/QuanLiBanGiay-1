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
    public class QLChiTietTheLoai:IQLChiTietTheLoai
    {
        //bien
        public IGenericRepository<ChiTietTheLoai> igChiTietTheLoai;

        //bien
        public IGenericRepository<ChiTietGiay> IgChitietGiay;

        public QLChiTietTheLoai()
        {
            igChiTietTheLoai = new GenericRepository<ChiTietTheLoai>();
            IgChitietGiay = new GenericRepository<ChiTietGiay>();
        }
        public bool Add(ChiTietTheLoai obj)
        {
            //add
            return igChiTietTheLoai.Add(obj);
        }

        public bool Update(ChiTietTheLoai obj)
        {
            //update
            return igChiTietTheLoai.Update(obj);
        }

        public bool Delete(ChiTietTheLoai obj)
        {
            //delete
            return igChiTietTheLoai.Delete(obj);
        }

        public List<ChiTietTheLoaiView> GetAllView()
        {
            // getall
            List<ChiTietTheLoaiView> lst = (from a in igChiTietTheLoai.GetAll() join b in IgChitietGiay.GetAll() on a.IdChiTietGiay equals b.Id 
                select new ChiTietTheLoaiView()
                {
                    ChiTietTheLoai = a,
                    ChiTietGiay = b
                }).ToList();
            return lst;
        }
    }
}
