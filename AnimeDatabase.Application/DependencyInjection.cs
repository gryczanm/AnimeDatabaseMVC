using AnimeDatabase.Application.Interfaces;
using AnimeDatabase.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace AnimeDatabase.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddTransient<IAnimeService, AnimeService>();
            services.AddTransient<IAnimeTypeService, AnimeTypeService>();

            return services;
        }
    }
}
