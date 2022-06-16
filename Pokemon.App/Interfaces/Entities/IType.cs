namespace PokemonGame.App.Interfaces.Entities
{
    public interface IType
    {
        public Dictionary<string, IType> TypesRelation { get; }
    }
}
