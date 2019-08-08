using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.GraphQL.Types
{
    public class PotionTypeEnumType : EnumerationGraphType<Data.PotionType>
    {
        public PotionTypeEnumType()
        {
            Name = "Type";
            Description = "The type of potion";
        }
    }
}
