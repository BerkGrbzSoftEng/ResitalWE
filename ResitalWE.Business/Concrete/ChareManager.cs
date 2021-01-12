using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ResitalWE.Business.Abstract;
using ResitalWE.Core.Utilities.Results;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class ChareManager:IChareService
    {
        private ICHareDal _cHareDal;

        public ChareManager(ICHareDal cHareDal)
        {
            _cHareDal = cHareDal;
        }

        public IDataResult<List<CHare>> GetList(Expression<Func<CHare, bool>> expression=null)
        {
           return new SuccessDataResult<List<CHare>>(_cHareDal.GetList(expression).ToList());
        }
    }
}
