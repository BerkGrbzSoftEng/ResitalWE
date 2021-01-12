using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Abstract
{
    public interface ICrKartDal:IEntityRepository<CKart>
    {
        CKart GetByCariNo(string CariNo);
  
    }
}
