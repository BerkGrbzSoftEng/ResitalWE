﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.Abstract
{
    public interface ISatisRaporService
    {
        Task<List<AbgSatisRapor>> GetList();
        Task<List<SFaturaD>> GetListDetail(string date);
    }
}
