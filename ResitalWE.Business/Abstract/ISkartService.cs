using System;
using System.Collections.Generic;
using System.Text;
 
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface ISkartService
    {
        List<SKart> GetList();
    }
}
