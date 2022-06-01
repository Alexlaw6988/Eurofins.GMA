using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurofins.GMA.Application.Contracts.Interfaces
{
    public interface IGuidService
    {
        Task<Guid> GetNewGuidAsync();
    }
}
