using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Abstract
{
    public interface IDatabaseDal : IEntityRepository<DBSetting>
    {
        Task<List<Databases>> GetDbList();
        Task<bool> IsChangeDB();
        void ChangeDB(string dbname);

    }
}
