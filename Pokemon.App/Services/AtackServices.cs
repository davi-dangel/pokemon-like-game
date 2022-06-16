using PokemonGame.App.Entities.Movements;
using PokemonGame.App.Interfaces.Services;

namespace PokemonGame.App.Services
{
    public class AtackServices : IAtackService
    {
        private readonly ITypeService _typeService;

        public AtackServices(ITypeService typeService)
        {
            _typeService = typeService;
        }

        public IList<Atack> GetAll()
        {

            var types = _typeService.GetAll();

            //TODO: Ver como vai ficar depois da implementação do banco, senão precisa melhorar
            List<Atack> allAtacks = new();
            allAtacks.Add(new Atack("FireBlast", 10, types.First(x => x.GetType().Name == "FireType")));
            allAtacks.Add(new Atack("WaterGun", 10, types.First(x => x.GetType().Name == "GrassType")));
            allAtacks.Add(new Atack("HiperBean", 10, types.First(x => x.GetType().Name == "WaterType")));

            return allAtacks;
        }

        public void ShowAtacks(IList<Atack> atacks)
        {
            int i = 0;
            foreach(var atack in atacks)
            {
                Console.WriteLine($"[{i}] - {atack.Name} - {atack.Power}");
                i++;
            }
        }
    }
}
