using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class CariHareketOzetModel
    {
        public int ID { get; set; }
        public string TARIH { get; set; }
        public decimal GIREN { get; set; }
        public decimal CIKAN { get; set; }
        public decimal KDVDAHIL { get; set; }
        public decimal KDVHARIC { get; set; }
        public DateTime GUNCELLENMETARIHI { get; set; }
    }
}
