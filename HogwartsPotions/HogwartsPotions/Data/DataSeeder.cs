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

            try
            {
                if (dbContext.Potions.Any())
                {

                    dbContext.Potions.Add(new Potion
                    {
                        Name = "Polyjuice Potion",
                        Description = "The Polyjuice Potion allows the drinker to assume the appearance of someone else for an hour or more depending on the quantity.",
                        Price = 10.0m,
                        Rating = 5,
                        Stock = 10,
                        PotionPhotoFileName = "",
                        CreatedOn = DateTime.Now
                    });

                    dbContext.Potions.Add(new Potion
                    {
                        Name = "Skele-Gro",
                        Description = "Skele-Gro is a medicinal potion that can regrow missing or removed bones, though it tastes terrible and the process is very slow and extremely painful.",
                        Price = 30.0m,
                        Rating = 3,
                        Stock = 25,
                        PotionPhotoFileName = "",
                        CreatedOn = DateTime.Now
                    });

                    dbContext.Potions.Add(new Potion
                    {
                        Name = "Veritaserum",
                        Description = "Veritaserum is a very powerful truth potion.",
                        Price = 50.0m,
                        Rating = 5,
                        Stock = 5,
                        PotionPhotoFileName = "",
                        CreatedOn = DateTime.Now
                    });

                    dbContext.Potions.Add(new Potion
                    {
                        Name = "Felix Felicis",
                        Description = "Felix Felicis, more commonly known as Liquid Luck, grants whoever drinks it unusually good luck.",
                        Price = 100.0m,
                        Rating = 3,
                        Stock = 17,
                        PotionPhotoFileName = "",
                        CreatedOn = DateTime.Now
                    });

                    dbContext.Potions.Add(new Potion
                    {
                        Name = "Amortentia",
                        Description = "Amortentia is a love potion that does not create actual love, but gives the drinker a powerful obsession and infatuation with the giver of the potion.",
                        Price = 200.0m,
                        Rating = 2,
                        Stock = 5,
                        PotionPhotoFileName = "",
                        CreatedOn = DateTime.Now
                    });

                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
