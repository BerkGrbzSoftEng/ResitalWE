using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Abstract
{
    public interface IAlisYillikDal:IEntityRepository<ABGAlisYillik>
    {
        Task<List<ABGAlisYillik>> GetListAsync();
    }
}
