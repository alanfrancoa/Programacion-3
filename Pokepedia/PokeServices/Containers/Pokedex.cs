using PokeServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeServices.Containers
{
    public class Pokedex
    {   //El readonly sirve para agregar cambiar y modificar, pero siempre de la misma lista
        private readonly List<Pokemon> pokemonList;

        public Pokedex()
        {   //preparamos el objeto
            pokemonList = new List<Pokemon>();
        }

        public Pokemon searchPokemonForNumber(long number) 
        {
            ///<summary> Busca pokemon por numero de ID</summary>
            ///<param name="number">Numero del pokemon buscado</param>
            ///<return>El pokemon con ese nro, o null si no lo encuentra</return>
            
            Pokemon searchedPokemon = null;
            foreach (Pokemon pokemon in pokemonList) 
            {
                if (number == pokemon.Id) 
                { 
                    searchedPokemon = pokemon;
                    break;
                }
            }
            return searchedPokemon;
        }
        public bool existForNumber(long number) 
        { 
            return this.searchPokemonForNumber(number) != null;
        }

        public bool addPokemon(Pokemon pokemon) 
        { 
            bool added = !this.existForNumber(pokemon.Id);
            if (added) 
            {
                this.pokemonList.Add(pokemon);
            }
            return added;
        }

        public List<Pokemon> GetPokemons() 
        {   //retorna una copia de la lista para mostrar asi no se manipula la lista original
            return new List<Pokemon>(this.pokemonList);
        }
    }
}
