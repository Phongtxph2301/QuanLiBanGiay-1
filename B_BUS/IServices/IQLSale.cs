using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLSale
    {
        bool Add(Sale obj);
        bool Update(Sale obj);
        bool Delete(Sale obj);
        List<SaleView> GetAllView();
    }
}
