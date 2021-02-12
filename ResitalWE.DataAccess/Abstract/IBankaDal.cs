using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Abstract
{
    public interface IBankaDal:IEntityRepository<CKart>
    {
        Task<List<CKart>> GetBorcAlacakList();
        Task<List<Banka>> GetHareketList(string cariNo);
    }
}
