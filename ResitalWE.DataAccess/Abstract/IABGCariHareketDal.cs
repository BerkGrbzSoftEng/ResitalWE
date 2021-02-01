using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Abstract
{
    public interface IABGCariHareketDal:IEntityRepository<AbgCariHareketOzet>
    {
        Task<List<AbgCariHareketOzet>> GetOzet(Expression<Func<AbgCariHareketOzet,bool>> filter = null);
    }
}
