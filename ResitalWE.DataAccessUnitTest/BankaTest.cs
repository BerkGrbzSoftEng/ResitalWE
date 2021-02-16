using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.DataAccess.Concrete.EntityFramework;
using Xunit;

namespace ResitalWE.DataAccessUnitTest
{
    public class BankaTest
    {
        private EfBankaDal bankaDal;

       

        [Fact]
        public void CheckViewABGBankaAylikRapor()
        {
            var result = bankaDal.GetAyOzetList(1).Result;
            Assert.Equal(28,result.Count);
        }
    }
}
