﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeServices.Models
{
    public class PokemonType
    {
        public string Name { get; }

        public PokemonType(string name)
        {
            this.Name = name;
        }
        public override string ToString() 
        {
            return this.Name;
        }   
    }

}
