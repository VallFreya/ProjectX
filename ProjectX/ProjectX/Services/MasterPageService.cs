using AutoMapper;
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
    }
}
