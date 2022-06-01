using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Eurofins.GMA.Application.Mappers;
using Eurofins.GMA.Domain.Entities;
using Eurofins.GMA.Infrastructure.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Eurofins.GMA.Application.Configurations.Data
{
    public class SQLContextSeed
    {
        public static async Task SeedAssetsAsync(IServiceProvider services)
        {
            var context = services.GetService<SqlDbContext>();
            var assets = context!.Set<Asset>();
            var any = await assets.AnyAsync();
            var mapper = services.GetService<IMapper>();

            if (!any)
            {
                const string csvFile = "Resources/AssetImport.csv";
                var csvService = services.GetService<ICsvService<AssetDto>>();
                var assetModels = csvService!.ReadCsvFile(csvFile, new AssetCsvMap()).Select(x => mapper!.Map<Asset>(x));
                await assets.AddRangeAsync(assetModels);
            }

            await context.SaveChangesAsync();
        }
    }
}
