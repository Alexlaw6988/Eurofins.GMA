
using Eurofins.GMA.Domain.Entities;
using Eurofins.GMA.Domain.Repositories;
using Eurofins.GMA.Infrastructure.DbContext;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eurofins.GMA.Infrastructure.Data.Repositories
{
    public class SalaryRepository : Repository<Salary>, ISalaryRepository
    {
        public SalaryRepository(SqlDbContext dbContext) : base(dbContext)
        {
        }

        public async Task<Salary> AddUserSalaryAsync(User user, float coefficientsSalary, float workdays)
        {
            var salary = new Salary(user, coefficientsSalary, workdays);
            if (salary.ValidOnAdd())
            {
                await this.AddAsync(salary);
                return salary;
            }
            else
                throw new Exception("Salary invalid");
        }

        public async Task DeleteSalaryAsync(long id)
        {
            await this.DeleteAsync(await this.GetSalaryByIdAsync(id));
        }

        public async Task<Salary> GetSalaryByIdAsync(long id)
        {
            return await this.GetAsync(x=> x.Id == id);
        }
    }
}
