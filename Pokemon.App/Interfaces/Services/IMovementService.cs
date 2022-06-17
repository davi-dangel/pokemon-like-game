using PokemonGame.App.Entities;
using PokemonGame.App.Entities.Movements;
using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Interfaces.Services
{
    public interface IMovementService
    {
        IList<IMovement> ChooseMovements(Pokemon pokemon);
        IMovement ChooseAtack (Pokemon pokemon, IList<Atack> allAtacks);
        IMovement ChooseStatusAtack (Pokemon pokemon, IList<StatusAtack> allAtacks);
    }
}
