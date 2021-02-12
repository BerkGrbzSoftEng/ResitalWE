using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface IBankaService
    {
        Task<List<CKart>> GetBankList();
        Task<List<Banka>> GetHareketList(string carino);
    }
}
