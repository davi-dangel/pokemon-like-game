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
        public IList<IMovement> Movements  { get; private set; }

        public Pokemon(string name, int lifePoints, int atackPower, int defensePower)
        {
            Name = name;
            LifePoints = lifePoints;
            AtackPower = atackPower;
            DefensePower = defensePower;
            Movements = new List<IMovement>();
        }

        public Pokemon(string name, int lifePoints)
        {
            Name = name;
            LifePoints = lifePoints;
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

        public void SetAtackPower(int atackPoints)
        {
            AtackPower = atackPoints;
        }

        public void SetDefensePower()
        {
            DefensePower = PointsToDestrubuit - AtackPower;
        }

        public void AddMoviment(IMovement movement)
        {
            Movements.Add(movement);
        }
    }
}
