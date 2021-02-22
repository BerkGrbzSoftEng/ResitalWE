using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ResitalWE.Business.Abstract;
using ResitalWE.WebUI.Models;

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

            return View();
        }
        [HttpGet("Stok-BakiyeMiktar-Liste")]
        public IActionResult StokBakiye()
        {

            return View();
        }

        [HttpGet("GetStokBakiyeMiktar")]
        public JsonResult GetStokBakiye()
        {
            List<StokBakiyeMiktarModel> model = new List<StokBakiyeMiktarModel>();
            var result = _stokService.GetStokBakiyeMiktarList();
            model.AddRange(result.Select(x => new StokBakiyeMiktarModel
            {
                StokAdi = x.StokAdi,
                BakiyeMiktar = x.BakiyeMiktar,
                StokNo = x.StokNo
            }));
            return Json(model);
        }

        [HttpGet("Stok-Analiz-Liste")]
        public IActionResult StokAnaliz()
        {
            List<StokAnalizRaporModel> model = new List<StokAnalizRaporModel>();
            var obj = _stokService.GetStokAnalizRaporList().Result;
            model.AddRange(obj.Select(x => new StokAnalizRaporModel
            {
                Unvan = x.Unvan,
                Adet = x.SAT_URUNSAY,
                CariNo = x.CariNo
            }));
            return View(model);
        }

        [HttpGet("Stok-Liste")]
        public IActionResult StokListe()
        {

            return View();
        }
        [HttpGet("GetStokList")]
        public JsonResult GetStokList()
        {
            List<StokListeModel> model = new List<StokListeModel>();
            var result = _stokService.GetStokList();
            model.AddRange(result.Select(x => new StokListeModel
            {
                StokAdi = x.StokAdi,
                StokNo = x.StokNo,
                CikMiktar = x.CikMiktar,
                GirMiktar = x.GirMiktar,
                SatFiyat = x.SatFiyat1,
                Birim = x.Birim,
                AlisFiyat = x.AlisFiyat,
                KendiDepoMiktar = x.KendiDepoMiktar,
                RefNo = x.RefNo
            }));
            return Json(model);
        }

    }
}
