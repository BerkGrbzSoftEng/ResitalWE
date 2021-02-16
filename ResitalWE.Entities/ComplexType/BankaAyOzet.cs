using System;
using System.Collections.Generic;
using System.Text;

namespace ResitalWE.Entities.ComplexType
{
    public class BankaAyOzet
    {
        public int Ay { get; set; }
        public string AyAd { get; set; }
        public decimal? tBorc { get; set; }
        public decimal? tAlacak { get; set; }
    }
}
