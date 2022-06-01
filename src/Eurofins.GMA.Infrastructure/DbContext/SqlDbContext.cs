using Eurofins.GMA.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Eurofins.GMA.Infrastructure.DbContext
{
    public class SqlDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public SqlDbContext(DbContextOptions<SqlDbContext> options) : base(options)
        {
            base.Database.EnsureCreated();
        }

        public DbSet<Asset> Assets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Salary> Salaries { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

    }
}
