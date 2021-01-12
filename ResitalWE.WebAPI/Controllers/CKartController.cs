using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResitalWE.Business.Abstract;


namespace ResitalWE.WebAPI.Controllers
{
    [Route("api/CariKart")]
    [ApiController]
    public class CKartController : ControllerBase
    {
        private ICrKartService _crKartService;

        public CKartController(ICrKartService crKartService)
        {
            _crKartService = crKartService;
        }

        [HttpGet("TumCari")]
        public IActionResult GetAllCrKart()
        {
            var result = _crKartService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("Cari/{cariNo}")]
        public IActionResult GetById(string cariNo)
        {
            var result = _crKartService.GetByCariNo(cariNo.Trim());
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
        [HttpGet("Toplam")]
        public IActionResult GetByCountCari()
        {
            var result = _crKartService.Count();
            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
