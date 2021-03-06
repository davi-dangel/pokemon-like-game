using PokemonGame.App.Entities;
using PokemonGame.App.Enums;
using PokemonGame.App.Interfaces.Entities;
using PokemonGame.App.Interfaces.Services;
using PokemonGame.App.Utils;

namespace PokemonGame.App.Services
{
    public class GameService : IGameService
    {
        private readonly IPokemonService _pokemonService;
        private readonly IPlayerService _playerService;

        public GameService(IPokemonService pokemonService, IPlayerService playerService1)
        {
            _pokemonService = pokemonService;
            _playerService = playerService1;
        }

        public Game CreateGame()
        {
            Game game = new Game();
            game.SetGameMode();
            SetPlayers(game.GameMode, _pokemonService.GetAll()).ForEach(p => game.SetPlayer(p));

            return game;
        }

        public void StartGame(Game game)
        {
            while (VerifyPokemonsLifePoints(game.Players))
            {
                DoMoviment(game.Players);
                InvertTurn(game.Players);
                ShowAllLifePoints(game.Players);
            }
            //TODO: Declarar o fim da batalha
            Console.WriteLine("Fim da batalha");
        }

        private List<IPlayer> SetPlayers(string gameMode, IList<Pokemon> allPokemons)
        {
            List<IPlayer> players = new List<IPlayer>();
            if (gameMode == GameModeEnum.SOLO)
            {
                players.Add(_playerService.CreatePlayer(allPokemons));
                players.Add(_playerService.CreateComputerPlayer(allPokemons));
            }
            else
            {
                players.Add(_playerService!.CreatePlayer(allPokemons));
                players.Add(_playerService!.CreatePlayer(allPokemons));
            }

            return players;

        }

        private void ShowAllLifePoints(List<IPlayer> players)
        {
            foreach (IPlayer player in players)
            {
                _pokemonService.ShowLifePoints(player.Pokemon);
            }
        }

        private void DoMoviment(List<IPlayer> players)
        {
            if (players.First(x => x.GetType() == typeof(PlayerHuman)).ItsTurn == true)
            {
                Console.WriteLine("Qual o seu movimento?");
                Console.WriteLine("[0] - Atacar");
                int movimentChosed = Console.ReadLine()!.ValidateInputTypeInt(0);

                Dictionary<string, Pokemon> pokemons = new Dictionary<string, Pokemon>();
                pokemons.Add(PokemonStatusEnum.ACTIVE, players.First(x => x.ItsTurn == true).Pokemon);
                pokemons.Add(PokemonStatusEnum.DISABLED, players.First(x => x.ItsTurn == false).Pokemon);

                pokemons[PokemonStatusEnum.ACTIVE].Movements[movimentChosed].DoMoviment(pokemons);
            }
            else
            {
                //TODO: Criar um modulo para quando for a vez do computador jogar
                //Fazer o modulo depois que definir como serão os movimentos
            }
            Console.Clear();
        }


        private void InvertTurn(List<IPlayer> players)
        {
            foreach (IPlayer player in players)
            {
                player.ItsTurn = !player.ItsTurn;
            }
        }

        private bool VerifyPokemonsLifePoints(List<IPlayer> players)
        {

            var hasOnePokemonDead = players.FirstOrDefault(x => x?.Pokemon.LifePoints <= 0, null);

            return hasOnePokemonDead == null ? true : false;
        }

    }
}
