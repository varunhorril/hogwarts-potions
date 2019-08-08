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
            Field(t => t.Name);
            Field(t => t.Description);
        }
    }
}
