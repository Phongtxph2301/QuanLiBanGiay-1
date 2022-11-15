using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLTheLoai
    {
        bool Add(TheLoai obj);
        bool Update(TheLoai obj);
        bool Delete(TheLoai obj);
        List<TheLoaiView> GetAllView();
    }
}
