using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Abstract
{
    public interface ISatisRaporDal : IEntityRepository<AbgSatisRapor>
    {
        Task<List<AbgSatisRapor>> GetList(Expression<Func<AbgSatisRapor, bool>> filter= null);
        Task<List<SFaturaD>> GetListDetail(string date);
    }
}
