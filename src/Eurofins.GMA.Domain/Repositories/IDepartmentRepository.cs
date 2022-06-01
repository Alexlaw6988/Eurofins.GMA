using Eurofins.GMA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eurofins.GMA.Domain.Repositories
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Task<Department> GetDepartmentByIdAsync (short id);
        Task<Department> AddDepartmentAsync (string departmentName);
        Task DeleteDepartmentByIdAsync(short id);
    }
}
