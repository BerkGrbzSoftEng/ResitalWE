using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework;
using ResitalWE.Entities.ComplexType;

namespace ResitalWE.Business.Concrete
{
    public class StokManager : IStokService
    {
        private IStDepoDal _stDepoDal;
        private ISHareDal _sHareDal;
        private ISKartMMDal _sKartMmDal;
        public StokManager(IStDepoDal stDepoDal, ISKartMMDal sKartMmDal, ISHareDal sHareDal)
        {
            _stDepoDal = stDepoDal;
            _sKartMmDal = sKartMmDal;
            _sHareDal = sHareDal;
        }

        public async Task<List<StokDepo>> StokDepoList()
        {
            return await _stDepoDal.GetStokDepoList();
        }

        public int Countt()
        {
            return _sKartMmDal.Count();
        }

        public void Result()
        {
            var result = _sHareDal.GetStokAnalizRaporList().Result;
        }
    }
}
