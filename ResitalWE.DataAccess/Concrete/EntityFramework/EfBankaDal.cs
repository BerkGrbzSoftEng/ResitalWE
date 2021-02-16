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
using ResitalWE.Entities.Report;

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
                                     Tarih = ch.Tarih.ToShortDateString(),
                                     EvrakNo = ch.EvrakNo,
                                     Vade = ch.Vade.ToShortDateString(),
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

        public async Task<List<vw_ABGBankaAylikRapor>> GetAyOzetList(int ay)
        {
            using (var context = new ResitalWEContext())
            {
                if (ay > 0)
                {
                    var result = context.vw_ABGBankaAylikRapor.Where(x => x.Ay == ay).ToListAsync();
                    return result.Result;

                }

                return null;
            }
        }

        public async Task<List<BankaAyOzet>> GetAylikToplamOzetList()
        {
            using (var context = new ResitalWEContext())
            {
                List<BankaAyOzet> ozet = new List<BankaAyOzet>();
                 
                 var obj = context.BankaAyOzet.FromSqlRaw(
                     "select distinct Ay,AyAd,SUM(borc) 'tBorc',Sum(alacak) 'tAlacak' from vw_ABGBankaAylikRapor group by ay,AyAd").OrderBy(x=>x.Ay).ToListAsync();
                ozet.AddRange(obj.Result.Select(x => new BankaAyOzet
                {
                    Ay = x.Ay,
                    AyAd = x.AyAd,
                    tAlacak = x.tAlacak,
                    tBorc = x.tBorc
                }));
                return ozet;
            }
        }
    }
}
