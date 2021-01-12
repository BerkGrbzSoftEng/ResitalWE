using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ResitalWE.WebUI.Controllers
{
    public class SatisController : Controller
    {
        [HttpGet("satis-raporlari")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
