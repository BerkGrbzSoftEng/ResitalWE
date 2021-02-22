using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class StokManager : IStokService
    {
        private IStDepoDal _stDepoDal;
        private ISHareDal _sHareDal;
        private ISKartMMDal _sKartMmDal;
        private ISkartDal _skartDal;
        public StokManager(IStDepoDal stDepoDal, ISKartMMDal sKartMmDal, ISHareDal sHareDal, ISkartDal skartDal)
        {
            _stDepoDal = stDepoDal;
            _sKartMmDal = sKartMmDal;
            _sHareDal = sHareDal;
            _skartDal = skartDal;
        }

        public async Task<List<StokDepo>> StokDepoList()
        {
            return await _stDepoDal.GetStokDepoList();
        }

        public async Task<List<StokAnalizRapor>> GetStokAnalizRaporList()
        {
            return await _sHareDal.GetStokAnalizRaporList();
        }

        public List<SKart> GetStokBakiyeMiktarList()
        {
            return _skartDal.GetStokBakiyeMiktarList();
        }

        public List<SKart> GetStokList()
        {
            return _skartDal.GetStokList();
        }
    }
}
