using Eurofins.GMA.Application.Contracts.Dtos;

namespace Eurofins.GMA.Application.Contracts.Interfaces
{
    public interface ISalaryService
    {
        Task<SalaryDto> GetSalaryAsync(long id);
        Task CreateSalaryAsync(SalaryDto salary);
        Task UpdateSalaryAsync(SalaryDto salary);
        Task DeleteSalaryAsync(long id);
    }
}
