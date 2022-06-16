using PokemonGame.App.Interfaces.Entities;

namespace PokemonGame.App.Interfaces.Services
{
    public interface ITypeService
    {
        IList<IType> GetAll();
    }
}
