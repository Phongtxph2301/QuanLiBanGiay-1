﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class DiemTieuDungView
    {
        public DiemTieuDung DiemTieuDung { get; set; } = new();
        public KhachHang KhachHang { get; set; } = new();
            
    }
}
