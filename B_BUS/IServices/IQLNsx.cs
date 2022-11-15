using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLNsx
    {
        bool Add(Nsx obj);
        bool Update(Nsx obj);
        bool Delete(Nsx obj);
        List<NsxView> GetAllView();
    }
}
