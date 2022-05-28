using Microsoft.Extensions.DependencyInjection;
using PokemonGame.App;
using PokemonGame.App.Configurations;
using PokemonGame.App.Entities;
using PokemonGame.App.Interfaces;

var serviceCollection = new ServiceCollection();
Configure.ConfigureServices(serviceCollection);
var serviceProvider = serviceCollection.BuildServiceProvider();
var gameService = serviceProvider.GetService<IGameService>();

List<Pokemon> allPokemons = new List<Pokemon>();
allPokemons.Add(new Pokemon("Charizard", 150, 50));
allPokemons.Add(new Pokemon("Ivysauro", 150, 10));

Game game = gameService!.CreateGame(allPokemons);
gameService.StartGame(game);