using PokemonGame.App.Entities;

namespace PokemonGame.App.Interfaces.Entities
{
    public interface IMovement
    {
        public string Name { get; set; }
        public int Power { get; set; }
        public IType Type { get; set; }
        public string Description { get; set; }

        void DoMoviment(Dictionary<string, Pokemon> pokemons);
    }
}
