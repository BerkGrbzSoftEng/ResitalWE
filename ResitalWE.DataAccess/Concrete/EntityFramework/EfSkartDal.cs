using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfSkartDal:EfEntityRepositoryBase<SKart,ResitalWEContext>,ISkartDal
    {
     
    }
}
