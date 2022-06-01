using Eurofins.GMA.Domain.Entities;

namespace Eurofins.GMA.Domain.Interfaces
{
    public interface IAssetManager
    {
        Task<IEnumerable<Asset>> GetAssetsAsync();
        Task CreateAssetAsync(Asset asset);
        Task UpdateAssetAsync(Asset asset);
        Task DeleteAssetAsync(int id);
    }
}
