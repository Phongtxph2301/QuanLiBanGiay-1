using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLKhachHang
    {
        bool Add(KhachHang obj);
        bool Update(KhachHang obj);
        bool Delete(KhachHang obj);
        List<KhachHangView> GetAllView();
    }
}
