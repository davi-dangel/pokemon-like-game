using Microsoft.Extensions.DependencyInjection;
using PokemonGame.App.Interfaces.Services;
using PokemonGame.App.Services;

namespace PokemonGame.App.Configurations
{
    public static class Configure
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IPokemonService, PokemonService>();
            services.AddScoped<IGameService, GameService>();
            services.AddScoped<IAtackService, AtackServices>();
            services.AddScoped<ITypeService, TypeService>();
        }
    }
}
