using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResitalWE.DataAccess.Concrete.EntityFramework;

namespace ResitalWE.DataAccess.Test
{
    [TestClass]
    public class CHare
    {
        private EfReportDal report = new EfReportDal();
        [TestMethod]
        public void GetReport()
        {
            DateTime bitTarih=DateTime.Now;
            DateTime basTarih=new DateTime(2019,09,17,15,40,00,00);
            var result = report.GetBankaKrediDetays(basTarih,bitTarih);
            Assert.AreEqual(result.Count(),12);
        }
    }
}
