using PokemonGame.App.Entities.Movements;

namespace PokemonGame.App.Interfaces.Services
{
    public interface IAtackService
    {
        IList<Atack> GetAll();
        void ShowAtacks(IList<Atack> atacks);
    }
}
