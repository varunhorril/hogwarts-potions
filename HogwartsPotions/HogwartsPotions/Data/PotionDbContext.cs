using HogwartsPotions.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.Data
{
    public class PotionDbContext : DbContext
    {
        public PotionDbContext(DbContextOptions<PotionDbContext> options) : base(options)
        {

        }



        public DbSet<Potion> Potions { get; set; }
    }
}
