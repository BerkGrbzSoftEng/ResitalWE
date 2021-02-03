using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface ISFaturaDService
    {
        Task<List<SFaturaD>> GetList();
    }
}
