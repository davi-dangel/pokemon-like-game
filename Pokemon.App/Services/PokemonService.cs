using PokemonGame.App.Entities;
using PokemonGame.App.Interfaces;

namespace PokemonGame.App.Services
{
    public class PokemonService : IPokemonService
    {
        public int DecreaseLifePoints(int lifePoints, int atackPoints)
        {
            return lifePoints -= atackPoints;
        }

        public void ShowLifePoints(Pokemon pokemon)
        {
            Console.WriteLine($"{pokemon.Name} - {pokemon.LifePoints}");
        }
    }
}
