using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using ResitalWE.Core.DataAccess;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.DataAccess.Concrete.EntityFramework.Context;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Concrete.EntityFramework
{
    public class EfCariTahsilatDDal:EfEntityRepositoryBase<CariTahsilatD,ResitalWEContext>,ICariTahsilatDDal
    {
        public async Task<List<CariTahsilat>> GetList()
        {
            using (var context=new ResitalWEContext())
            {
                var result = from cd in context.CariTahsilatD
                    join ck in context.CKart on cd.CariNo equals ck.CariNo
                    select new CariTahsilat
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
