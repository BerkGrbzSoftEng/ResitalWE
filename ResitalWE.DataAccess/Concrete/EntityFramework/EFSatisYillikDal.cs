using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EFSatisYillikDal : EfEntityRepositoryBase<ABGSatisYillik, ResitalWEContext>, ISatisYillikDal
    {
        public async Task<List<ABGSatisYillik>> GetList()
        {
            using (var context = new ResitalWEContext())
            {
                var queryResult = context.Database.ExecuteSqlInterpolatedAsync($"exec [sp_CheckSatisYillik]");
                if (queryResult.Result > 0)
                {
                    var list = await context.AbgSatisYillik.ToListAsync();
                    return list;
                }

                return null;
            }
        }
    }
}
