using ProjectX.Core.Entities;
using ProjectX.Core.Repositories.Base;

namespace ProjectX.Core.Repositories
{
    public interface IMasterRepository : IRepository<Master>
    {
        new Task<IReadOnlyList<Master>> GetAllAsync();
        new Task<IReadOnlyList<Master>> GetByNameAsync(string name);
    }
}
