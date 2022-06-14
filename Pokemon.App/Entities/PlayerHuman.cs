using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Entities
{
    public class PlayerHuman : IPlayer
    {
        public string Name { get; set; }
        public bool ItsTurn { get; set; }
        public Pokemon Pokemon { get; set; }

        public PlayerHuman(string name, Pokemon pokemon)
        {
            Name = name;
            Pokemon = pokemon;
        }
    }
}
