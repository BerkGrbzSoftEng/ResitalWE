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
        List<AyModel> model = new List<AyModel>();
        private void GetMonth()
        {

            model.Add(new AyModel() { AyAd = "Ocak", Ay = 1 });
            model.Add(new AyModel() { AyAd = "Şubat", Ay = 2 });
            model.Add(new AyModel() { AyAd = "Mart", Ay = 3 });
            model.Add(new AyModel() { AyAd = "Nisan", Ay = 4 });
            model.Add(new AyModel() { AyAd = "Mayıs", Ay = 5 });
            model.Add(new AyModel() { AyAd = "Haziran", Ay = 6 });
            model.Add(new AyModel() { AyAd = "Temmuz", Ay = 7 });
            model.Add(new AyModel() { AyAd = "Ağustos", Ay = 8 });
            model.Add(new AyModel() { AyAd = "Eylül", Ay = 9 });
            model.Add(new AyModel() { AyAd = "Ekim", Ay = 10 });
            model.Add(new AyModel() { AyAd = "Kasım", Ay = 11 });
            model.Add(new AyModel() { AyAd = "Aralık", Ay = 12 });

        }
        public BankaController(IBankaService bankaService)
        {
            _bankaService = bankaService;
        }
        [HttpGet("Banka-Borc-Alacak")]
        public IActionResult BorcAlacak()
        {
            List<BankaBorcAlacakModel> data = new List<BankaBorcAlacakModel>();
            var model = _bankaService.GetBankList();
            data.AddRange(model.Result.Select(x => new BankaBorcAlacakModel
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

                if (data.Count == 0)
                {

                    return Json(new { message = "Data Boş" });

                }


                return Json(data);

            }
            catch (Exception e)
            {
                return Json(new { message = "Hata" });
            }


        }

        [HttpGet("Banka-Bakiye-Liste")]
        public IActionResult Bakiye()
        {
            List<BankaListModel> model = new List<BankaListModel>();
            var obj = _bankaService.GetBankList().Result.ToList();
            ViewBag.toplamBorc = obj.Sum(x => x.Borc);
            ViewBag.toplamAlacak = obj.Sum(x => x.Alacak);
            model.AddRange(obj.Select(x => new BankaListModel
            {
                Unvan = x.Unvan,
                Alacak = x.Alacak,
                Borc = x.Borc,
                CariNo = x.CariNo,

            }));
            return View(model);
        }
        [HttpGet("Banka-AyOzet-Liste")]
        public IActionResult BankaAyOzet()
        {
            List<BankaAyOzetModel> model = new List<BankaAyOzetModel>();
            var obj = _bankaService.GetAylikToplamList().Result.ToList();
            model.AddRange(obj.Select(x => new BankaAyOzetModel
            {
                Ay = x.Ay,
                tBorc = x.tBorc,
                tAlacak = x.tAlacak,
                AyAd = x.AyAd
            }));
            GetMonth();
            ViewBag.Ay = new SelectList(model, "Ay", "AyAd");



            return View(model);
        }

        [HttpGet("Banka-AyOzet-Liste/{Ay}")]
        public JsonResult BankaAyOzet(int ay)
        {
            try
            {
                var data = _bankaService.GetAylikList(ay).Result.ToList();

                if (data.Count == 0)
                {

                    return Json(new { message = "Data Boş" });

                }


                return Json(data);

            }
            catch (Exception e)
            {
                return Json(new { message = "Hata" });
            }
        }
    }
}
