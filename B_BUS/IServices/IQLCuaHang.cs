using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLCuaHang
    {
        bool Add(CuaHang obj);
        bool Update(CuaHang obj);
        bool Delete(CuaHang obj);
        List<CuaHangView> GetAllView();
    }
}
