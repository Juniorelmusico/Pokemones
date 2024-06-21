using Pokemones.Models;
using Pokemones.Services;

namespace Pokemones
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            CargarData();
        }

        public async void CargarData()
        {
            PokemonServices poke_services = new PokemonServices();
            var listado_pokemones = await poke_services.DevuelveListadoPokemones();

            ListPokemones.ItemsSource = listado_pokemones;
        }
        public async void MostrarInfoPokemon(object sender, SelectedItemChangedEventArgs e)
        {
            PokemonItem pokemon = (PokemonItem)e.SelectedItem;
            await Navigation.PushAsync(new ResumenPokemon(pokemon));
        }
    }

}
