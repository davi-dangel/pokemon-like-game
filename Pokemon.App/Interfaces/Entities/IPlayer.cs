using PokemonGame.App.Entities;

namespace PokemonGame.App.Interfaces.Entities
{
    public interface IPlayer
    {
        public string Name { get; set; }
        public bool ItsTurn { get; set; }
        public Pokemon Pokemon { get; set; }
    }
}
