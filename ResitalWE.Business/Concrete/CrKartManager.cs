using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.Business.Constants;

using ResitalWE.DataAccess.Abstract;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Concrete
{
    public class CrKartManager : ICrKartService
    {
        private ICrKartDal _crKartDal;

        public CrKartManager(ICrKartDal crKartDal)
        {
            _crKartDal = crKartDal;
        }


        public List<CKart> GetList(Expression<Func<CKart, bool>> expression = null)
        {
            var result = _crKartDal.GetList(expression).ToList();
            return result;
        }

        public List<CKart> TopBorcluList()
        {
            var result = _crKartDal.GetList().Where(x => x.Tip == "Müşteri" && x.BA=="Borc").Select(x => new CKart
            {
                CariNo = x.CariNo,
                Bakiye = x.Bakiye,
                Unvan = x.Unvan,
                Tip = x.Tip

            }).OrderByDescending(x => x.Bakiye).ToList();
            return result;
        }

        public List<CKart> TopAlacakList()
        {
            var result = _crKartDal.GetList().Where(x => x.Tip == "Müşteri" && x.BA == "Alacak").Select(x => new CKart
            {
                CariNo = x.CariNo,
                Bakiye = x.Bakiye,
                Unvan = x.Unvan,
                Tip = x.Tip

            }).OrderByDescending(x => x.Bakiye).ToList();
            return result;
        }
    }
}
