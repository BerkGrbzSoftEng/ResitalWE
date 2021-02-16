using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.Abstract
{
    public interface ICariService
    {
        Task<List<CariAyOzet>> GetListOzet();
        Task<List<vw_ABGCariAylikRapor>> GetListOzet(int ay);
    }
}
