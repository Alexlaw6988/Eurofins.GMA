using Eurofins.GMA.Domain.Entities;

namespace Eurofins.GMA.Domain.Interfaces.Managers
{
    public interface IUserManager
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User> GetUserAsync(int id);
        Task CreateUserAsync(User user);
        Task UpdateUserAsync(User user);
        Task DeleteUserAsync(int id);
    }
}
