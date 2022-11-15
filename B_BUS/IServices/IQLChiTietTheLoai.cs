using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLChiTietTheLoai
    {
        bool Add(ChiTietTheLoai obj);
        bool Update(ChiTietTheLoai obj);
        bool Delete(ChiTietTheLoai obj);
        List<ChiTietTheLoaiView> GetAllView();
    }
}
