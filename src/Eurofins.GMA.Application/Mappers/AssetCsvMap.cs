using CsvHelper.Configuration;
using Eurofins.GMA.Application.Contracts.Dtos;

namespace Eurofins.GMA.Application.Mappers
{
    public sealed class AssetCsvMap : ClassMap<AssetDto>
    {
        public AssetCsvMap()
        {
            Map(m => m.AssetId).Name("asset id");
            Map(m => m.FileName).Name("file_name");
            Map(m => m.MimeType).Name("mime_type");
            Map(m => m.CreatedBy).Name("created_by");
            Map(m => m.Email).Name("email");
            Map(m => m.Country).Name("country");
            Map(m => m.Description).Name("description");
        }
    }
}
