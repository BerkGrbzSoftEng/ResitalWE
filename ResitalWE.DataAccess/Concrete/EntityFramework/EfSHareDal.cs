using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfSHareDal : EfEntityRepositoryBase<SHare, ResitalWEContext>, ISHareDal
    {
        public async Task<List<StokAnalizRapor>> GetStokAnalizRaporList()
        {
            using (var context = new ResitalWEContext())
            {
                /*
                 *****************
                 GROUP BY KULLANIMI with LINQ
                 *****************
                 */
                var result = from c in context.CKart
                             join sh in context.SHare on c.CariNo equals sh.CariNo
                             group new { c, sh } by new { c.CariNo, c.Unvan }
                    into Group
                             select new StokAnalizRapor
                             {
                                 Unvan = Group.Key.Unvan,
                                 SAT_URUNSAY = Group.Count(),
                                 CariNo = Group.Key.CariNo
                             };
                var obj = result.ToListAsync().Result;
                return await result.ToListAsync();

            }
        }
    }
}
