using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Abstract
{
    public interface ISatisYillikDal:IEntityRepository<ABGSatisYillik>
    {
        Task<List<ABGSatisYillik>> GetList();
    }
}
