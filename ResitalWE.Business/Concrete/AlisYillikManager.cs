using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.Concrete
{
    public class AlisYillikManager : IAlisYillikService
    {
        private IAlisYillikDal _alisYillik;

        public AlisYillikManager(IAlisYillikDal alisYillik)
        {
            _alisYillik = alisYillik;
        }

        public async Task<List<ABGAlisYillik>> GetListAsync()
        {
            return await _alisYillik.GetListAsync();
        }
    }
}
