using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TE17A_ApiServerGrej.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {

        [HttpGet]
        public ActionResult MyPerfectGet()
        {
            return Ok("Nu avslutar vi lektionen. Ha en trevlig helg!");
        }


    }
}