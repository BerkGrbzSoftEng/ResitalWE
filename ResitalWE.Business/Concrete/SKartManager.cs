using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResitalWE.Business.Abstract;
using ResitalWE.Core.Utilities.Results;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class SKartManager:ISkartService
    {
        private ISkartDal _skartDal;

        public SKartManager(ISkartDal skartDal)
        {
            _skartDal = skartDal;
        }

        public IDataResult<List<SKart>> GetList()
        {
            return new SuccessDataResult<List<SKart>>(_skartDal.GetList().ToList());
        }
    }
}
