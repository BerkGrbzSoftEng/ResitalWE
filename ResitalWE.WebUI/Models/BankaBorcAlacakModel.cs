using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class BankaBorcAlacakModel
    {
        public string CariNo { get; set; }
        public string Unvan { get; set; }
        public decimal? Alacak { get; set; }
        public decimal? Borc { get; set; }
        public decimal? Bakiye { get; set; }
        public string BA { get; set; }
    }
}
