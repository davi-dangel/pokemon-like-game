using PokemonGame.App.Enums;
using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Entities.Movements
{
    public class StatusAtack : IMovement
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public IType Type { get; set; }
        public string Description { get; set; }
        public string StatusTarget { get; set; }

        public void DoMoviment(Dictionary<string, Pokemon> pokemons)
        {
            var percentOfDamage = Power / 100.0;
            if (StatusTarget == "atack")
            {
                var atackPower = pokemons[PokemonStatusEnum.DISABLED].AtackPower;
                var statusAtackPower = atackPower * percentOfDamage;

                pokemons[PokemonStatusEnum.DISABLED].SetAtackPower(Convert.ToInt32(Math.Ceiling(atackPower - statusAtackPower)));
            }
            else if (StatusTarget == "defense")
            {
                var defensePower = pokemons[PokemonStatusEnum.DISABLED].DefensePower;
                var statusDefensePower = defensePower * percentOfDamage;

                pokemons[PokemonStatusEnum.DISABLED].SetDefensePower(Convert.ToInt32(Math.Ceiling(defensePower - statusDefensePower)));
            }
            else if(StatusTarget == "both")
            {
                //TODO: SEE A BETTER WAY TODO BOTH
                var atackPower = pokemons[PokemonStatusEnum.DISABLED].AtackPower;
                var statusAtackPower = atackPower * percentOfDamage;

                var defensePower = pokemons[PokemonStatusEnum.DISABLED].DefensePower;
                var statusDefensePower = defensePower * percentOfDamage;

                pokemons[PokemonStatusEnum.DISABLED].SetAtackPower(Convert.ToInt32(Math.Ceiling(atackPower - statusAtackPower)));
                pokemons[PokemonStatusEnum.DISABLED].SetDefensePower(Convert.ToInt32(Math.Ceiling(defensePower - statusDefensePower)));
            }
        }

        public StatusAtack(string name, int power, IType type, string statusTarget)
        {
            Name = name;
            Power = power;
            Type = type;
            StatusTarget = statusTarget;
        }
    }
}
