using AnimeDatabase.Domain.Interface;
using AnimeDatabase.Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

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
