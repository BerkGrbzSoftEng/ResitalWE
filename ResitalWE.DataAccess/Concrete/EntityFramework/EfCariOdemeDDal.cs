using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfCariOdemeDDal:EfEntityRepositoryBase<CariOdemeD,ResitalWEContext>,ICariOdemeDDal
    {
        public async Task<List<CariOdeme>> GetOdemeList()
        {
            using (var context = new ResitalWEContext())
            {
                var result = from cd in context.CariOdemeD
                    join ck in context.CKart on cd.CariNo equals ck.CariNo
                    select new CariOdeme()
                    {
                        CariNo = cd.CariNo,
                        Tutar = cd.Tutar,
                        Aciklama = cd.Aciklama,
                        Unvan = ck.Unvan,
                        BelgeTarih = cd.BelgeTarih,
                        Dvz = cd.Dvz,
                        DvzKur = cd.DvzKur,
                        DvzTutar = cd.DvzTutar,
                        EvrakNo = cd.EvrakNo,
                        FisNo = cd.FisNo
                    };
                return await result.ToListAsync();
            }
        }
    }
}
