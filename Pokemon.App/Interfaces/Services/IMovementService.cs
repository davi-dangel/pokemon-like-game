using PokemonGame.App.Entities;
using PokemonGame.App.Entities.Movements;
using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Interfaces.Services
{
    public interface IMovementService
    {
        IMovement ChooseMovements(Pokemon pokemon, int movimentChoosed);
        IMovement ChooseAtack (IList<Atack> allAtacks, int atackPosition);
        IMovement ChooseStatusAtack (IList<StatusAtack> allStatusAtacks, int statusAtackPosition);
    }
}
