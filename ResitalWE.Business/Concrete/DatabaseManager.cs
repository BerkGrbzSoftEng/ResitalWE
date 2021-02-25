using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.ComplexType;

namespace ResitalWE.Business.Concrete
{
    public class DatabaseManager : IDatabaseService
    {
        private IDatabaseDal _dbDal;

        public DatabaseManager(IDatabaseDal dbDal)
        {
            _dbDal = dbDal;
        }

        public async Task<List<Databases>> GetDatabaseList()
        {
            return await _dbDal.GetDbList();
        }

        public void ChangeDB(string dbname)
        {
            _dbDal.ChangeDB(dbname);
        }
    }
}
