using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLSize
    {
        bool Add(Size obj);
        bool Update(Size obj);
        bool Delete(Size obj);
        List<SizeView> GetAllView();
    }
}
