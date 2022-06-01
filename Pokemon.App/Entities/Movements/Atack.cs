using PokemonGame.App.Interfaces;

namespace PokemonGame.App.Entities.Movements
{
    public class Atack : IMovement
    {
        public string Name { get ; set; }
        public int Power { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        public float DoMoviment(float power) => Power * power;
        
    }
}
