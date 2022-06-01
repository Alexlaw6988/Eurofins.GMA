using Eurofins.GMA.Application.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurofins.GMA.Application.Implementations
{
    public class GuidService : IGuidService
    {
        public async Task<Guid> GetNewGuidAsync()
        { 
            return await Task.FromResult(Guid.NewGuid());
        }
    }
}
