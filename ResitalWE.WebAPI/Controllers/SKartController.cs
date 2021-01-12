using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResitalWE.Business.Abstract;

namespace ResitalWE.WebAPI.Controllers
{
    [Route("api/SKart")]
    [ApiController]
    public class SKartController : ControllerBase
    {
        private ISkartService _skartService;

        public SKartController(ISkartService skartService)
        {
            _skartService = skartService;
        }
        [HttpGet("TumListe")]
        public IActionResult GetList()
        {
            var result = _skartService.GetList();
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }
    }
}
