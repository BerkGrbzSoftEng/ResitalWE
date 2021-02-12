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
        private ICariHareketOzet _cariHareketOzetService;
        private ICariTahsilatService _cariTahsilatService;
        private ICariOdemeService _cariOdemeService;
        public CariController(ICrKartService crService, IChareService chareService, ICariHareketOzet cariHareketOzetService, ICariTahsilatService cariTahsilatService, ICariOdemeService cariOdemeService)
        {
            _crService = crService;
            _chareService = chareService;
            _cariHareketOzetService = cariHareketOzetService;
            _cariTahsilatService = cariTahsilatService;
            _cariOdemeService = cariOdemeService;
        }

        [HttpGet("cari-bakiye-listesi")]
        public IActionResult CariBakiye()
        {
            var result = _crService.GetList(x => x.Tip == "Müşteri");
            List<CariBakiyeModel> model = new List<CariBakiyeModel>();
             
            foreach (var item in result)
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
            var result = _crService.GetList();
            List<CariEkstreListModel> model = new List<CariEkstreListModel>();
            foreach (var item in result)
            {
                model.Add(new CariEkstreListModel
                {

                    CariNo = item.CariNo,
                    Unvan = item.Unvan,
                    Bakiye = string.Format("{0:0.##}", item.Bakiye)
                });
            }
            return View(model);
        }
        [HttpGet("cari-ekstre/cari-ekstre-detay/{cariNo?}")]
        public IActionResult CariEkstreDetay(string cariNo)
        {
            var result = _chareService.GetList(x => x.CariNo == cariNo);
            List<CariEkstreDetayModel> model = new List<CariEkstreDetayModel>();
            ViewBag.CariNo = cariNo;
            foreach (var item in result.Result)
            {
                model.Add(new CariEkstreDetayModel
                {
                    AlacakTutar = string.Format("{0:0.##}", item.AlacakTutar),
                    BorcTutar = string.Format("{0:0.##}", item.BorcTutar),
                    ToplamTutar = string.Format("{0:0.##}", item.Tutar),
                    Aciklama = item.Aciklama,
                    Tarih = item.Tarih,
                    BA = item.BA,
                    CariNo = item.CariNo

                });
            }
            return View(model);
        }
        [HttpGet("cari-adres-listesi")]
        public IActionResult AdresListesi()
        {
          
            var result = _crService.GetList();
            List<CariAdresListesiModel> model = new List<CariAdresListesiModel>();
            foreach (var item in result)
            {
                model.Add(new CariAdresListesiModel
                {
                    Telefon1 = item.Telefon,
                    Telefon2 = item.CepTelefon,
                    CariNo = item.CariNo,
                    Unvan = item.Unvan,
                    Adres = item.Adres1 + " " + item.Adres2 + " " + item.Adres3
                });
            }
            return View(model);
        }

        [HttpGet("cari-hareket")]
        public IActionResult CariHareket()
        {
            var result = _cariHareketOzetService.GetList();
            List<CariHareketOzetModel> model=new List<CariHareketOzetModel>();
            foreach (var item in result.Result)
            {
                model.Add(new CariHareketOzetModel
                {
                    CIKAN = item.CIKAN,
                    GUNCELLENMETARIHI = item.GUNCELLENMETARIHI,
                    GIREN = item.GIREN,
                    ID = item.ID,
                    KDVDAHIL = item.KDVDAHIL,
                    KDVHARIC = item.KDVHARIC,
                    TARIH = item.TARIH
                });
            }
            return View(model);
        }

        [HttpGet("Cari-Tahsilat")]
        public IActionResult CariTahsilat()
        {
            List<CariTahsilatOdemeModel> model=new List<CariTahsilatOdemeModel>();
            var result = _cariTahsilatService.GetTahsilatList();
            model.AddRange( result.Result.Select(x=>new CariTahsilatOdemeModel
            {
                Tutar = x.Tutar,
                CariNo = x.CariNo,
                Aciklama = x.Aciklama,
                Dvz = x.Dvz,
                DvzTutar = x.DvzTutar,
                BelgeTarih = x.BelgeTarih,
                DvzKur = x.DvzKur,
                EvrakNo = x.EvrakNo,
                FisNo = x.FisNo,
                Unvan = x.Unvan
            }));

            return View(model);
        }

        [HttpGet("Cari-Odeme")]
        public IActionResult CariOdeme()
        {
            List<CariTahsilatOdemeModel> model = new List<CariTahsilatOdemeModel>();
            var result = _cariOdemeService.GetOdemeList();
            model.AddRange(result.Result.Select(x => new CariTahsilatOdemeModel
            {
                Tutar = x.Tutar,
                CariNo = x.CariNo,
                Aciklama = x.Aciklama,
                Dvz = x.Dvz,
                DvzTutar = x.DvzTutar,
                BelgeTarih = x.BelgeTarih,
                DvzKur = x.DvzKur,
                EvrakNo = x.EvrakNo,
                FisNo = x.FisNo,
                Unvan = x.Unvan
            }));

            return View(model);
        }
    }
}
