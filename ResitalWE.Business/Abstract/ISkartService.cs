using System;
using System.Collections.Generic;
using System.Text;
using ResitalWE.Core.Utilities.Results;
using ResitalWE.Entities.Concrete;

namespace ResitalWE.Business.Abstract
{
    public interface ISkartService
    {
        IDataResult<List<SKart>> GetList();
    }
}
