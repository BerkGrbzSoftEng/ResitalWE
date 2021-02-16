using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Abstract
{
    public interface ICariDal:IEntityRepository<vw_ABGCariAylikRapor>
    {

        Task<List<vw_ABGCariAylikRapor>> GetCariAyOzet(int ay);
        Task<List<CariAyOzet>> GetCariAyOzet();
    }
}
