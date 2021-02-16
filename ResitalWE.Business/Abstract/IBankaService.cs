using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.Business.Abstract
{
    public interface IBankaService
    {
        Task<List<CKart>> GetBankList();
        Task<List<Banka>> GetHareketList(string carino);
        Task<List<vw_ABGBankaAylikRapor>> GetAylikList(int ay);
        Task<List<BankaAyOzet>> GetAylikToplamList();
    }
}
