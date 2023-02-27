using ProjectX.Core.Entities;

namespace ProjectX.Application.Interfaces
{
    public interface IMasterService
    {
        Task<IEnumerable<Master>> GetAllAsync();
    }
}
