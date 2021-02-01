using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Report
{
    public class AbgSatisRapor:IEntity
    {
        public int ID { get; set; }
        public string TARIH { get; set; }
        public decimal TOPLAM { get; set; }
        public decimal KDVTOPLAM { get; set; }
        public decimal ARATOPLAM { get; set; }
        public DateTime GUNCELLENMETARIH { get; set; }
    }
}
