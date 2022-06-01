using PokemonGame.App.Enums;

namespace PokemonGame.App.Interfaces
{
    public interface IMovement
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }

        float DoMoviment(float power);
    }
}
