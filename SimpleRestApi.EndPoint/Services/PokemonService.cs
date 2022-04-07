using Newtonsoft.Json;
using SimpleRestApi.EndPoint.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SimpleRestApi.EndPoint.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;
        public PokemonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _apiBaseUrl = "https://pokeapi.co/api/v2/pokemon";
        }

        public PokemonService()
        { }

        public async Task<PokemonGenericModel> GetPockemonByName(string pokemonName)
        {
            try
            {
                var apiResponse = await _httpClient.GetStringAsync($"{_apiBaseUrl}/{pokemonName}");
                var pokemon = JsonConvert.DeserializeObject<PokemonGenericModel>(apiResponse);
                return pokemon;
            } catch (Exception e)
            {
                return null;
            }
        }

    }
}
