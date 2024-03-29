﻿using Microsoft.EntityFrameworkCore;
using ProjectX.Core.Entities;
using ProjectX.Core.Repositories;
using ProjectX.Infrastructure.Data;
using ProjectX.Infrastructure.Repositories.Base;

namespace ProjectX.Infrastructure.Repositories
{
    public class MasterRepository : Repository<Master>, IMasterRepository
    {
        public MasterRepository(DatabaseContext dbContext) : base(dbContext)
        {
        }

        public new async Task<IReadOnlyList<Master>> GetAllAsync()
        {
            return await _dbContext.Masters.ToListAsync();
        }

        public async Task<IReadOnlyList<Master>> GetByNameAsync(string name)
        {
            var masters = await _dbContext.Masters.ToListAsync();
            return  masters.Where(master => master.Name == name).ToList();
        }

    }
}
