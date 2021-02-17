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
    public class EfStDepoDal : EfEntityRepositoryBase<StDepo, ResitalWEContext>, IStDepoDal
    {
        public async Task<List<StokDepo>> GetStokDepoList()
        {
            using (var context = new ResitalWEContext())
            {
                try
                {
                    var list = from sk in context.SKart
                               join st in context.StDepo on sk.StokNo equals st.StokNo
                               select new StokDepo
                               {
                                   CikisMiktar = st.CikisMiktar,
                                   GirisMiktar = st.GirisMiktar,
                                   RezerveMiktar = st.RezerveMiktar,
                                   StokAdi = sk.StokAdi,
                                   StokNo = sk.StokNo
                               };
                    return await list.ToListAsync();
                }
                catch (Exception e)
                {
                    return null;
                }
            }
        }
    }
}
