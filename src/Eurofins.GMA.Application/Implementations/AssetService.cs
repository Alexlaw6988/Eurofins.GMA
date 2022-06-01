
using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Eurofins.GMA.Domain.Entities;
using Eurofins.GMA.Domain.Interfaces;

namespace Eurofins.GMA.Application.Implementations
{
    public class AssetService : IAssetService
    {
        private readonly IAssetManager _assetManager;
        private readonly IMapper _mapper;
        private readonly IGuidService _guidService;

        public AssetService(IAssetManager assetManager, IMapper mapper, IGuidService guidService)
        {
            _assetManager = assetManager;
            _mapper = mapper;
            _guidService = guidService;
        }

        public async Task<IEnumerable<AssetDto>> GetAssetsAsync()
        {
            var assets = (await _assetManager.GetAssetsAsync()).OrderByDescending(x => x.Id);
            return assets.Take(100).Select(a => _mapper.Map<AssetDto>(a));
        }

        public async Task CreateAssetAsync(AssetDto assetDto)
        {
            assetDto.AssetId =  _guidService.GetNewGuidAsync().GetAwaiter().GetResult().ToString();
            await _assetManager.CreateAssetAsync(_mapper.Map<Asset>(assetDto));
        }

        public async Task UpdateAssetAsync(AssetDto assetDto)
        {
            await _assetManager.UpdateAssetAsync(_mapper.Map<Asset>(assetDto));
        }

        public async Task DeleteAssetAsync(int id)
        {
            await _assetManager.DeleteAssetAsync(id);
        }

    }

}
