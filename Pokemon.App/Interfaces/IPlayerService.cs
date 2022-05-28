using PokemonGame.App.Entities;

namespace PokemonGame.App.Interfaces
{
    public interface IPlayerService
    {
        Player CreatePlayer(List<Pokemon> allPokemons, string type);
    }
}
