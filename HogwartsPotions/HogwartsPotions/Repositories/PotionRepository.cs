using HogwartsPotions.Data;
using HogwartsPotions.Data.Entities;
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

        public IEnumerable<Potion> GetAll()
        {
            return _dbContext.Potions;
        }
    }
}
