using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using ResitalWE.Business.Abstract;
using ResitalWE.Business.Constants;
using ResitalWE.Core.Utilities.Results;
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


        public IDataResult<List<CKart>> GetList(Expression<Func<CKart, bool>> expression)
        {
            return new SuccessDataResult<List<CKart>>(_crKartDal.GetList(expression).ToList());
        }

        public IDataResult<CKart> GetByCariNo(string CariNo)
        {
            if (!string.IsNullOrEmpty(CariNo))
            {
               var result=new SuccessDataResult<CKart>(_crKartDal.GetByCariNo(CariNo));
               return  result;
            }
            else
            {
               return new ErrorDataResult<CKart>(message:"Cari Numarası Null olamaz");
            }
            
        }
   

        public IResult Count()
        {
            int counted = _crKartDal.Count();
            return new SuccessResult($"({counted}) Adet Cari Bulunmaktadır");
        }
    }
}
