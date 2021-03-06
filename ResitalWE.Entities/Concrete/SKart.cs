﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class SKart : IEntity
    {
        [Key]

        public string StokNo { get; set; }
        public string StokAdi { get; set; }

        public string RefNo { get; set; }

        public string Birim { get; set; }

        public double? SatFiyat1 { get; set; }

        public double? AlisFiyat { get; set; }

        public decimal? GirMiktar { get; set; }

        public decimal? CikMiktar { get; set; }

        public decimal KendiDepoMiktar { get; set; }
        [NotMapped]
        public decimal? BakiyeMiktar { get; set; }

    }
}
