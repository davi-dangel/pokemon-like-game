using PokemonGame.App.Entities;
using PokemonGame.App.Interfaces;
using PokemonGame.App.Utils;

namespace PokemonGame.App.Services
{
    public class PlayerService : IPlayerService
    {
        public Player CreatePlayer(List<Pokemon> allPokemons, string type)
        {
            Console.Write("Entre com seu nome: ");
            string playerName = Console.ReadLine()!.ValidateInputTypeString();

            Console.Clear();

            for (int i = 0; i < allPokemons.Count(); i++)
            {
                Console.WriteLine($"[{i}] - {allPokemons[i].Name} - {allPokemons[i].LifePoints} - {allPokemons[i].AtackPower}");
            }

            Console.WriteLine("Agora escolha seu Pokemon");

            int pokemonPosition = Console.ReadLine()!.ValidateInputTypeInt(allPokemons.Count() - 1);

            Pokemon pokemon = new Pokemon(allPokemons[pokemonPosition]);

            Console.Clear();

            return new Player(playerName, pokemon, type); ;
        }
    }
}
