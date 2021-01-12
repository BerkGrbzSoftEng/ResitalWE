using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class SKart:IEntity
    {
        [Key]
        public string StokNo { get; set; }
        public string StokAdi { get; set; }
        public decimal KendiDepoMiktar { get; set; }
        public string Birim { get; set; }
    }
}
