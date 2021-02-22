using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ResitalWE.Core.Entities;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.DataAccess.Abstract
{
    public interface ISkartDal : IEntityRepository<SKart>
    {
        List<SKart> GetStokBakiyeMiktarList();
        List<SKart> GetStokList();
    }
}
