using PokemonGame.App.Entities;
using PokemonGame.App.Interfaces.Services;

namespace PokemonGame.App.Services
{
    public class PokemonService : IPokemonService
    {
        public int DecreaseLifePoints(int lifePoints, int atackPoints)
        {
            return lifePoints -= atackPoints;
        }

        public IList<Pokemon> GetAll()
        {
            List<Pokemon> allPokemons = new();
            allPokemons.Add(new Pokemon("Charizard", 150));
            allPokemons.Add(new Pokemon("Ivysauro", 150));
            allPokemons.Add(new Pokemon("Blastoise", 150));

            return allPokemons;
        }

        public void ShowLifePoints(Pokemon pokemon)
        {
            Console.WriteLine($"{pokemon.Name} - {pokemon.LifePoints}");
        }

        public void ShowPokemons(IList<Pokemon> pokemons)
        {
            for (int i = 0; i < pokemons.Count(); i++)
            {
                Console.WriteLine($"[{i}] - {pokemons[i].Name} - {pokemons[i].LifePoints} - {pokemons[i].AtackPower} - {pokemons[i].DefensePower}");
            }
        }
    }
}
