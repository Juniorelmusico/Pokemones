
using Pokemones.Models;
using Pokemones.Services;
using System.Diagnostics;

namespace Pokemones;

public partial class ResumenPokemon : ContentPage
{
    public ResumenPokemon(PokemonItem pokemon)
    {
        InitializeComponent();
        CargaPokemon(pokemon);
    }

    public async void CargaPokemon(PokemonItem pokemon)
    {
        PokemonServices pokemonServices = new PokemonServices();
        var pokemon_info = await pokemonServices.GetPokemonInfo(pokemon);
        string image = pokemon_info.sprites.front_default;
        PokemonImage.Source = image;


        var nombresHabilidades = pokemon_info.abilities
        .Select(a => a.ability.Name)
        .ToList();
        ListPokemons.ItemsSource = nombresHabilidades;
    }
}