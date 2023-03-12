using ProjectX.Core.Entities;

namespace ProjectX.Application.Interfaces
{
    public interface IMasterService
    {
        Task<IEnumerable<Master>> GetAllAsync();

        Task<Master> GetByIdAsync(int id);

        Task<Master> GetByNameAsync(string name);
    }
}
