using HogwartsPotions.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.Data
{
    public static class DataSeeder
    {
        public static void Seed(this PotionDbContext dbContext)
        {
            if (dbContext.Potions.Any())
            {

                dbContext.Potions.Add(new Potion
                {


                });

            }
        }
    }
}
