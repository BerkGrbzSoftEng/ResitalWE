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
    public class AnalizController : Controller
    {
        private ICrKartService _ckartService;
        private ISFaturaDService _sFaturaDService;
        public AnalizController(ICrKartService ckartService, ISFaturaDService sFaturaDService)
        {
            _ckartService = ckartService;
            _sFaturaDService = sFaturaDService;
        }
        [HttpGet("En-Cok-Borclu")]
        public IActionResult TopBorclu()
        {
            Thread.Sleep(500);
            var list = _ckartService.TopBorcluList();
            List<EnCariListeModel> model=new List<EnCariListeModel>();
            model.AddRange(list.Select(x=>new EnCariListeModel
            {
                Bakiye = x.Bakiye,
                Tip = x.Tip,
                Unvan = x.Unvan,
                CariNo = x.CariNo
                
            }));
            return View(model);
        }

        [HttpGet("En-Cok-Alacakli")]
        public IActionResult TopAlacakli()
        {
            Thread.Sleep(500);
            var list = _ckartService.TopAlacakList();
            List<EnCariListeModel> model = new List<EnCariListeModel>();
            model.AddRange(list.Select(x => new EnCariListeModel
            {
                Bakiye = x.Bakiye,
                Tip = x.Tip,
                Unvan = x.Unvan,
                CariNo = x.CariNo

            }));
            return View(model);
        }

        [HttpGet("En-Cok-Satis")]
        public IActionResult TopSatis()
        {
            List<TopSatisModel> model=new List<TopSatisModel>();
            var list = _sFaturaDService.GetList();
            model.AddRange(list.Result.Select(x=>new TopSatisModel
            {
                Aciklama = x.Aciklama,
                StokNo = x.StokNo,
                NetTutar = x.NetTutar,
                FisNo = x.FisNo
            }));
            return View(model);
        }


        public IActionResult TopCiro()
        {
            return View();
        }

    }
}
