using Microsoft.Extensions.DependencyInjection;
using PokemonGame.App.Configurations;
using PokemonGame.App.Entities;
using PokemonGame.App.Entities.Types;
using PokemonGame.App.Enums;
using PokemonGame.App.Interfaces.Entities;
using PokemonGame.App.Interfaces.Services;
using PokemonGame.App.Services;
using System.Collections.Generic;
using Xunit;

namespace PokemonGame.Test.Services
{
    public class MovementServiceTest
    {
        private IMovementService ResolveDependencyInjection()
        {
            var service = new ServiceCollection();
            Configure.ConfigureServices(service);
            var provider = service.BuildServiceProvider();
            return provider.GetService<IMovementService>();
        }

        [Fact]
        public void ChooseMovimentsTest()
        {
            IMovementService _movimentService = ResolveDependencyInjection();
            //TODO: CREATE METHOD GET ONE OR GET BY TYPE
            IType type = new FireType
            {
                TypesRelation = new Dictionary<string, IType>
                    {
                        { TypesRelationEnum.MuchStrongerAgainst, new GrassType() },
                        { TypesRelationEnum.Neutral, new FireType() },
                        { TypesRelationEnum.MuchWeakerAgainst, new WaterType() }

                    }
            };
            Pokemon pokemon = new Pokemon("Charizard", 150, type);

            var atackMoviment = _movimentService.ChooseMovements(pokemon, 0);
            var statusAtackMoviment = _movimentService.ChooseMovements(pokemon, 1);

            Assert.Equal("Atack", atackMoviment.GetType().Name);
            Assert.Equal("StatusAtack", statusAtackMoviment.GetType().Name);
        }

    }
}
