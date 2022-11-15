using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLQuyDoi
    {
        bool Add(QuyDoi obj);
        bool Update(QuyDoi obj);
        bool Delete(QuyDoi obj);
        List<QuyDoiView> GetAllView();
    }
}
