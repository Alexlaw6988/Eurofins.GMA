using AutoMapper;
using Eurofins.GMA.Application.Contracts.Dtos;
using Eurofins.GMA.Application.Contracts.Interfaces;
using Eurofins.GMA.Domain.Interfaces.Managers;

namespace Eurofins.GMA.Application.Implementations
{
    public class SalaryService : ISalaryService
    {
        private readonly ISalaryManager _manager;
        private readonly IMapper _mapper;
        private readonly IGuidService _guidService;

        public SalaryService(ISalaryManager manager, IMapper mapper, IGuidService guidService)
        {
            _manager = manager;
            _mapper = mapper;
            _guidService = guidService;
        }
        public async Task CreateSalaryAsync(SalaryDto salary)
        {
            await _manager.CreateSalaryAsync(_mapper.Map<Eurofins.GMA.Domain.Entities.Salary>(salary));
        }

        public async Task DeleteSalaryAsync(long id)
        {
            await _manager.DeleteSalaryAsync(id);
        }

        public async Task<SalaryDto> GetSalaryAsync(long id)
        {
            return _mapper.Map<SalaryDto>(await _manager.GetSalaryAsync(id));
        }

        public async Task UpdateSalaryAsync(SalaryDto salary)
        {
            await _manager.UpdateSalaryAsync(_mapper.Map<Eurofins.GMA.Domain.Entities.Salary>(salary));
        }
    }
}
