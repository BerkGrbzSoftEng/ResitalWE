using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class AbgCariHareketOzet:IEntity
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
