using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Entities.Movements
{
    public class Atack : IMovement
    {
        public string Name { get ; set; }
        public int Power { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public void DoMoviment(Dictionary<string, Pokemon> pokemons)
        {
            var defensePower = pokemons["unactive"].DefensePower;
            var totalAtackPower = ((pokemons["active"].AtackPower * this.Power) - defensePower) / 10;
           
            pokemons["unactive"].LifePoints = pokemons["unactive"].LifePoints - totalAtackPower;
        }

        public Atack(string name, int power)
        {
            Name = name;
            Power = power;
        }
    }
}
