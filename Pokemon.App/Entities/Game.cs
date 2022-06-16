using PokemonGame.App.Utils;
using PokemonGame.App.Enums;
using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App
{
    public class Game
    {
        public string GameMode { get; private set; }
        public List<IPlayer> Players { get; private set; }

        public Game() 
        {
            Players = new List<IPlayer>();
        }

        public void SetGameMode()
        {
            Console.WriteLine("Selecione o modo de jogo");
            Console.WriteLine("[0] - 1 Jogador");
            Console.WriteLine("[1] - 2 Jogadores");

            int gameMode = Console.ReadLine()!.ValidateInputTypeInt(1);
            GameMode = gameMode == 0 ? GameModeEnum.SOLO : GameModeEnum.DOIS_JOGADORES;
            Console.Clear();
        }

        public void SetPlayer(IPlayer player)
        {
            player.ItsTurn = Players.Count == 0 ? true : false;
            Players.Add(player);
        }

    }
}
