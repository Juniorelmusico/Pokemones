using Newtonsoft.Json;
using Pokemones.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemones.Services
{
    public class PokemonServices
    {
        public async Task<List<PokemonItem>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&offset=20";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListPokemons lista_pokemons = JsonConvert.DeserializeObject<ListPokemons>(json);

            Debug.WriteLine("SIII");
            Debug.WriteLine(json);
            return lista_pokemons.results;
        }
    }

    public async Task<CaracteristicasPokemon> DevuelveCaracteristicasPokemon(string url)
    {
        String json = await _httpClient.GetStringAsync(url);
        CaracteristicasPokemon caracteristicas = JsonConvert.DeserializeObject<CaracteristicasPokemon>(json);
        return caracteristicas;
    }
}
