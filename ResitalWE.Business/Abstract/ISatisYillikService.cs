﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.Abstract
{
    public interface ISatisYillikService
    {
        Task<List<ABGSatisYillik>> Getlist();
    }
}
