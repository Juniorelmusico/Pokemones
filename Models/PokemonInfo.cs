using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemones.Models
{
    public class PokemonInfo
    {
        public Sprites sprites {  get; set; }
        public List<Abilities> abilities { get; set; }
    }
}
