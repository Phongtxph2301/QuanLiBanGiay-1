using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class NhanVienView
    {
        public NhanVien NhanVien { get; set; } = new();
        public ChucVu ChucVu { get; set; } = new();
        public CuaHang CuaHang { get; set; } = new();
    }
}
