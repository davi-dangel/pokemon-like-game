using PokemonGame.App.Entities;
using PokemonGame.App.Entities.Movements;
using PokemonGame.App.Interfaces.Entities;
using PokemonGame.App.Interfaces.Services;
using PokemonGame.App.Utils;
using PokemonGame.App.View.Services;

namespace PokemonGame.App.Services
{
    public class PlayerService : IPlayerService
    {
        private readonly IPokemonService _pokemonService;
        private readonly IAtackService _atackService;
        private readonly IMovementService _movementService;

        public PlayerService(IPokemonService pokemonService, IAtackService atackService,
            IMovementService movementService)
        {
            _pokemonService = pokemonService;
            _atackService = atackService;
            _movementService = movementService;
        }

        public IPlayer CreatePlayer(IList<Pokemon> allPokemons)
        {
            string playerName = SetPlayerName();

            int pokemonPosition = ChosePokemon(allPokemons);
            Pokemon pokemon = new Pokemon(allPokemons[pokemonPosition]);
            pokemon.SetAtackPower(SetAtackPower(pokemon.PointsToDestrubuit));
            //TODO: talvez seja bom tirar a regra de negocio daqui
            pokemon.SetDefensePower(pokemon.PointsToDestrubuit - pokemon.AtackPower);
            for(int i = 0; i < 2; i++)
            {
                pokemon.AddMoviment(_movementService.ChooseMovements(pokemon, MovimentServiceView.ChooseMovimentView()));
            }

            return new PlayerHuman(playerName, pokemon);
        }

        public IPlayer CreateComputerPlayer(IList<Pokemon> allPokemons)
        {
            string playerName = "Computer";
            Random random = new Random();
            Pokemon pokemon = allPokemons[random.Next(0, allPokemons.Count() - 1)];
            pokemon.SetAtackPower(random.Next(1, pokemon.PointsToDestrubuit));
            pokemon.SetDefensePower(pokemon.PointsToDestrubuit - pokemon.AtackPower);

            var atacks = _atackService.GetAll();
            pokemon.AddMoviment(atacks[random.Next(0, atacks.Count() - 1)]);

            return new PlayerComputer(playerName, pokemon);
        }

        private string SetPlayerName()
        {
            Console.Write("Entre com seu nome: ");
            var playerName = Console.ReadLine()!.ValidateInputTypeString();
            Console.Clear();

            return playerName;
        }

        private int ChosePokemon(IList<Pokemon> allPokemons)
        {
            _pokemonService.ShowPokemons(allPokemons);
            Console.WriteLine("Agora escolha seu Pokemon");
            int pokemonPosition = Console.ReadLine()!.ValidateInputTypeInt(allPokemons.Count() - 1);
            Console.Clear();
            return pokemonPosition;
        }

        private int SetAtackPower(int points)
        {
            Console.WriteLine($"Você possui {points} para distribuir entre ataque e defesa.\nQuantos pontos irão para o ataque?");
            var atackPoints = Console.ReadLine()!.ValidateInputTypeInt(points);
            Console.Clear();
            return atackPoints;
        }

        private Atack SetAtack(IList<Atack> atacks)
        {
            Console.WriteLine("Agora escolha seu Ataque");
            _atackService.ShowAtacks(atacks);
            int atackPosition = Console.ReadLine()!.ValidateInputTypeInt(atacks.Count() - 1);
            Console.Clear();
            return atacks[atackPosition];
        }
    }
}
