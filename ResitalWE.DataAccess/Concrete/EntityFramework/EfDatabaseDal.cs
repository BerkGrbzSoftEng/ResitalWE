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
    public class EfDatabaseDal : EfEntityRepositoryBase<DBSetting, ResitalWeUserContext>, IDatabaseDal
    {
        public async Task<List<Databases>> GetDbList()
        {
            using (var context = new ResitalWeUserContext())
            {
                var obj = await context.Databases.FromSqlRaw("select * from sys.databases where owner_sid not in (0x01)").ToListAsync();
                List<Databases> model = new List<Databases>();
                model.AddRange(obj.Select(x => new Databases
                {
                    name = x.name,
                    database_id = x.database_id
                }));
                return model;
            }
        }

        public async Task<bool> IsChangeDB()
        {
            throw new NotImplementedException();
        }

        public void ChangeDB(string dbname)
        {
            using (var context=new ResitalWEContext())
            { 
                context.Doldur(dbname);
            }
        }


    }
}
