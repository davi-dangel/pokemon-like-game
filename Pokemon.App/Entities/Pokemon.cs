namespace PokemonGame.App.Entities
{
    public class Pokemon
    {
        public string Name { get; set; }
        public int LifePoints { get; set; }
        public int Atack { get; set; }

        public Pokemon(string name, int lifePoints, int atack)
        {
            Name = name;
            LifePoints = lifePoints;
            Atack = atack;
        }
        public Pokemon(Pokemon pokemon)
        {
            Name = pokemon.Name;
            LifePoints = pokemon.LifePoints;
            Atack = pokemon.Atack;
        }

    }
}
