using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.GraphQL.Types
{
    public class PotionReviewType : ObjectGraphType<Data.Entities.PotionReview>
    {
        public PotionReviewType()
        {
            Field(t => t.Id);
            Field(t => t.Title);
            Field(t => t.Review);

        }
    }
}
