using Eurofins.GMA.Application.Configurations.Data;
using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Eurofins.GMA.Application.Implementations;
using Eurofins.GMA.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Eurofins.GMA.Application.Configurations
{
    public static class StartupSetup
    {
        public static void AddDbContext(this IServiceCollection services, string connectionString) =>
             services.AddDbContext<SqlDbContext>(x => x.UseSqlServer(connectionString));

        public static void AddAutoMapper(this IServiceCollection services) =>
            services.AddAutoMapper(Assembly.Load("Eurofins.GMA.Application"));

        public static void SeedDatabase(this IServiceCollection services)
        {
            // Seed Database
            using (var scope = services.BuildServiceProvider().CreateScope())
            {
                var service = scope.ServiceProvider;

                try
                {
                    SQLContextSeed.SeedAssetsAsync(service).Wait();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

    }
}
