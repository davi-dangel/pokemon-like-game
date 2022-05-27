using PokemonGame.App.Utils;

namespace PokemonGame.App.Entities
{
    public class Player
    {
        public string Name { get; set; }
        public bool ItsTurn { get; set; }
        public string Type { get; set; }
        public Pokemon Pokemon { get; set; }

        public Player(string name, Pokemon pokemon, string type)
        {
            Name = name;
            Pokemon = pokemon;
            Type = type;
        }

        public static Player CreatePlayer(List<Pokemon> allPokemons, string type)
        {
            Console.Write("Entre com seu nome: ");
            string playerName = InputValidation.ValidateInputTypeString();

            Console.Clear();

            for (int i = 0; i < allPokemons.Count(); i++)
            {
                Console.WriteLine($"[{i}] - {allPokemons[i].Name} - {allPokemons[i].LifePoints} - {allPokemons[i].Atack}");
            }

            Console.WriteLine("Agora escolha seu Pokemon");

            int pokemonPosition = InputValidation.ValidateInputTypeInt(allPokemons.Count() - 1);

            Pokemon pokemon = new Pokemon(allPokemons[pokemonPosition]);

            Console.Clear();
            return new Player(playerName, pokemon, type);
        }
    }
}
