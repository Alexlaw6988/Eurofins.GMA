
using Eurofins.GMA.Domain.Entities;
using Eurofins.GMA.Domain.Repositories;
using Eurofins.GMA.Infrastructure.DbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eurofins.GMA.Infrastructure.Data.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(SqlDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Department> AddDepartmentAsync(string departmentName)
        {
            var department = new Department(departmentName);
            if (department.ValidOnAdd())
            {
               await this.AddAsync(department);
                return department;
            }
            else
                throw new Exception("Department invalid");
        }

        public async Task DeleteDepartmentByIdAsync(short id)
        {
             await this.DeleteAsync(await this.GetDepartmentByIdAsync(id));
        }

        public async Task<Department> GetDepartmentByIdAsync(short id)
        {
            return await this.GetAsync(x=>x.Id == id);
        }
    }
}
