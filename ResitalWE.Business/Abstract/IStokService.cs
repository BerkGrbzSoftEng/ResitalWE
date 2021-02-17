using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Entities.ComplexType;

namespace ResitalWE.Business.Abstract
{
    public interface IStokService
    {
        Task<List<StokDepo>> StokDepoList();
        int Countt();
        void Result();
    }
}
