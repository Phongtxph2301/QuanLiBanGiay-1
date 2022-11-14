using A_DAL.Entities;
using A_DAL.IRepositories;
using A_DAL.Repositories;
using B_BUS.IServices;
using B_BUS.View_Models;

namespace B_BUS.Services
{
    public class QLChieuCaoDeGiay : IQLChieuCaoDeGiay
    {
        public IGenericRepository<ChieuCaoDeGiay> igChieuCaoDeGiay;
        public QLChieuCaoDeGiay()
        {
            igChieuCaoDeGiay = new GenericRepository<ChieuCaoDeGiay>();
        }

        public bool Add(ChieuCaoDeGiay obj)
        {
            return igChieuCaoDeGiay.Add(obj);
        }

        public bool Update(ChieuCaoDeGiay obj)
        {
            return igChieuCaoDeGiay.Update(obj);
        }

        public bool Delete(ChieuCaoDeGiay obj)
        {
            return igChieuCaoDeGiay.Delete(obj);
        }

        public List<ChieuCaoDeGiayView> GetAllView()
        {
            List<ChieuCaoDeGiayView> lst = (from a in igChieuCaoDeGiay.GetAll()
                                            select new ChieuCaoDeGiayView()
                                            {
                                                ChieuCaoDeGiay = a,
                                            }).ToList();
            return lst;
        }
    }
}
