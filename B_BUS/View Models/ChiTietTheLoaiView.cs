using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class ChiTietTheLoaiView
    {
        public ChiTietTheLoai ChiTietTheLoai { get; set; } = new();
        public TheLoai TheLoai { get; set; } = new();
        public ChiTietGiay  ChiTietGiay { get; set; } = new();
    }
}
