using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.ComplexType
{
    public class CariTahsilat
    {
        public string FisNo { get; set; }
        public string CariNo { get; set; }
        public string Dvz { get; set; }
        public decimal DvzTutar { get; set; }
        public double DvzKur { get; set; }
        public string Aciklama { get; set; }
        public decimal Tutar { get; set; }
        public string EvrakNo { get; set; }
        public DateTime BelgeTarih { get; set; }
        public string Unvan { get; set; }
    }
}
