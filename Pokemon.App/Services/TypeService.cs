using PokemonGame.App.Entities.Types;
using PokemonGame.App.Enums;
using PokemonGame.App.Interfaces.Entities;
using PokemonGame.App.Interfaces.Services;

namespace PokemonGame.App.Services
{
    public class TypeService : ITypeService
    {
        public IList<IType> GetAll()
        {
            //TODO: Ver como vai ficar depois da implementação do banco, senão precisa melhorar
            //Melhorou muito com o dicionário
            //TODO: Alterar para Listas IList<IType> depois da implementação dos testes unitários
            List<IType> types = new List<IType>
            {
                new FireType
                {
                    TypesRelation = new Dictionary<string, IType>
                    {
                        { TypesRelationEnum.MuchStrongerAgainst, new GrassType() },
                        { TypesRelationEnum.Neutral, new FireType() },
                        { TypesRelationEnum.MuchWeakerAgainst, new WaterType() }
                        
                    }
                },
                new WaterType
                {
                    TypesRelation = new Dictionary<string, IType>
                    {
                        { TypesRelationEnum.MuchStrongerAgainst, new FireType() },
                        { TypesRelationEnum.Neutral, new WaterType() },
                        { TypesRelationEnum.WeakerAgainst, new GrassType() }
                    }
                },
                new GrassType
                {
                    TypesRelation = new Dictionary<string, IType>
                    {
                        { TypesRelationEnum.StrongerAgainst, new WaterType() },
                        { TypesRelationEnum.Neutral, new GrassType() },
                        { TypesRelationEnum.MuchWeakerAgainst, new FireType() }
                    }
                },
                new NormalType
                {
                    TypesRelation = new Dictionary<string, IType>
                    {
                        { TypesRelationEnum.Neutral, new NormalType() }
                    }
                }
            };

            return types;
        }
    }
}
