using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLPhuongThucThanhToan
    {
        bool Add(PhuongThucThanhToan obj);
        bool Update(PhuongThucThanhToan obj);
        bool Delete(PhuongThucThanhToan obj);
        List<PhuongThucThanhToanView> GetAllView();
    }
}
