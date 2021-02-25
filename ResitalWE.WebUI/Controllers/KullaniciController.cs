using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using ResitalWE.Business.Abstract;
using ResitalWE.WebUI.Models;

namespace ResitalWE.WebUI.Controllers
{
    public class KullaniciController : Controller
    {
        private IDatabaseService _databaseService;

        public KullaniciController(IDatabaseService databaseService)
        {
            _databaseService = databaseService;
        }

        [HttpGet("/ResWE/Giris")]
        public IActionResult Login()
        {
            var obj = _databaseService.GetDatabaseList().Result;
            ViewBag.DB = new SelectList(obj, "name", "name");
            return View();
        }
        [HttpPost("/ResWE/Giris")]
        public IActionResult Login(KullaniciGirisModel model)
        {

            return View();
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet("/ConfigureDB/{dbname}")]
        public JsonResult ConfigureDB(string dbname)
        {
            _databaseService.ChangeDB(dbname);
            return Json(new { statusCode = 200, message = $"Şirket : {dbname}" });
        }
        [HttpGet("/Profil-Ayarlari")]
        public IActionResult ProfileSetting()
        {
            return View();
        }
    }
}
