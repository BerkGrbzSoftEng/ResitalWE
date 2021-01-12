using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ResitalWE.Core.Utilities.Results;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface ICrKartService
    {
        IDataResult<List<CKart>> GetList(Expression<Func<CKart,bool>> expression=null);
        IDataResult<CKart> GetByCariNo(string CariNo);
        IResult Count();
    }
}
