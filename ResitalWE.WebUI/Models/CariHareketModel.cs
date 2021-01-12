using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Models
{
    public class CariHareketModel
    {
        [Key]
        public string CariNo { get; set; }
        public int SiraNo { get; set; }
        public DateTime Tarih { get; set; }
        public Int16 Tip { get; set; }
        public char BA { get; set; }
        public string Tutar { get; set; }
        public string BorcTutar { get; set; }
        public string AlacakTutar { get; set; }
        public string Aciklama { get; set; }
    }
}
