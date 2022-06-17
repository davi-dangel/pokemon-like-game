using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Entities
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int LifePoints { get; set; }
        public int AtackPower { get; private set; }
        public int DefensePower { get; private set; }
        public int PointsToDestrubuit { get; } = 30;
        public IType Type { get; private set; }
        public IList<IMovement> Movements  { get; private set; }

        public Pokemon(string name, int lifePoints, IType type)
        {
            Name = name;
            LifePoints = lifePoints;
            Type = type;
            Movements = new List<IMovement>();
        }

        public Pokemon(Pokemon pokemon)
        {
            Name = pokemon.Name;
            LifePoints = pokemon.LifePoints;
            AtackPower = pokemon.AtackPower;
            DefensePower = pokemon.DefensePower;
            Type = pokemon.Type;
            Movements = pokemon.Movements;
        }

        public void SetAtackPower(int atackPoints)
        {
            AtackPower = atackPoints;
        }

        public void SetDefensePower(int defensePower)
        {
            DefensePower = PointsToDestrubuit - AtackPower;
        }

        public void SetMoviment(IList<IMovement> movements)
        {
            Movements = movements;
        }
    }
}
