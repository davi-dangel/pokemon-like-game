using PokemonGame.App.Entities;
using PokemonGame.App.Entities.Movements;
using PokemonGame.App.Interfaces.Entities;
using PokemonGame.App.Interfaces.Services;
using PokemonGame.App.View.Services;

namespace PokemonGame.App.Services
{
    public class MovementService : IMovementService
    {
        private readonly IAtackService _atackService;
        private readonly IStatusAtackService _statusAtackService;

        public MovementService(IAtackService atackService, IStatusAtackService statusAtackService)
        {
            _atackService = atackService;
            _statusAtackService = statusAtackService;
        }

        public IMovement ChooseMovements(Pokemon pokemon, int movimentChoosed)
        {
            if (movimentChoosed == 0)
            {
                var atackMoviments = _atackService.GetAll();
                return ChooseAtack(atackMoviments, MovimentServiceView.ChooseAtackView(atackMoviments, _atackService));
            }
            else
            {
                var statusAtackMoviments = _statusAtackService.GetAll();
                return ChooseStatusAtack(statusAtackMoviments, MovimentServiceView.ChooseStatusAtack(statusAtackMoviments, _statusAtackService));
            }
        }

        public IMovement ChooseAtack(IList<Atack> allAtacks, int atackPosition)
        {
            return allAtacks[atackPosition];
        }

        public IMovement ChooseStatusAtack(IList<StatusAtack> allStatusAtacks, int statusAtackPosition)
        {
            return allStatusAtacks[statusAtackPosition];
        }
    }
}
