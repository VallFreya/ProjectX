﻿using ProjectX.Application.Interfaces;
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

        public async Task<Master> GetByIdAsync(int id)
        {
            return await masterRepository.GetByIdAsync(id);
        }

        public async Task<Master> GetByNameAsync(string name)
        {
            return (await masterRepository.GetByNameAsync(name)).FirstOrDefault();
        }
    }
}
