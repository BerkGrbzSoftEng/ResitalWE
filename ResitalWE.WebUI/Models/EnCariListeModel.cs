using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class EnCariListeModel
    {
        public string CariNo { get; set; }
        public string Unvan { get; set; }
        public string Tip { get; set; }
        public Nullable<decimal> Bakiye { get; set; }
    }
}
