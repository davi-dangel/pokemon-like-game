using PokemonGame.App.Entities.Movements;

namespace PokemonGame.App.Interfaces.Services
{
    public interface IStatusAtackService
    {
        IList<StatusAtack> GetAll();
        void ShowAtacks(IList<StatusAtack> statusAtacks);
    }
}
