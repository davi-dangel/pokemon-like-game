using PokemonGame.App.Entities.Movements;
using PokemonGame.App.Interfaces.Services;
using PokemonGame.App.Utils;

namespace PokemonGame.App.View.Services
{
    public static class MovimentServiceView
    {
        public static int ChooseMovimentView()
        {
            Console.WriteLine("Qual tipo de movimento você escolhe?");
            Console.WriteLine("[0] - Ataque aos pontos de vida");
            Console.WriteLine("[1] - Ataque aos status");
            var movimentChoosed = Console.ReadLine()!.ValidateInputTypeInt(2);
            Console.Clear();

            return movimentChoosed;            
        }

        public static int ChooseAtackView(IList<Atack> allAtacks, IAtackService atackService)
        {
            Console.WriteLine("Agora escolha seu Ataque");
            atackService.ShowAtacks(allAtacks);
            int atackPosition = Console.ReadLine()!.ValidateInputTypeInt(allAtacks.Count() - 1);
            Console.Clear();
            return atackPosition;
        }

        public static int ChooseStatusAtack(IList<StatusAtack> allStatusAtacks, IStatusAtackService statusAtackService)
        {
            Console.WriteLine("Agora escolha seu Ataque contra o Status");
            statusAtackService.ShowAtacks(allStatusAtacks);
            int atackPosition = Console.ReadLine()!.ValidateInputTypeInt(allStatusAtacks.Count() - 1);
            Console.Clear();
            return atackPosition;
        }
    }
}
