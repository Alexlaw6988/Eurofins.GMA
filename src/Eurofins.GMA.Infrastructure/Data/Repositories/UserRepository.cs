using Eurofins.GMA.Domain.Entities;
using Eurofins.GMA.Domain.Repositories;
using Eurofins.GMA.Infrastructure.DbContext;

namespace Eurofins.GMA.Infrastructure.Data.Repositories
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(SqlDbContext dbContext):base (dbContext)
        {
        }

        public async Task DeleteUserAsync(int id)
        {
            await this.DeleteAsync(await this.GetUserByIdAsync(id));
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await this.GetAsync(x => x.Id == id);
        }

        public async Task<User> NewUserAsync(string userName, string email, Department department)
        {
            var user = new User(userName, email, department);
            if (user.ValidOnAdd())
            {
                await this.AddAsync(user);
                return user;
            }
            else
                throw new Exception("User invalid");
        }
    }
}
