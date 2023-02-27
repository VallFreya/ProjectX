using AutoMapper;
using ProjectX.Core.Entities;
using ProjectX.Web.ViewModels;

namespace ProjectX.Web.Mapper
{
    public class ProjectXProfile : Profile
    {
        public ProjectXProfile()
        {
            CreateMap<Master, MasterViewModel>().ReverseMap();
        }
    }
}
