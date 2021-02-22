using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class CariOdemeD:IEntity
    {
        [Key]
 
        public string FisNo { get; set; }
 
        public string CariNo { get; set; }
 
        public string Dvz { get; set; }
 
        public decimal DvzTutar { get; set; }
 
        public double DvzKur { get; set; }
 
        public string Aciklama { get; set; }
 
        public decimal Tutar { get; set; }
 
        public string EvrakNo { get; set; }
 
        public DateTime BelgeTarih { get; set; }
    }
}
