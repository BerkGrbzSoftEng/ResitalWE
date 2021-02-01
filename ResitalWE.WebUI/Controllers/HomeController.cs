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
                decimal total = TotalPriceCheck(dataSatim, dataAlim);
                return Json(new { success = true, total=total.ToString(),dataSatim = dataSatim, dataAlim = dataAlim, message = "Data Getirme Başarılı" });
            }
            catch (Exception e)
            {
                return Json(data: new { success = false, message = "Data Getirme Başarısız" });
            }
        }

        private decimal TotalPriceCheck(decimal[] arraySatis, decimal[] arrayAlis)
        {
            if (arraySatis.Length > 0 || arrayAlis.Length > 0)
            {
                decimal price = 0;
                for (int i = 0; i < 12; i++)
                {
                    price += arraySatis[i] - arrayAlis[i];
                   
                }
                return price;
            }
            return 0;
        }
    }
}
