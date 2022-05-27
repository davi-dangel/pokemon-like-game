using PokemonGame.App.Entities;
using PokemonGame.App.Utils;
using PokemonGame.App.Enums;

namespace PokemonGame.App
{
    public class Game
    {
        public string GameMode { get; private set; }
        public List<Player> Players { get; private set; }

        public Game() 
        { 
            Players = new List<Player>();
        }

        public void StartGame()
        {
            while (VerifyPokemonsLifePoints())
            {
                DoMoviment();
                ShowAllLifePoints();
            }
            //TODO: Declarar o fim da batalha
            Console.WriteLine("Fim da batalha");
        }

        public void SetGameMode()
        {
            Console.WriteLine("Selecione o modo de jogo");
            Console.WriteLine("[0] - 1 Jogador");
            Console.WriteLine("[1] - 2 Jogadores");

            int gameMode = InputValidation.ValidateInputTypeInt(1);
            GameMode = gameMode == 0 ? GameModeEnum.SOLO : GameModeEnum.DOIS_JOGADORES;
            Console.Clear();
        }

        public void SetPlayer(Player player)
        {
            player.ItsTurn = Players.Count == 0 ? true : false;
            Players.Add(player);
        }

        private void DoMoviment()
        {
            if(Players.First(x => x.Type.Equals(PlayersType.HUMAN)).ItsTurn == true)
            {
                Console.WriteLine("Qual o seu movimento?");
                Console.WriteLine("[0] - Atacar");
                int movimentChosed = InputValidation.ValidateInputTypeInt(0);
                Players.First(x => x.ItsTurn == false).Pokemon.DecreaseLifePoints(Players.First(x => x.ItsTurn == true).Pokemon.Atack);
            }
            InvertTurn();
            Console.Clear();
        }

        private void ShowAllLifePoints()
        {
            foreach(Player player in Players)
            {
                player.Pokemon.ShowLifePoints();
            }
        }

        private void InvertTurn()
        {
            foreach(Player player in Players)
            {
                player.ItsTurn = !player.ItsTurn;
            }
        }

        private bool VerifyPokemonsLifePoints()
        {
            var hasOnePokemonDead = Players.FirstOrDefault(x => x.Pokemon.LifePoints <= 0, null);

            return hasOnePokemonDead == null ? true : false;
        }
    }
}
