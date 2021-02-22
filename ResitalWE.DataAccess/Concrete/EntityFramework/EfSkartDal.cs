using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfSkartDal : EfEntityRepositoryBase<SKart, ResitalWEContext>, ISkartDal
    {
        public List<SKart> GetStokBakiyeMiktarList()
        {
            using (var context = new ResitalWEContext())
            {
                var result = from s in context.SKart
                             group new { s }
                                 by new { s.StokNo, s.StokAdi, s.GirMiktar, s.CikMiktar }
                   into Group
                             select new SKart
                             {
                                 StokAdi = Group.Key.StokAdi,
                                 StokNo = Group.Key.StokNo,
                                 BakiyeMiktar = Group.Key.GirMiktar - Group.Key.CikMiktar
                             };
                var data = result.AsNoTracking().ToList();
                return data;

            }
        }

        public List<SKart> GetStokList()
        {
            using (var context = new ResitalWEContext())
            {
                var result = from s in context.SKart
                             select new SKart
                             {
                                 StokAdi = s.StokAdi,
                                 BakiyeMiktar = s.BakiyeMiktar,
                                 GirMiktar = s.GirMiktar,
                                 CikMiktar = s.CikMiktar,
                                 AlisFiyat = s.AlisFiyat,
                                 Birim = s.Birim,
                                 KendiDepoMiktar = s.KendiDepoMiktar,
                                 RefNo = s.RefNo,
                                 SatFiyat1 = s.SatFiyat1,
                                 StokNo = s.StokNo
                             };
                var data = result.AsNoTracking().ToList();
                return data;

            }
        }
    }
}
