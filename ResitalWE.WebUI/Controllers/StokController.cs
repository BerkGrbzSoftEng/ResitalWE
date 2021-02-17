using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;

namespace ResitalWE.WebUI.Controllers
{
    public class StokController : Controller
    {
        private IStokService _stokService;

        public StokController(IStokService stokService)
        {
            _stokService = stokService;
        }
        [HttpGet("Stok-MaxMin-Liste")]
        public IActionResult StokMaxMin()
        {

            var obj = _stokService.StokDepoList().Result;
            int cnt = _stokService.Countt();
            var a = obj;
            return View();
        }

        [HttpGet("Stok-Analiz-Liste")]
        public IActionResult StokAnaliz()
        {

            _stokService.Result();
            return View();
        }
    }
}
