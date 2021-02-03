using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class SFaturaDManager : ISFaturaDService
    {
        private ISFaturaDDal _saFaturaDDal;

        public SFaturaDManager(ISFaturaDDal saFaturaDDal)
        {
            _saFaturaDDal = saFaturaDDal;
        }

        

        public async Task<List<SFaturaD>> GetList()
        {
            return await _saFaturaDDal.GetListAsync();
        }
    }
}
