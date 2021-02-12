using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class DBSetting:IEntity
    {
        public string DbName { get; set; }
    }
}
