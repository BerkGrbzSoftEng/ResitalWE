using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.ComplexType;

namespace ResitalWE.Business.Concrete
{
    public class CariOdemeManager:ICariOdemeService
    {
        private ICariOdemeDDal _cariOdemeDDal;

        public CariOdemeManager(ICariOdemeDDal cariOdemeDDal)
        {
            _cariOdemeDDal = cariOdemeDDal;
        }

        public async Task<List<CariOdeme>> GetOdemeList()
        {
            return (await _cariOdemeDDal.GetOdemeList());
        }
    }
}
