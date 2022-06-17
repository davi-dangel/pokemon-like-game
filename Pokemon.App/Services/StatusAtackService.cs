using PokemonGame.App.Entities.Movements;
using PokemonGame.App.Interfaces.Services;

namespace PokemonGame.App.Services
{
    public class StatusAtackService : IStatusAtackService
    {
        private readonly ITypeService _typeService;
        public StatusAtackService(ITypeService typeService)
        {
            _typeService = typeService;
        }
        public IList<StatusAtack> GetAll()
        {

            var types = _typeService.GetAll();

            //TODO: Ver como vai ficar depois da implementação do banco, senão precisa melhorar
            List<StatusAtack> allAtacks = new();
            allAtacks.Add(new StatusAtack("Atack", 10, types.First(x => x.GetType().Name == "NormalType"), "atack"));
            allAtacks.Add(new StatusAtack("Defence", 10, types.First(x => x.GetType().Name == "NormalType"), "defense"));
            allAtacks.Add(new StatusAtack("Both", 10, types.First(x => x.GetType().Name == "NormalType"), "both"));

            return allAtacks;
        }

        public void ShowAtacks(IList<StatusAtack> statusAtacks)
        {
            int i = 0;
            foreach (var atack in statusAtacks)
            {
                Console.WriteLine($"[{i}] - {atack.Name} - {atack.Power} - {atack.StatusTarget}");
                i++;
            }
        }
    }
}
