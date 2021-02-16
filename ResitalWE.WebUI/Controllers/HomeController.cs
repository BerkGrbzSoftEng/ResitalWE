using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ResitalWE.Business.Abstract;


namespace ResitalWE.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ISatisYillikService _satisYillikService;
        private IAlisYillikService _alisYillikService;
        public HomeController(ISatisYillikService satisYillikService, IAlisYillikService alisYillikService)
        {
            _satisYillikService = satisYillikService;
            _alisYillikService = alisYillikService;
        }

        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public JsonResult GetChartData()
        {
            try
            {
                decimal[] dataSatim = _satisYillikService.Getlist().Result.Select(x => x.Price).ToArray();
                decimal[] dataAlim = _alisYillikService.GetListAsync().Result.Select(x => x.Price).ToArray();
                decimal totalSatim = _satisYillikService.Getlist().Result.Select(x => x.Price).Sum();
                decimal totalAlim = _alisYillikService.GetListAsync().Result.Select(x => x.Price).Sum();
                decimal total = totalAlim+totalSatim;
                return Json(new { success = true, total=total.ToString(),
                    totalSatim=totalSatim,totalAlim=totalAlim,
                    dataSatim = dataSatim, dataAlim = dataAlim, message = "Tablo Verileri Başarıyla Getirildi" });
            }
            catch (Exception e)
            {
                return Json(data: new { success = false, message = "Tablo Verileri Getirilemedi" });
            }
        }

 
    }
}
