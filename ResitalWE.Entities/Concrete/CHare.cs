using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class CHare : IEntity
    {
        [Key]
        public int SiraNo { get; set; }
        public string CariNo { get; set; }
        public DateTime Tarih { get; set; }
        public Int16 Tip { get; set; }
        public char BA { get; set; }
        public decimal? Tutar { get; set; }
        public decimal? BorcTutar { get; set; }
        public decimal? AlacakTutar { get; set; }
        public string Aciklama { get; set; }
        public string EvrakNo { get; set; }
        public DateTime Vade { get; set; }
      
    }
}
