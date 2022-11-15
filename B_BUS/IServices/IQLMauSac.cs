using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLMauSac
    {
        bool Add(MauSac obj);
        bool Update(MauSac obj);
        bool Delete(MauSac obj);
        List<MauSacView> GetAllView();
    }
}
