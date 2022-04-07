using Microsoft.AspNetCore.Mvc;
using SimpleRestApi.EndPoint.Services;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleRestApi.EndPoint.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonService _pokemonService;
        public PokemonController(IPokemonService pokemonService)
        {
            _pokemonService = pokemonService;
        }

        // POST api/<PokemonController>
        [HttpPost("/pokemon-data/{pokemonName}")]
        public async Task<ActionResult> PokemonData(string pokemonName)
        {
            if (string.IsNullOrEmpty(pokemonName))
                return BadRequest("Pokemon name is missing");

            var pokemonData = await _pokemonService.GetPockemonByName(pokemonName);
            if (pokemonData == null)
            {
                return BadRequest($"{pokemonName} was not found");
            } else
            {
                return Ok(pokemonData);
            }

        }
    }
}
