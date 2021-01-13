using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ResitalWE.DataAccess.Concrete.EntityFramework;

namespace ResitalWE.DataAccess.Test
{
    [TestClass]
    public class CrKartTest
    {
        EfCrKartDal crKartDal = new EfCrKartDal();
        [TestMethod]
        public void CariKartGyByCariNo()
        {
    
            var result = crKartDal.GetByCariNo("101 01 02");
            Assert.AreEqual("101 01 02", result.CariNo);
        }

        [TestMethod]
        public void CariKartCount()
        {
            int result = crKartDal.Count();
            Assert.AreEqual(3469,result);
        }

       

    }
}
