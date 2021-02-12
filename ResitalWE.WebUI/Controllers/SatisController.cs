using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.WebUI.Models;

namespace ResitalWE.WebUI.Controllers
{
    public class SatisController : Controller
    {
        private ISatisRaporService _satisRaporService;

        public SatisController(ISatisRaporService satisRaporService)
        {
            _satisRaporService = satisRaporService;
        }

        [HttpGet("satis-raporlari")]
        public IActionResult SatisRapor()
        {
            List<SatisRaporModel> model = new List<SatisRaporModel>();
            Thread.Sleep(500);
            var result = _satisRaporService.GetList();
            model.AddRange(result.Result.Select(x=>new SatisRaporModel
            {
                KDVTOPLAM = x.KDVTOPLAM,
                TOPLAM = x.TOPLAM,
                ARATOPLAM = x.ARATOPLAM,
                GUNCELLENMETARIHI = x.GUNCELLENMETARIH,
                TARIH = x.TARIH,
                ID = x.ID
            }));
            return View(model);
        }

        [HttpGet("satis-raporlari/satis-raporlari-detay/{date?}")]
        public IActionResult SatisRaporDetails(string date)
        {
            List<SatisRaporDetayModel> model = new List<SatisRaporDetayModel>();
            Thread.Sleep(500);
            ViewBag.Tarih = date;
            var result = _satisRaporService.GetListDetail(date.Trim().ToUpper().Replace(" ",string.Empty));
            if (result.Result!=null)
            {
                model.AddRange(result.Result.Select(x => new SatisRaporDetayModel
                {
                    FisNo = x.FisNo,
                    Tutar = (decimal)x.Tutar,
                    Aciklama = x.Aciklama,
                    Tarih = (DateTime)x.Tarih,
                    StokNo = x.StokNo
                }));
            }
            else
            {
                return View();
            }
           
            return View(model);
        }
    }
}
