using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
 
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface IChareService
    {
        Task<List<CHare>> GetList(Expression<Func<CHare, bool>> expression=null);
      
    }
}
