using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Report
{
    
    public class vw_ABGBankaAylikRapor
    {
        
        public string CariNo { get; set; }
        public string Unvan { get; set; }
        public int Ay { get; set; }
        public string AyAd { get; set; }
        public decimal? Borc { get; set; }
        public decimal? Alacak { get; set; }
    }
}
