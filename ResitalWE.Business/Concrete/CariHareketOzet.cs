using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class CariHareketOzet:ICariHareketOzet
    {
        private IABGCariHareketDal _abgCari;

        public CariHareketOzet(IABGCariHareketDal abgCari)
        {
            _abgCari = abgCari;
        }


        public async Task<List<AbgCariHareketOzet>> GetList(Expression<Func<AbgCariHareketOzet, bool>> expression = null)
        {
            var result = _abgCari.GetOzet(expression).Result.ToList();
            return result;
        }
    }
}
