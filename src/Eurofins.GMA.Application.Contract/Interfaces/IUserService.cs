using Eurofins.GMA.Application.Contracts.Dtos;

namespace Eurofins.GMA.Application.Contracts.Interfaces
{
    public interface IUserService
    {
        Task<IEnumerable<UserDto>> GetAllUsersAsync();
        Task<UserDto> GetUserAsync(int id);
        Task CreateUserAsync(UserDto user);
        Task UpdateUserAsync(UserDto user);
        Task DeleteUserAsync(int id);
    }
}
