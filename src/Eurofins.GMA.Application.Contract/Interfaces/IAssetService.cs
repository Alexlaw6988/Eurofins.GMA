using Eurofins.GMA.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurofins.GMA.Application.Contracts.Interfaces
{
    public interface IAssetService
    {
        Task<IEnumerable<AssetDto>> GetAssetsAsync();
        Task CreateAssetAsync(AssetDto assetModel);
        Task UpdateAssetAsync(AssetDto assetModel);
        Task DeleteAssetAsync(int id);
    }
}
