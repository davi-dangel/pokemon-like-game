using PokemonGame.App.Enums;
using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Entities.Movements
{
    public class Atack : IMovement
    {
        public string Name { get ; set; }
        public int Power { get; set; }
        public IType Type { get; set; }
        public string Description { get; set; }

        public void DoMoviment(Dictionary<string, Pokemon> pokemons)
        {
            var defensePower = pokemons[PokemonStatusEnum.DISABLED].DefensePower;
            var totalAtackPower = ((pokemons[PokemonStatusEnum.ACTIVE].AtackPower * this.Power) - defensePower) / 10;
            Console.WriteLine("AtackTotal: " + SetTypeMultiplier(pokemons[PokemonStatusEnum.DISABLED], totalAtackPower));
            pokemons[PokemonStatusEnum.DISABLED].LifePoints = pokemons[PokemonStatusEnum.DISABLED].LifePoints - SetTypeMultiplier(pokemons[PokemonStatusEnum.DISABLED], totalAtackPower);
        }

        private int SetTypeMultiplier(Pokemon pokemon, int totalAtackPower)
        {
            //TODO: MELHORAR A VALIDAÇÃO, SE NAO DA MATCH ELE QUEBRA
            var multiplier = Type.TypesRelation.FirstOrDefault(x => x.Value.GetType().Name.Equals(pokemon.Type.GetType().Name)).Key;
            
            return Convert.ToInt32(Math.Ceiling(multiplier switch
            {
                "MUCH_STRONGER" => totalAtackPower * 2.0,
                "STRONGER" => totalAtackPower * 1.5,
                "WEAKER" => totalAtackPower / 1.5,
                "MUCH_WEAKER" => totalAtackPower / 2.0,
                _ => totalAtackPower
            }));
        }

        public Atack(string name, int power, IType type)
        {
            Name = name;
            Power = power;
            Type = type;
        }
    }
}
