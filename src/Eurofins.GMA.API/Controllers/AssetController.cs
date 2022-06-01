using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;

namespace Eurofins.GMA.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AssetsController : ControllerBase
    {
        private readonly IAssetService _assetService;
        private readonly IMemoryCache _memoryCache;
        private const string _cacheKey = "assetList";

        public AssetsController(IAssetService assetService, IMemoryCache memoryCache)
        {
            _assetService = assetService;
            _memoryCache = memoryCache;
        }

        [HttpGet]
        public async Task<IEnumerable<AssetDto>> Get()
        {
            
            if (_memoryCache.TryGetValue(_cacheKey, out IEnumerable<AssetDto> assetList)) 
            {return assetList;}

            return await RefreshCacheAsync(); 
        }

        [HttpPost]
        public async Task Post(AssetDto model)
        {
            await _assetService.CreateAssetAsync(model);
            await RefreshCacheAsync();

        }

        [HttpPut]
        public async Task Put(AssetDto model)
        {
            await _assetService.UpdateAssetAsync(model);
            await RefreshCacheAsync();
        }

        [HttpDelete("{id:int}")]
        public async Task Delete(int id)
        {
            await _assetService.DeleteAssetAsync(id);
            await RefreshCacheAsync();
        }

        private async Task<IEnumerable<AssetDto>> RefreshCacheAsync()
        {

            var assetList = await _assetService.GetAssetsAsync();

            //setting up cache options
            var cacheExpiryOptions = new MemoryCacheEntryOptions
            {
                AbsoluteExpiration = DateTime.Now.AddSeconds(180),
                Priority = CacheItemPriority.High,
                SlidingExpiration = TimeSpan.FromSeconds(60)
            };
            //setting cache entries

            return _memoryCache.Set(_cacheKey, assetList, cacheExpiryOptions);
        }
    }
}
