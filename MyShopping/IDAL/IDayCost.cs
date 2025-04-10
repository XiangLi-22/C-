﻿using Domains.DTO;
using Maticsoft.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IDayCost:IBase<DayCastInfo>
    {
        DayCastInfo GetLastDayCost(DateTime time);
        float GetTotalRemain();
        IQueryable<DayDTO> GetTypeCast(int t, int page, int pagesize);

    }
}
