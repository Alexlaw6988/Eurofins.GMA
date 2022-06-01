using Eurofins.GMA.Application.Contracts.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eurofins.GMA.Application.Contracts.Interfaces
{
    public interface IDepartmentService
    {
        Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync();
        Task<DepartmentDto> GetDepartmentAsync(short id);
        Task CreateDepartmentAsync(DepartmentDto department);
        Task UpdateDepartmentAsync(DepartmentDto department);
        Task DeleteDepartmentAsync(short id);
    }
}
