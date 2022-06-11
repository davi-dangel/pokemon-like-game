namespace PokemonGame.App.Interfaces.Services
{
    public interface IGameService
    {
        Game CreateGame();
        void StartGame(Game game);
    }
}
