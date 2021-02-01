using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface ICariHareketOzet
    {
        Task<List<AbgCariHareketOzet>> GetList(Expression<Func<AbgCariHareketOzet, bool>> expression = null);

    }
}
