using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Entities.Types
{
    public class FireType : IType
    {
        public Dictionary<string, IType> TypesRelation { get; set; }
    }
}
