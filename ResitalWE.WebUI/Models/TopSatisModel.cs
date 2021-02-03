using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class TopSatisModel
    {
        public string FisNo { get; set; }
        public string StokNo { get; set; }
        public string Aciklama { get; set; }
        public Nullable<decimal> NetTutar { get; set; }
    }
}
