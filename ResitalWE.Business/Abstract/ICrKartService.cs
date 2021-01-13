using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
 
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface ICrKartService
    {
       List<CKart> GetList(Expression<Func<CKart,bool>> expression=null);
 
        
    }
}
