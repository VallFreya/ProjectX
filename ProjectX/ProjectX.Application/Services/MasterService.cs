using ProjectX.Application.Interfaces;
using ProjectX.Core.Entities;
using ProjectX.Core.Repositories;

namespace ProjectX.Application.Services
{
    public class MasterService : IMasterService
    {
        private readonly IMasterRepository masterRepository;

        public MasterService(IMasterRepository masterRepository)
        {
            this.masterRepository = masterRepository;
        }
        public async Task<IEnumerable<Master>> GetAllAsync()
        {
            return await masterRepository.GetAllAsync();
        }
    }
}
