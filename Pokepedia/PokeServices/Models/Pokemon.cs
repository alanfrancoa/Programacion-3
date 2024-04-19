using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeServices.Models
{
    public class Pokemon
    {
        public long Id { get; }
        public string Name { get; set; }
        public PokemonType Type { get; set; }

        public Pokemon(long id, string name, PokemonType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
