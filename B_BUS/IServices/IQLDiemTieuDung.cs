using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLDiemTieuDung
    {
        bool Add(DiemTieuDung obj);
        bool Update(DiemTieuDung obj);
        bool Delete(DiemTieuDung obj);
        List<DiemTieuDungView> GetAllView();
    }
}
