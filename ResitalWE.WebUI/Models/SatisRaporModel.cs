using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class SatisRaporModel
    {
        public int ID { get; set; }
        public string TARIH { get; set; }
        public decimal TOPLAM { get; set; }
        public decimal KDVTOPLAM { get; set; }
        public decimal ARATOPLAM { get; set; }
        public DateTime GUNCELLENMETARIHI { get; set; }
    }
}
