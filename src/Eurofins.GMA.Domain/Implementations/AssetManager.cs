using Eurofins.GMA.Domain.Entities;
using Eurofins.GMA.Domain.Interfaces;
using Eurofins.GMA.Domain.Repositories;

namespace Eurofins.GMA.Domain.Implementations
{
    public  class AssetManager : IAssetManager
    {
        private readonly IRepository<Asset> _assetRepository;

        public AssetManager(IRepository<Asset> assetRepository)
        {
            _assetRepository = assetRepository;
        }

        public async Task<IEnumerable<Asset>> GetAssetsAsync()
        {
            return await _assetRepository.GetAllAsync();
        }

        public async Task CreateAssetAsync(Asset asset)
        {
            await _assetRepository.AddAsync(asset);
        }

        public async Task UpdateAssetAsync(Asset asset)
        {
            await _assetRepository.UpdateAsync(asset);
        }

        public async Task DeleteAssetAsync(int id)
        {
            await _assetRepository.DeleteAsync(await _assetRepository.GetAsync(x=> x.Id == id));
        }
       
    }
}
