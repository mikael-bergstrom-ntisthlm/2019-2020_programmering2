using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TE17B_ApiServer.Controllers
{
    [Route("api/pokemon")]
    [Route("api/pokemin")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private static List<Pokemon> pokemons = new List<Pokemon>()
        {
            new Pokemon() { Name = "Pikachu"},
            new Pokemon() {Name = "Bulbasaur"},
            new Pokemon() {Name = "Ekans"}
        };

        [HttpGet]
        public ActionResult<List<Pokemon>> Get()
        {
            Pokemon p = new Pokemon();
            p.Name = "Herbert";


            return Ok(pokemons);
        }

        [Route("pikachu")]
        [HttpGet]
        public ActionResult GetPikachu()
        {
            return Ok("Pika!");
        }

        [Route("num/{number}")]
        [HttpGet]
        public ActionResult GetNum(int number)
        {
            return Ok("Your number is: " + number);
        }
    }
}