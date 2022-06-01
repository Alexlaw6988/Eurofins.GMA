using Eurofins.GMA.Domain.Entities;
using Eurofins.GMA.Domain.Interfaces.Managers;
using Eurofins.GMA.Domain.Repositories;


namespace Eurofins.GMA.Domain.Implementations
{
    public class DepartmentManager : IDepartmentManager
    {
        private readonly IDepartmentRepository _departmentRepository;

        public DepartmentManager(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task CreateDepartmentAsync(Department department)
        {
            await _departmentRepository.AddAsync(department);
        }

        public async Task DeleteDepartmentAsync(short id)
        {
            await _departmentRepository.DeleteDepartmentByIdAsync(id);
        }

        public async Task<IEnumerable<Department>> GetAllDepartmentsAsync()
        {
            return await _departmentRepository.GetAllAsync();
        }

        public async Task<Department> GetDepartmentAsync(short id)
        {
            return await _departmentRepository.GetDepartmentByIdAsync(id);
        }

        public async Task UpdateDepartmentAsync(Department department)
        {
             await _departmentRepository.UpdateAsync(department);
        }
    }
}
