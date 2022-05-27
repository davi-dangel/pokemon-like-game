using PokemonGame.App;
using PokemonGame.App.Entities;
using PokemonGame.App.Enums;

Game game = new Game();
game.SetGameMode();

List<Pokemon> allPokemons = new List<Pokemon>();
allPokemons.Add(new Pokemon("Charizard", 150, 50));
allPokemons.Add(new Pokemon("Ivysauro", 150, 10));

if (game.GameMode == GameModeEnum.SOLO)
{
    game.SetPlayer(Player.CreatePlayer(allPokemons, PlayersType.HUMAN));
    //TODO: O player computador deve ser criado no mesmo padrão do jogador humano para manter o padrão
    game.SetPlayer(new Player("Computer", new Pokemon(allPokemons[new Random().Next(allPokemons.Count)]), PlayersType.PC));
}
else
{
    game.SetPlayer(Player.CreatePlayer(allPokemons, PlayersType.HUMAN));
    game.SetPlayer(Player.CreatePlayer(allPokemons, PlayersType.HUMAN));
}

game.StartGame();

