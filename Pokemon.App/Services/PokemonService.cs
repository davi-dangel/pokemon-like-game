using PokemonGame.App.Entities;
using PokemonGame.App.Interfaces.Services;

namespace PokemonGame.App.Services
{
    public class PokemonService : IPokemonService
    {
        private readonly ITypeService _typeService;
        public PokemonService(ITypeService typeService)
        {
            _typeService = typeService;
        }

        public int DecreaseLifePoints(int lifePoints, int atackPoints)
        {
            return lifePoints -= atackPoints;
        }

        public IList<Pokemon> GetAll()
        {
            var types = _typeService.GetAll();

            List<Pokemon> allPokemons = new();
            //TODO: Ver como vai ficar depois da implementação do banco, senão precisa melhorar
            allPokemons.Add(new Pokemon("Charizard", 150, types.First(x => x.GetType().Name == "FireType")));
            allPokemons.Add(new Pokemon("Ivysauro", 150, types.First(x => x.GetType().Name == "GrassType")));
            allPokemons.Add(new Pokemon("Blastoise", 150, types.First(x => x.GetType().Name == "WaterType")));

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
