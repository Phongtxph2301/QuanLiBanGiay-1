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
    public class QLLichSuDiemTieuDung:IQlLichSuDiemTieuDung
    { //bien
        public IGenericRepository<LichSuDiemTieuDung> igLichsu;
        //bien
        public IGenericRepository<HoaDon> igHoaDon;
        //bien
        public IGenericRepository<DiemTieuDung> igDiemTieuDung;
        //bien
        public IGenericRepository<QuyDoi> igQuyDoi;

        public QLLichSuDiemTieuDung()
        {
            igLichsu = new GenericRepository<LichSuDiemTieuDung>();
            igHoaDon = new GenericRepository<HoaDon>();
            igDiemTieuDung = new GenericRepository<DiemTieuDung>();
            igQuyDoi = new GenericRepository<QuyDoi>();
        }

        public bool Add(LichSuDiemTieuDung obj)
        {
            //add
            return igLichsu.Add(obj);
        }

        public bool Update(LichSuDiemTieuDung obj)
        {
            //update
            return igLichsu.Update(obj);
        }

        public bool Delete(LichSuDiemTieuDung obj)
        {
            return igLichsu.Delete(obj);
        }

        public List<LichSuDiemTieuDungView> GetAllView()
        {
            // getall
            List<LichSuDiemTieuDungView> lst = (from a in igLichsu.GetAll() join b in igHoaDon.GetAll() on a.IdHoaDon equals b.Id
                join c in igDiemTieuDung.GetAll() on a.IdDiemTieuDung equals c.Id
                join d in igQuyDoi.GetAll() on a.IdQuyDoi equals d.Id  
                select new LichSuDiemTieuDungView()
                {
                    LichSuDiemTieuDung = a,
                    HoaDon = b,
                    DiemTieuDung = c,
                    QuyDoi = d
                }).ToList();
            return lst;
        }
    }
}
