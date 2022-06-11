using Microsoft.Extensions.DependencyInjection;
using PokemonGame.App;
using PokemonGame.App.Configurations;
using PokemonGame.App.Interfaces.Services;

var serviceCollection = new ServiceCollection();
Configure.ConfigureServices(serviceCollection);
var serviceProvider = serviceCollection.BuildServiceProvider();
var gameService = serviceProvider.GetService<IGameService>();

Game game = gameService!.CreateGame();
gameService.StartGame(game);