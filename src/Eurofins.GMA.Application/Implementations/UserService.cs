using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Eurofins.GMA.Domain.Interfaces.Managers;

namespace Eurofins.GMA.Application.Implementations
{
    public class UserService : IUserService
    {
        private readonly IUserManager _manager;
        private readonly IMapper _mapper;
        private readonly IGuidService _guidService;

        public UserService(IUserManager manager, IMapper mapper, IGuidService guidService)
        {
            _manager = manager;
            _mapper = mapper;
            _guidService = guidService;
        }
        public async Task CreateUserAsync(UserDto user)
        {
            await _manager.CreateUserAsync(_mapper.Map<Eurofins.GMA.Domain.Entities.User>(user));
        }

        public async Task DeleteUserAsync(int id)
        {
            await _manager.DeleteUserAsync(id);
        }

        public async Task<IEnumerable<UserDto>> GetAllUsersAsync()
        {
            var assets = (await _manager.GetAllUsersAsync()).OrderByDescending(x => x.Id);
            return assets.Select(a => _mapper.Map<UserDto>(a));
        }

        public async Task<UserDto> GetUserAsync(int id)
        {
            return  _mapper.Map<UserDto>(await _manager.GetUserAsync(id));
        }

        public async Task UpdateUserAsync(UserDto user)
        {
            await _manager.UpdateUserAsync(_mapper.Map<Eurofins.GMA.Domain.Entities.User>(user));
        }
    }
}
