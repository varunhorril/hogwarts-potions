using HogwartsPotions.Data;
using HogwartsPotions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.Repositories
{
    public class PotionRepository
    {
        private readonly PotionDbContext _dbContext;

        public PotionRepository(PotionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Potion> Get(int id)
        {
            return await _dbContext.Potions.SingleAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Potion>> GetAll()
        {
            return await _dbContext.Potions.ToListAsync();
        }
    }
}
