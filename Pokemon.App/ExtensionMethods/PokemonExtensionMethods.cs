using PokemonGame.App.Entities;

namespace PokemonGame.App.ExtensionMethods
{
    public static class PokemonExtensionMethods
    {

        public static void DecreaseLifePoints(this Pokemon pokemon, int atackPoints)
        {
             pokemon.LifePoints-= atackPoints;
        }
    }
}
