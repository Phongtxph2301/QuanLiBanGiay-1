using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLGiay
    {
        bool Add(Giay obj);
        bool Update(Giay obj);
        bool Delete(Giay obj);
        List<GiayView> GetAllView();
    }
}
