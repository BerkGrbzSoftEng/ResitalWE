using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using ResitalWE.Business.Abstract;
using ResitalWE.WebUI.Models;

namespace ResitalWE.WebUI.Controllers
{
    public class BankaController : Controller
    {
        private IBankaService _bankaService;

        public BankaController(IBankaService bankaService)
        {
            _bankaService = bankaService;
        }
        [HttpGet("Banka-Borc-Alacak")]
        public IActionResult BorcAlacak()
        {
            List<BankaBorcAlacakModel> data = new List<BankaBorcAlacakModel>();
            var model = _bankaService.GetBankList();
            data.AddRange(model.Result.Select(x=>new BankaBorcAlacakModel
            {
                Bakiye = x.Bakiye,
                Unvan = x.Unvan,
                BA = x.BA,
                Alacak = x.Alacak,
                Borc = x.Borc,
                CariNo = x.CariNo
            }));
            return View(data);
        }
        [HttpGet("Banka-Hareket-Liste")]
        public IActionResult Hareket()
        {
            var obj = _bankaService.GetBankList().Result.Select(x => x);
            ViewBag.Banka = new SelectList(obj, "CariNo", "Unvan");
            return View();
        }

        [HttpGet("Banka-Hareket-Liste/{CariNo}")]
        public JsonResult Hareket(string cariNo)
        {
           
            try
            {
                var data = _bankaService.GetHareketList(cariNo).Result.ToList();
            
                if (data.Count==0)
                {

                    return Json(new { message = "Data Boş" });

                }

               
                return Json(data);

            }
            catch (Exception e)
            {
                return Json(new {message = "Hata"});
            }
           
    
        }

        [HttpGet("Banka-Bakiye-Liste")]
        public IActionResult Bakiye()
        {
            List<BankaListModel> model=new List<BankaListModel>();
            var obj = _bankaService.GetBankList().Result.ToList();
            ViewBag.toplamBorc=obj.Sum(x => x.Borc);
            ViewBag.toplamAlacak = obj.Sum(x => x.Alacak);
            model.AddRange(obj.Select(x=>new BankaListModel
            {
                Unvan = x.Unvan,
                Alacak = x.Alacak,
                Borc = x.Borc,
                CariNo = x.CariNo,
                 
            }));
            return View(model);
        }
    }
}
