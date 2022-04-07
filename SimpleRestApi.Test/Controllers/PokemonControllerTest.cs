using SimpleRestApi.EndPoint.Controllers;
using SimpleRestApi.EndPoint.Services;
using System.Threading.Tasks;
using Xunit;

namespace SimpleRestApi.Test.Controllers
{
    public class PokemonControllerTest
    {
        private readonly PokemonController _pokemonController;
        private readonly IPokemonService _pokemonService;

        public PokemonControllerTest()
        {
            _pokemonService = new PokemonService();
            _pokemonController = new PokemonController(_pokemonService);
        }
        
        [Theory]
        [InlineData("snorlax")]
        [InlineData("1")]
        public async Task PokemonDataTest(string pokemonName)
        {
            //Arrange

            //Act
            var result = await _pokemonController.PokemonData(pokemonName);

            //Assert
            Assert.NotNull(result);
        }
    }
}
