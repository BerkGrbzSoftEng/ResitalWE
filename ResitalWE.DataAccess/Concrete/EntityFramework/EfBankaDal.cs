using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfBankaDal : EfEntityRepositoryBase<CKart, ResitalWEContext>, IBankaDal
    {
        public async Task<List<CKart>> GetBorcAlacakList()
        {
            using (var context = new ResitalWEContext())
            {
                var result = context.CKart.Where(x => x.Tip == "Banka").ToListAsync();
                return await result;
            }
        }

        public async Task<List<Banka>> GetHareketList(string cariNo)
        {
            using (var context = new ResitalWEContext())
            {
                if (cariNo != null)
                {
                    var result = from ck in context.CKart
                                 join ch in context.CHare on ck.CariNo equals ch.CariNo
                                 where ck.Tip == "Banka" && ck.CariNo == cariNo
                                 select new Banka
                                 {
                                     CariNo = ck.CariNo,
                                     Aciklama = ch.Aciklama,
                                     BorcBakiye = ch.BorcTutar,
                                     AlacakBakiye = ch.AlacakTutar,
                                     Tarih = ch.Tarih,
                                     EvrakNo = ch.EvrakNo,
                                     Vade = ch.Vade,
                                     BA = ch.BA
                                 };
                    if (result.Count() > 0)
                    {
                        return await result.ToListAsync();
                    }

                    return null;
                }

                return null;
            }
        }
    }
}
