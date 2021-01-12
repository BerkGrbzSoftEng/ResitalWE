using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class CariBakiyeModel
    {
        [Key]
        public string CariNo { get; set; }

        public string Unvan { get; set; }
        public string Unvan2 { get; set; }
        public string Telefon1 { get; set; }
        public string Telefon2 { get; set; }
        public string? Bakiye { get; set; }
    }
}
