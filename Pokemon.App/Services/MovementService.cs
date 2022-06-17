using PokemonGame.App.Entities;
using PokemonGame.App.Entities.Movements;
using PokemonGame.App.Interfaces.Entities;
using PokemonGame.App.Interfaces.Services;
using PokemonGame.App.Utils;

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

        public IList<IMovement> ChooseMovements(Pokemon pokemon)
        {
            List<IMovement> moviments = new();
            var atackMoviments = _atackService.GetAll();
            var statusAtackMoviments = _statusAtackService.GetAll();

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Qual tipo de movimento você escolhe?");
                Console.WriteLine("[0] - Ataque aos pontos de vida");
                Console.WriteLine("[1] - Ataque aos status");
                var movimentChoosed = Console.ReadLine()!.ValidateInputTypeInt(2);
                Console.Clear();

                if (movimentChoosed == 0)
                    moviments.Add(ChooseAtack(pokemon, atackMoviments));
                else
                    moviments.Add(ChooseStatusAtack(pokemon, statusAtackMoviments));
            }

            return moviments;
        }

        public IMovement ChooseAtack(Pokemon pokemon, IList<Atack> allAtacks)
        {
            Console.WriteLine("Agora escolha seu Ataque");
            _atackService.ShowAtacks(allAtacks);
            int atackPosition = Console.ReadLine()!.ValidateInputTypeInt(allAtacks.Count() - 1);
            Console.Clear();
            return allAtacks[atackPosition];
        }

        public IMovement ChooseStatusAtack(Pokemon pokemon, IList<StatusAtack> allStatusAtacks)
        {
            Console.WriteLine("Agora escolha seu Ataque contra o Status");
            _statusAtackService.ShowAtacks(allStatusAtacks);
            int atackPosition = Console.ReadLine()!.ValidateInputTypeInt(allStatusAtacks.Count() - 1);
            Console.Clear();
            return allStatusAtacks[atackPosition];
        }
    }
}
