using Eurofins.GMA.Domain.Entities;

namespace Eurofins.GMA.Domain.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<User> NewUserAsync(string userName
            , string email
            , Department department);
        Task<User> GetUserByIdAsync(int id);
        Task DeleteUserAsync(int id);
    }
}
