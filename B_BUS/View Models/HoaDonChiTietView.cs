using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class HoaDonChiTietView
    {
        public HoaDonChiTiet HoaDonChiTiet { get; set; } = new();
        public HoaDon HoaDon { get; set; } = new();
        public ChiTietGiay ChTietGiay { get; set; } = new();
    }
}
