using Eurofins.GMA.Domain.Entities;


namespace Eurofins.GMA.Domain.Interfaces.Managers
{
    public interface ISalaryManager
    {
        Task<Salary> GetSalaryAsync(long id);
        Task CreateSalaryAsync(Salary salary);
        Task UpdateSalaryAsync(Salary salary);
        Task DeleteSalaryAsync(long id);
    }
}
