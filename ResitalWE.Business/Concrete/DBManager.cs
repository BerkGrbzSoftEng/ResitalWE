using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Business.Abstract;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class DBManager:IDBService
    {
        public void SetDbName(string DBNAME)
        {
            DBSetting setting=new DBSetting();
            setting.DbName = DBNAME;
        }
    }
}
