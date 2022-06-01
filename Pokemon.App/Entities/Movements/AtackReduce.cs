using PokemonGame.App.Interfaces;

namespace PokemonGame.App.Entities.Movements
{
    public class AtackReduce : IMovement
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        float IMovement.DoMoviment(float power) => Power * power;
        
    }
}
