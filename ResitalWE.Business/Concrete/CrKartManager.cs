using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ResitalWE.Business.Abstract;
using ResitalWE.Business.Constants;
 
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class CrKartManager:ICrKartService
    {
        private ICrKartDal _crKartDal;

        public CrKartManager(ICrKartDal crKartDal)
        {
            _crKartDal = crKartDal;
        }


        public List<CKart> GetList(Expression<Func<CKart, bool>> expression=null)
        {
            var result = _crKartDal.GetList(expression).ToList();
            return result;
        }

       
    
    }
}
