using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfCrKartDal:EfEntityRepositoryBase<CKart, ResitalWEContext>,ICrKartDal
    {
        
        public CKart GetByCariNo(string CariNo)
        {
            using (var context=new ResitalWEContext())
            {
                var obj = context.CKart.FirstOrDefault(i => i.CariNo == CariNo);
                if (obj!=null)
                {
                    return obj;
                }
                else
                {
                    string message=String.Format("{0} no lu cari bulunmamaktadır. Lütfen CariNo yu kontrol edin",CariNo);
                    throw new Exception(message);
                }
            }
        }
 

       

  
    }
}
