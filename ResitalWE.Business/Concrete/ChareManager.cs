using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
 
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class ChareManager : IChareService
    {
        private ICHareDal _cHareDal;

        public ChareManager(ICHareDal cHareDal)
        {
            _cHareDal = cHareDal;
        }

        public async Task<List<CHare>> GetList(Expression<Func<CHare, bool>> expression = null)
        {
            var result = _cHareDal.GetList(expression).ToList();
            return result;
        }
    }
}
