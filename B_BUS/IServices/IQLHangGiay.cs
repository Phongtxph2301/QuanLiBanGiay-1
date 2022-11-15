﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A_DAL.Entities;
using B_BUS.View_Models;

namespace B_BUS.IServices
{
    public interface IQLHangGiay
    {
        bool Add(HangGiay obj);
        bool Update(HangGiay obj);
        bool Delete(HangGiay obj);
        List<HangGiayView> GetAllView();
    }
}
