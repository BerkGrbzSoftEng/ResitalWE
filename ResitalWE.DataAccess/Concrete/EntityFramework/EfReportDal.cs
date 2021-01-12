using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfReportDal:EfEntityRepositoryBase<Report,ResitalWEContext>,IReportDal
    {
        public IEnumerable<Report.BankaKrediDetay> GetBankaKrediDetays(DateTime basTarih, DateTime bitTarih)
        {
            using (var context=new ResitalWEContext())
            {
                var result =
                    context.BankaKrediDetay.FromSqlRaw("exec decom_BankaKredi_Detay {0},{1}", basTarih, bitTarih);
                return result.ToList();
            }
        }
    }
}
