using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Entities.Types
{
    public class GrassType : IType
    {
        public Dictionary<string, IType> TypesRelation { get; set; }
    }
}
