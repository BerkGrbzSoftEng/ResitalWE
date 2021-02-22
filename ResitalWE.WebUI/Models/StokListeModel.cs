using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class StokListeModel
    {
        public string StokNo { get; set; }
        public string StokAdi { get; set; }

        public string RefNo { get; set; }

        public string Birim { get; set; }

        public double? SatFiyat { get; set; }

        public double? AlisFiyat { get; set; }

        public decimal? GirMiktar { get; set; }

        public decimal? CikMiktar { get; set; }

        public decimal KendiDepoMiktar { get; set; }
    }
}
