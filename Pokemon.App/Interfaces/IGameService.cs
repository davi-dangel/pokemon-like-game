using PokemonGame.App.Entities;

namespace PokemonGame.App.Interfaces
{
    public interface IGameService
    {
        Game CreateGame(List<Pokemon> allPokemons);
        void StartGame(Game game);
    }
}
