using PokemonGame.App.Entities;

namespace PokemonGame.App.Interfaces.Services
{
    public interface IPlayerService
    {
        Player CreatePlayer(IList<Pokemon> allPokemons, string type);
        Player CreateComputerPlayer(IList<Pokemon> allPokemons);
    }
}
