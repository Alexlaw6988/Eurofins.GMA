using Eurofins.GMA.Domain.Entities;

namespace Eurofins.GMA.Domain.Interfaces.Managers
{
    public interface IDepartmentManager
    {
        Task<IEnumerable<Department>> GetAllDepartmentsAsync();
        Task<Department> GetDepartmentAsync(short id);
        Task CreateDepartmentAsync(Department department);
        Task UpdateDepartmentAsync(Department department);
        Task DeleteDepartmentAsync(short id);
    }
}
