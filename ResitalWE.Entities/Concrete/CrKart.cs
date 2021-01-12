using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Concrete
{
    public class CKart : IEntity
    {
        [Key]
        public string CariNo { get; set; }
        public string Unvan { get; set; }
        public string Unvan2 { get; set; }
        public decimal? Borc { get; set; }
        public decimal? Alacak { get; set; }
        public decimal? Bakiye { get; set; }
        public string CepTelefon { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public string Tip { get; set; }
        public string Adres1 { get; set; }
        public string Adres2 { get; set; }
        public string Adres3 { get; set; }
    }
}
