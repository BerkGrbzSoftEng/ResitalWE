using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Report
{
    public class Report:IEntity
    {
        public class BankaKrediDetay : IEntity
        {

            public string CariNo { get; set; }
            public string Unvan { get; set; }
            public decimal BorcTutar { get; set; }
            public decimal AlacakTutar { get; set; }
        }

        
    }
}
