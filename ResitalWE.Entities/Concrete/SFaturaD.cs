 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class SFaturaD:IEntity
    {
        [Key]
        public string FisNo { get; set; }
        public string StokNo { get; set; }
        public string Aciklama { get; set; }
        public Nullable<decimal> NetTutar { get; set; }
        public Nullable<DateTime> Tarih { get; set; }
        public Nullable<decimal> Miktar { get; set; }
        public Nullable<double> Fiyat { get; set; }
        public Nullable<decimal> Tutar { get; set; }
        public string Dvz { get; set; }
        public decimal DvzTutar { get; set; }
        public double DvzKur { get; set; }
    }
}
