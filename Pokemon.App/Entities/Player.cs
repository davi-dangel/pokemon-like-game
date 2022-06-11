namespace PokemonGame.App.Entities
{
    public class Player
    {
        public string Name { get; set; }
        public bool ItsTurn { get; set; }
        public string Type { get; set; }
        public Pokemon Pokemon { get; set; }

        public Player(string name, Pokemon pokemon, string type)
        {
            Name = name;
            Pokemon = pokemon;
            Type = type;
        }
    }
}
