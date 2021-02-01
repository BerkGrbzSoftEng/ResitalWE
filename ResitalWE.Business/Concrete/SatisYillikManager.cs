using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.Concrete
{
    public class SatisYillikManager:ISatisYillikService
    {
        private ISatisYillikDal _satisYillikDal;

        public SatisYillikManager(ISatisYillikDal satisYillikDal)
        {
            _satisYillikDal = satisYillikDal;
        }

        public async Task<List<ABGSatisYillik>> Getlist()
        {
            return await _satisYillikDal.GetList();
        }
    }
}
