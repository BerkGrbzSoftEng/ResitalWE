using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class BankaManager:IBankaService
    {
        private IBankaDal _bankaDal;

        public BankaManager(IBankaDal bankaDal)
        {
            _bankaDal = bankaDal;
        }

        public async Task<List<CKart>> GetBankList()
        {
            return await _bankaDal.GetBorcAlacakList();
        }

        public async Task<List<Banka>> GetHareketList(string carino)
        {
            return await _bankaDal.GetHareketList(carino);
        }
    }
}
