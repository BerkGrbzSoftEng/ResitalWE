using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Entities.ComplexType;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface IStokService
    {
        Task<List<StokDepo>> StokDepoList();
        Task<List<StokAnalizRapor>> GetStokAnalizRaporList();
        List<SKart> GetStokBakiyeMiktarList();

        List<SKart> GetStokList();
    }
}
