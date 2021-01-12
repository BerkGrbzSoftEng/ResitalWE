using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.Entities.Concrete;
using ResitalWE.WebUI.Models;

namespace ResitalWE.WebUI.Controllers
{
    public class CariController : Controller
    {
        private ICrKartService _crService;
        private IChareService _chareService;
        public CariController(ICrKartService crService, IChareService chareService)
        {
            _crService = crService;
            _chareService = chareService;
        }

        [HttpGet("cari-bakiye-listesi")]
        public IActionResult CariBakiye()
        {
            var result = _crService.GetList(x=>x.Tip=="Müşteri");
            List<CariBakiyeModel> model = new List<CariBakiyeModel>();

            foreach (var item in result.Data)
            {
                CariBakiyeModel obj = new CariBakiyeModel();
                obj.Unvan = item.Unvan;
                obj.Bakiye = string.Format("{0:0.##}",item.Bakiye);
                obj.CariNo = item.CariNo;
                obj.Telefon1 = item.Telefon;
                obj.Telefon2 = item.CepTelefon;
                obj.Unvan2 = item.Unvan2;
                model.Add(obj);
            }

            return View(model);
        }

        [HttpGet("cari-ekstre")]
        public IActionResult CariEkstre()
        {
            return View();
        }

        [HttpGet("cari-adres-listesi")]
        public IActionResult AdresListesi()
        {
            return View();
        }
        [HttpGet("cari-hareket")]
        public IActionResult CariHareket()
        {
            var result = _chareService.GetList();
            List<CariHareketModel> model=new List<CariHareketModel>();
            foreach (var item in result.Data)
            {
                CariHareketModel obj=new CariHareketModel();
                obj.Aciklama = item.Aciklama;
                obj.AlacakTutar = string.Format("{0:0.##}",item.AlacakTutar);
                obj.BorcTutar = string.Format("{0:0.##}", item.BorcTutar);
                obj.Tutar = string.Format("{0:0.##}", item.Tutar);
                obj.CariNo = item.CariNo;
                obj.Tarih = item.Tarih;
                model.Add(obj);
            }
            return View(model);
        }
    }
}
