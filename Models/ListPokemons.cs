﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemones.Models
{
    public class ListPokemons
    {
        public int count { get; set; }
        public List<PokemonItem> Results { get; set; }
    }
}
