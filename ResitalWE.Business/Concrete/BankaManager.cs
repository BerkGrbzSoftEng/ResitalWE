using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.Concrete
{
    public class BankaManager : IBankaService
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

        public async Task<List<vw_ABGBankaAylikRapor>> GetAylikList(int ay)
        {
            return await _bankaDal.GetAyOzetList(ay);
        }

        public async Task<List<BankaAyOzet>> GetAylikToplamList()
        {
            return await _bankaDal.GetAylikToplamOzetList();
        }
    }
}
