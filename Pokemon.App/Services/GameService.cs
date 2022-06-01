using PokemonGame.App.Entities;
using PokemonGame.App.Enums;
using PokemonGame.App.ExtensionMethods;
using PokemonGame.App.Interfaces;
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

        public Game CreateGame(List<Pokemon> allPokemons)
        {
            Game game = new Game();
            game.SetGameMode();
            SetPlayers(game.GameMode, allPokemons).ForEach(p => game.SetPlayer(p));

            return game;
        }

        public void StartGame(Game game)
        {
            while (VerifyPokemonsLifePoints(game.Players))
            {
                DoMoviment(game.Players);
                ShowAllLifePoints(game.Players);
            }
            //TODO: Declarar o fim da batalha
            Console.WriteLine("Fim da batalha");
        }

        private List<Player> SetPlayers(string gameMode, List<Pokemon> allPokemons)
        {
            List<Player> players = new List<Player>();
            if (gameMode == GameModeEnum.SOLO)
            {
                players.Add(_playerService.CreatePlayer(allPokemons, PlayersTypeEnum.HUMAN));
                //TODO: O player computador deve ser criado no mesmo padrão do jogador humano para manter o padrão
                players.Add(new Player("Computer", new Pokemon(allPokemons[new Random().Next(allPokemons.Count)]), PlayersTypeEnum.PC));
            }
            else
            {
                players.Add(_playerService!.CreatePlayer(allPokemons, PlayersTypeEnum.HUMAN));
                players.Add(_playerService!.CreatePlayer(allPokemons, PlayersTypeEnum.HUMAN));
            }

            return players;

        }

        private void ShowAllLifePoints(List<Player> players)
        {
            foreach (Player player in players)
            {
                _pokemonService.ShowLifePoints(player.Pokemon);
            }
        }

        private void DoMoviment(List<Player> players)
        {
            if (players.First(x => x.Type.Equals(PlayersTypeEnum.HUMAN)).ItsTurn == true)
            {
                Console.WriteLine("Qual o seu movimento?");
                Console.WriteLine("[0] - Atacar");
                int movimentChosed = Console.ReadLine()!.ValidateInputTypeInt(0);
                players.First(x => x.ItsTurn == false).Pokemon.DecreaseLifePoints(players.First(x => x.ItsTurn == true).Pokemon.AtackPower);
            }
            else
            {
                //TODO: Criar um modulo para quando for a vez do computador jogar
                //Fazer o modulo depois que definir como serão os movimentos
            }
            InvertTurn(players);
            Console.Clear();
        }


        private void InvertTurn(List<Player> players)
        {
            foreach (Player player in players)
            {
                player.ItsTurn = !player.ItsTurn;
            }
        }

        private bool VerifyPokemonsLifePoints(List<Player> players)
        {

            var hasOnePokemonDead = players.FirstOrDefault(x => x?.Pokemon.LifePoints <= 0, null);

            return hasOnePokemonDead == null ? true : false;
        }

    }
}
