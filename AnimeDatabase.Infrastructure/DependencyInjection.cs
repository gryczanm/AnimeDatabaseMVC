using AnimeDatabase.Domain.Interface;
using AnimeDatabase.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
namespace AnimeDatabase.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IAnimeRepository, AnimeRepository>();

            return services;
        }
    }
}