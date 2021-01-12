using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Abstract
{
    public interface IReportDal:IEntityRepository<Report>
    {
        IEnumerable<Report.BankaKrediDetay> GetBankaKrediDetays(DateTime basTarih,DateTime bitTarih);
    }
}
