using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Entities.Types
{
    public class NormalType : IType
    {
        public Dictionary<string, IType> TypesRelation { get; set; }
    }
}
