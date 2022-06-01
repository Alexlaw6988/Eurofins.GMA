using Eurofins.GMA.Domain.Entities;
using Eurofins.GMA.Domain.Interfaces.Managers;
using Eurofins.GMA.Domain.Repositories;

namespace Eurofins.GMA.Domain.Implementations
{
    public class SalaryManager : ISalaryManager
    {
        private readonly ISalaryRepository _salaryRepository;

        public SalaryManager(ISalaryRepository salaryRepository)
        {
            _salaryRepository = salaryRepository;
        }
        public async Task CreateSalaryAsync(Salary salary)
        {
            await _salaryRepository.AddAsync(salary);
        }

        public async Task DeleteSalaryAsync(long id)
        {
            await _salaryRepository.DeleteSalaryAsync(id);
        }

        public async Task<Salary> GetSalaryAsync(long id)
        {
            return await _salaryRepository.GetSalaryByIdAsync(id);
        }

        public async Task UpdateSalaryAsync(Salary salary)
        {
            await _salaryRepository.UpdateAsync(salary);
        }
    }
}
