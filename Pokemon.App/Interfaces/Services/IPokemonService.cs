using PokemonGame.App.Entities;

namespace PokemonGame.App.Interfaces.Services
{
    public interface IPokemonService
    {

        IList<Pokemon> GetAll();
        void ShowLifePoints(Pokemon pokemon);
        void ShowPokemons(IList<Pokemon> pokemons);
    }
}
