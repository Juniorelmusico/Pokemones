using Newtonsoft.Json;
using Pokemones.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Pokemones.Services
{
    internal class PokemonServices
    {
        public async Task<List<PokemonItem>> DevuelveListadoPokemones()
        {
            string url = "https://pokeapi.co/api/v2/pokemon/?limit=20&offset=20";
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            ListPokemons lista_pokemons = JsonConvert.DeserializeObject<ListPokemons>(json);
            Debug.WriteLine("SIII");
            Debug.WriteLine(json);
            return lista_pokemons.Results;
        }

         public async Task<PokemonInfo> GetPokemonInfo(PokemonItem pokemon)
         {
            string url = pokemon.url;
            HttpClient client = new HttpClient();
            string json = await client.GetStringAsync(url);
            PokemonInfo pokemon_info = JsonConvert.DeserializeObject<PokemonInfo>(json);
            Debug.WriteLine("SIII");
            Debug.WriteLine(json);
            return pokemon_info;
         }
    }
}
