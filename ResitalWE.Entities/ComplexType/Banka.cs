using System;
using System.Collections.Generic;
using System.Text;

namespace ResitalWE.Entities.ComplexType
{
    public class Banka
    {
        public string CariNo { get; set; }
        public decimal? BorcBakiye { get; set; }
        public decimal? AlacakBakiye { get; set; }
        public decimal? Bakiye { get; set; }
        public string Tip { get; set; }
        public DateTime Tarih { get; set; }
        public string EvrakNo { get; set; }
        public string Aciklama { get; set; }
        public DateTime Vade { get; set; }
        public char BA { get; set; }
   
    }
}
