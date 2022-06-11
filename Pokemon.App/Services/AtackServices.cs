using PokemonGame.App.Entities.Movements;
using PokemonGame.App.Interfaces;
using PokemonGame.App.Interfaces.Services;

namespace PokemonGame.App.Services
{
    public class AtackServices : IAtackService
    {
        public IList<Atack> GetAll()
        {
            List<Atack> allAtacks = new();
            allAtacks.Add(new Atack("FireBlast", 10));
            allAtacks.Add(new Atack("WaterGun", 10));
            allAtacks.Add(new Atack("HiperBean", 10));

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
