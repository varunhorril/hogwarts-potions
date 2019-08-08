using GraphQL.Types;
using HogwartsPotions.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.GraphQL.Types
{
    public class PotionType : ObjectGraphType<Potion>
    {
        public PotionType()
        {
            Field(t => t.Id);
            Field(t => t.Name).Description("The name of the potion");
            Field(t => t.Description).Description("The description of the potion");
            Field(t => t.Price).Description("Price of potion");
            Field(t => t.Stock).Description("Available number of potions in stock");
            Field(t => t.IntroducedAt).Description("Who invented the potion? ;)");
            Field(t => t.Rating).Description("Wizards rating of the potion");
            Field(t => t.Type).Description("The type of potion");

            Field(t => t.CreatedOn);

        }
    }
}
