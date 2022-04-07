using SimpleRestApi.EndPoint.Models;
using System.Threading.Tasks;

namespace SimpleRestApi.EndPoint.Services
{
    public interface IPokemonService
    {
        Task<PokemonGenericModel> GetPockemonByName(string pokemonName);
    }
}
