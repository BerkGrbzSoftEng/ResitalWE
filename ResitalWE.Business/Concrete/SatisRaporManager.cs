using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.Concrete
{
    public class SatisRaporManager:ISatisRaporService
    {
        private ISatisRaporDal _satisRaporDal;

        public SatisRaporManager(ISatisRaporDal satisRaporDal)
        {
            _satisRaporDal = satisRaporDal;
        }

        public async Task<List<AbgSatisRapor>> GetList()
        {
            return await _satisRaporDal.GetList();
        }
    }
}
