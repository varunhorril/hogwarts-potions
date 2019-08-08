using HogwartsPotions.Data;
using HogwartsPotions.Data.Entities;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<PotionReview>> GetForProduct(int productId)
        {
            return await _dbContext.PotionReviews.Where(p => p.Id == productId)
                                                 .ToListAsync();
        }

        public async Task<ILookup<int, PotionReview>> GetForProducts(IEnumerable<int> productIds)
        {
            var reviews = await _dbContext.PotionReviews.Where(pr => productIds.Contains(pr.PotionId))
                                                        .ToListAsync();

            return reviews.ToLookup(r => r.PotionId);
        }

    }
}
