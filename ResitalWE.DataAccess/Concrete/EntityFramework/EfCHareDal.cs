using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfCHareDal:EfEntityRepositoryBase<CHare,ResitalWEContext>,ICHareDal
    {
       
    }
}
