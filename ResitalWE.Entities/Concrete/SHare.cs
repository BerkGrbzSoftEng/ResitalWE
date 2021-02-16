using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class SHare : IEntity
    {
        [Key]
        public string StokNo { get; set; }

        public string SiraNo { get; set; }

        public char GC { get; set; }
        public decimal? Miktar { get; set; }
        public decimal? Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public string Aciklama { get; set; }
        public decimal? Tutar { get; set; }
        public decimal? KDv { get; set; }
        public decimal? Iskonto { get; set; }
        public string CariNo { get; set; }
    }
}
