using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class CariEkstreDetayModel
    {
        public string CariNo { get; set; }
        public string BorcTutar { get; set; }
        public string AlacakTutar { get; set; }
        public string ToplamTutar { get; set; }
        public string Aciklama { get; set; }
        public DateTime Tarih { get; set; }
        public char BA { get; set; }
         
    }
}
