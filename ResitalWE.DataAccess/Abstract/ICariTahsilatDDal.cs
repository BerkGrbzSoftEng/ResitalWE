﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Abstract
{
    public interface ICariTahsilatDDal:IEntityRepository<CariTahsilatD>
    {
        Task<List<CariTahsilat>> GetList();
    }
}