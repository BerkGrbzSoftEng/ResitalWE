using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class StDepo : IEntity
    {
        [Key]
        public string StokNo { get; set; }
        public string Depo { get; set; }
        public decimal? GirisMiktar { get; set; }
        public decimal? CikisMiktar { get; set; }
        public decimal? RezerveMiktar { get; set; }
        public bool isLocked { get; set; }
    }
}
