using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;

namespace B_BUS.View_Models
{
    public class LichSuDiemTieuDungView
    {
        public LichSuDiemTieuDung LichSuDiemTieuDung { get; set; } = new();
        public HoaDon HoaDon { get; set; } = new();
        public DiemTieuDung DiemTieuDung { get; set; } = new();
        public QuyDoi QuyDoi { get; set; } = new();
    }
}
