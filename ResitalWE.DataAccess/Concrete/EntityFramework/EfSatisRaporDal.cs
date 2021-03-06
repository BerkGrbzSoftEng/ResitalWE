﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfSatisRaporDal : EfEntityRepositoryBase<AbgSatisRapor, ResitalWEContext>, ISatisRaporDal
    {
        public async Task<List<AbgSatisRapor>> GetList(Expression<Func<AbgSatisRapor, bool>> filter = null)
        {
            using (var context = new ResitalWEContext())
            {
                var result = context.Database.ExecuteSqlInterpolatedAsync($"exec sp_CheckABGSatisRapor");
                if (result.Result > 0)
                {
                    var list = filter == null
                        ? await  context.ABGSatisRapor.ToListAsync()
                        : await context.ABGSatisRapor.Where(filter).ToListAsync();
                    return list;
                }
                else
                {
                    return null;
                }

            }
        }

        public async Task<List<SFaturaD>> GetListDetail(string date)
        {
            using (var context = new ResitalWEContext())
            {
                var result = context.SFaturaD.FromSqlRaw($"exec checkSatisRaporDetay '{date}'").ToListAsync();
                if (result.Result.Count()>0)
                {
                    var list = date == null
                        ? null
                        : await result;
                    return list;
                }
                else
                {
                    return null;
                }

            }
        }
    }
}
