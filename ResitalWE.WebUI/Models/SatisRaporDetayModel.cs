using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class SatisRaporDetayModel
    {
        public string FisNo { get; set; }
        public string StokNo { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public decimal Tutar { get; set; }
 
    }
}
