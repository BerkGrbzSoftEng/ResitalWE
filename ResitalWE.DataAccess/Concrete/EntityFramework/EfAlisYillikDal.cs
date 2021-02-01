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
    public class EfAlisYillikDal:EfEntityRepositoryBase<ABGAlisYillik,ResitalWEContext>,IAlisYillikDal
    {
        public async Task<List<ABGAlisYillik>> GetListAsync()
        {
            using (var context=new ResitalWEContext())
            {
                var queryResult = context.Database.ExecuteSqlInterpolatedAsync($"exec sp_CheckAlisYillik");
                if (queryResult.Result > 0)
                {
                    var list = await context.AbgAlisYillik.ToListAsync();
                    return list;
                }

                return null;
            }
        }
    }
}
