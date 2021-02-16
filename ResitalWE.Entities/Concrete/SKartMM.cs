using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class SKartMM : IEntity
    {
        [Key]
        public string StokNo { get; set; }
        public string Depo { get; set; }
        public decimal? MinMiktar { get; set; }
        public decimal? MaxMiktar { get; set; }
        public string Raf { get; set; }
    }
}
