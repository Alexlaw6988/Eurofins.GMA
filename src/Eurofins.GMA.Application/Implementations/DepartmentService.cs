

using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Eurofins.GMA.Domain.Interfaces.Managers;

namespace Eurofins.GMA.Application.Implementations
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentManager _manager;
        private readonly IMapper _mapper;
        private readonly IGuidService _guidService;

        public DepartmentService(IDepartmentManager manager, IMapper mapper, IGuidService guidService)
        {
            _manager = manager;
            _mapper = mapper;
            _guidService = guidService;
        }
        public async Task CreateDepartmentAsync(DepartmentDto department)
        {
            await _manager.CreateDepartmentAsync(_mapper.Map<Eurofins.GMA.Domain.Entities.Department>(department));
        }

        public async Task DeleteDepartmentAsync(short id)
        {
            await _manager.DeleteDepartmentAsync(id);
        }

        public async Task<IEnumerable<DepartmentDto>> GetAllDepartmentsAsync()
        {
            var assets = (await _manager.GetAllDepartmentsAsync()).OrderByDescending(x => x.Id);
            return assets.Take(100).Select(a => _mapper.Map<DepartmentDto>(a));
        }

        public async Task<DepartmentDto> GetDepartmentAsync(short id)
        {
            return _mapper.Map<DepartmentDto>(await _manager.GetDepartmentAsync(id));
        }

        public async Task UpdateDepartmentAsync(DepartmentDto department)
        {
            await _manager.UpdateDepartmentAsync(_mapper.Map<Eurofins.GMA.Domain.Entities.Department>(department));
        }
    }
}
