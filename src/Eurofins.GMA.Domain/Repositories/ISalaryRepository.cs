using Eurofins.GMA.Domain.Entities;

namespace Eurofins.GMA.Domain.Repositories
{
    public interface ISalaryRepository : IRepository<Salary>
    {
        Task<Salary> AddUserSalaryAsync(User user, float coefficientsSalary, float workdays);

        Task<Salary> GetSalaryByIdAsync(long id);
        Task DeleteSalaryAsync(long id);
    }
}
