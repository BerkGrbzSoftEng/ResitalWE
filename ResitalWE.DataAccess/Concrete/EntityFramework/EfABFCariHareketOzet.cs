using System;
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

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfABFCariHareketOzet:EfEntityRepositoryBase<AbgCariHareketOzet,ResitalWEContext>,IABGCariHareketDal
    {
        public async Task<List<AbgCariHareketOzet>> GetOzet(Expression<Func<AbgCariHareketOzet, bool>> filter = null)
        {
            using (var context=new ResitalWEContext())
            {
                var result = context.Database.ExecuteSqlInterpolatedAsync($"exec sp_CheckCariHareketOzet");
                if (result.Result>0)
                {
                    var list =  filter == null
                        ? context.AbgCariHareketOzet.ToList()
                        : context.AbgCariHareketOzet.Where(filter).ToList();
                    return  list;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
