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
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfCariDal:EfEntityRepositoryBase<vw_ABGCariAylikRapor,ResitalWEContext>,ICariDal
    {
        public async Task<List<vw_ABGCariAylikRapor>> GetCariAyOzet(int ay)
        {
            using (var context = new ResitalWEContext())
            {
                if (ay > 0)
                {
                    var result = context.vw_ABGCariAylikRapor.Where(x => x.Ay == ay).ToListAsync();
                    return result.Result;

                }

                return null;
            }
        }

        public async Task<List<CariAyOzet>> GetCariAyOzet()
        {
            using (var context = new ResitalWEContext())
            {
                List<CariAyOzet> ozet = new List<CariAyOzet>();

                var obj = context.CariAyOzet.FromSqlRaw(
                    "select distinct Ay,AyAd,SUM(borc) 'tBorc',Sum(alacak) 'tAlacak' from vw_ABGCariAylikRapor group by ay,AyAd").OrderBy(x => x.Ay).ToListAsync();
                ozet.AddRange(obj.Result.Select(x => new CariAyOzet()
                {
                    Ay = x.Ay,
                    AyAd = x.AyAd,
                    tAlacak = x.tAlacak,
                    tBorc = x.tBorc
                }));
                return ozet;
            }
        }
    }
}
