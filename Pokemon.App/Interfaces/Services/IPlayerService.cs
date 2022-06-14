using PokemonGame.App.Entities;
using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Interfaces.Services
{
    public interface IPlayerService
    {
        IPlayer CreatePlayer(IList<Pokemon> allPokemons);
        IPlayer CreateComputerPlayer(IList<Pokemon> allPokemons);
    }
}
