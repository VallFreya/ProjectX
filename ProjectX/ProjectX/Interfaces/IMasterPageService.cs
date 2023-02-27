using ProjectX.Web.ViewModels;

namespace ProjectX.Web.Interfaces
{
    public interface IMasterPageService
    {
        Task<IEnumerable<MasterViewModel>> GetAllAsync();
    }
}
