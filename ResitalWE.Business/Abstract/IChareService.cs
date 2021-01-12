using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ResitalWE.Core.Utilities.Results;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface IChareService
    {
        IDataResult<List<CHare>> GetList(Expression<Func<CHare, bool>> expression=null);
    }
}
