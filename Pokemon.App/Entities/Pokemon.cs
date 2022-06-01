using PokemonGame.App.Interfaces;

namespace PokemonGame.App.Entities
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int LifePoints { get; set; }
        public int AtackPower { get; set; }
        public int DefensePower { get; set; }

        public IList<IMovement> Movements  { get; set; }

        public Pokemon(string name, int lifePoints, int atackPower, int defensePower)
        {
            Name = name;
            LifePoints = lifePoints;
            AtackPower = atackPower;
            DefensePower = defensePower;
            Movements = new List<IMovement>();
        }
        public Pokemon(Pokemon pokemon)
        {
            Name = pokemon.Name;
            LifePoints = pokemon.LifePoints;
            AtackPower = pokemon.AtackPower;
            DefensePower = pokemon.DefensePower;
            Movements = pokemon.Movements;
        }

    }
}
