using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TE17C_ApiServer.Controllers
{
    [Route("api/pokemon")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() {Name = "Pikachu", Strength = 9},
            new Pokemon() {Name = "Ditto", Strength = 12},
            new Pokemon() {Name = "Bengt-Göran", Strength = 9001}
        };


        [HttpGet]
        public ActionResult<List<Pokemon>> Get()
        {
            return Ok(pokemons);
        }

        [HttpGet]
        [Route("ditto")]
        public ActionResult GetDitto()
        {
            return Ok("Yay");
        }

        [HttpGet]
        [Route("num/{number}")]
        public ActionResult GetByNumber(int number)
        {
            return Ok("N: " + number);
        }


    }
}