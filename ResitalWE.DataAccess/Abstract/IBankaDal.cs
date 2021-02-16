using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;
using ResitalWE.Entities.Report;

namespace ResitalWE.DataAccess.Abstract
{
    public interface IBankaDal:IEntityRepository<CKart>
    {
        Task<List<CKart>> GetBorcAlacakList();
        Task<List<Banka>> GetHareketList(string cariNo);
        Task<List<vw_ABGBankaAylikRapor>> GetAyOzetList(int ay);
        Task<List<BankaAyOzet>> GetAylikToplamOzetList();
    }
}
