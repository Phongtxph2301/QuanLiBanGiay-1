using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class GiaoCaView
    {
        public GiaoCa GiaoCa { get; set; } = new();
        public NhanVien NhanVien { get; set; } = new();
            
    }
}
