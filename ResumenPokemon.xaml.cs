using Newtonsoft.Json;
using Pokemones.Models;
using Pokemones.Services;
using System.Diagnostics;

namespace Pokemones;

public partial class ResumenPokemon : ContentPage
{
    public ResumenPokemon( string url)
    {
        InitializeComponent();
        CargaPokemon(url);
    }

    public async void CargaPokemon (string url)
    { 
        PokemonServices poke_services = new PokemonServices();
        CaracteristicasPokemon = await poke_services.DevuelveCaracteristicasPokemon(url);
        Debug.WriteLine(JsonConvert.SerializeObject(CaracteristicasPokemon));
        ImagePokemon.Source = CaracteristicasPokemon.sprite.front_default;

        string habilidades = "";
        foreach (var ability in CaracteristicasPokemon.abilities)
        {
            habilidades += ability.ability.name + " | ";
        }
       Habilidades.Text = habilidades;
    }
}