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
            var result = _crService.GetList(x => x.Tip == "Müşteri");
            List<CariBakiyeModel> model = new List<CariBakiyeModel>();

            foreach (var item in result.Data)
            {
                CariBakiyeModel obj = new CariBakiyeModel();
                obj.Unvan = item.Unvan;
                obj.Bakiye = string.Format("{0:0.##}", item.Bakiye);
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
            var result = _crService.GetList().Data;
            List<CariEkstreListModel> model = new List<CariEkstreListModel>();
            foreach (var item in result)
            {
                model.Add(new CariEkstreListModel
                {
                    
                    CariNo = item.CariNo,
                    Unvan = item.Unvan,
                    Bakiye = string.Format("{0:0.##}",item.Bakiye)
                });
            }
            return View(model);
        }
        [HttpGet("cari-ekstre/cari-ekstre-detay/{cariNo?}")]
        public IActionResult CariEkstreDetay(string cariNo)
        {
            return View();
        }
        [HttpGet("cari-adres-listesi")]
        public IActionResult AdresListesi()
        {
            var result = _crService.GetList().Data;
            List<CariAdresListesiModel> model=new List<CariAdresListesiModel>();
            foreach (var item in result)
            {
                model.Add(new CariAdresListesiModel
                {
                    Telefon1 = item.Telefon,
                    Telefon2 = item.CepTelefon,
                    CariNo = item.CariNo,
                    Unvan = item.Unvan,
                    Adres = item.Adres1+" "+item.Adres2+" "+item.Adres3
                });
            }
            return View(model);
        }

        [HttpGet("cari-hareket")]
        public IActionResult CariHareket()
        {
            var result = _chareService.GetList().Data;
            List<CHare> model=new List<CHare>();
            model.AddRange(result);
            return View(model);
        }

       
    }
}
