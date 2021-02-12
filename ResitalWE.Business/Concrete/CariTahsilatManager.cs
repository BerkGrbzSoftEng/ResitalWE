using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.ComplexType;

namespace ResitalWE.Business.Concrete
{
    public class CariTahsilatManager : ICariTahsilatService
    {
        private ICariTahsilatDDal _cariTahsilatD;

        public CariTahsilatManager(ICariTahsilatDDal cariTahsilatD)
        {
            _cariTahsilatD = cariTahsilatD;
        }

        public async Task<List<CariTahsilat>> GetTahsilatList()
        {
            return  (await _cariTahsilatD.GetList());
        }
    }
}
