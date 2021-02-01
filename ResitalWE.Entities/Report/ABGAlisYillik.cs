using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.Entities;

namespace ResitalWE.Entities.Report
{
    public class ABGAlisYillik:IEntity
    {
    
        public int ID { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
