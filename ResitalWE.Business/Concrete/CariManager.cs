using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.Concrete
{
    public class CariManager : ICariService
    {
        private ICariDal _cariDal;

        public CariManager(ICariDal cariDal)
        {
            _cariDal = cariDal;
        }

        public async Task<List<CariAyOzet>> GetListOzet()
        {
            return await _cariDal.GetCariAyOzet();
        }

        public async Task<List<vw_ABGCariAylikRapor>> GetListOzet(int ay)
        {
            return await _cariDal.GetCariAyOzet(ay);
        }
    }
}
