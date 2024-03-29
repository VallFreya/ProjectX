﻿using AutoMapper;
using ProjectX.Application.Interfaces;
using ProjectX.Web.Interfaces;
using ProjectX.Web.ViewModels;

namespace ProjectX.Web.Services
{
    public class MasterPageService : IMasterPageService
    {
        private readonly IMasterService masterService;
        private readonly IMapper mapper;

        public MasterPageService(IMasterService masterService, IMapper mapper)
        {
            this.masterService = masterService ?? throw new ArgumentNullException(nameof(masterService));
            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        public async Task<IEnumerable<MasterViewModel>> GetAllAsync()
        {
            var masters = await masterService.GetAllAsync();
            var mapped = mapper.Map<IEnumerable<MasterViewModel>>(masters);
            return mapped;
        }

        public async Task<MasterViewModel> GetByIdAsync(int id)
        {
            var master = await masterService.GetByIdAsync(id);
            var mapped = mapper.Map<MasterViewModel>(master);
            return mapped;
        }

        public async Task<MasterViewModel> GetByNameAsync(string name)
        {
            var master = await masterService.GetByNameAsync(name);
            var mapped = mapper.Map<MasterViewModel>(master);
            return mapped;
        }
    }
}
