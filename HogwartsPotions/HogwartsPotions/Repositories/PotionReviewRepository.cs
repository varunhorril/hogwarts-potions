using HogwartsPotions.Data;
using HogwartsPotions.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.Repositories
{
    public class PotionReviewRepository
    {
        private readonly PotionDbContext _dbContext;

        public PotionReviewRepository(PotionDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<PotionReview> GetForProduct(int id)
        {
            return _dbContext.PotionReviews.Where(p => p.Id == id);
        }

    }
}
