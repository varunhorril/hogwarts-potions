using GraphQL;
using GraphQL.Types;
using HogwartsPotions.GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.GraphQL
{
    public class PotionsSchema : Schema
    {
        public PotionsSchema(IDependencyResolver resolver) : base(resolver)
        {
            Query = resolver.Resolve<PotionQuery>();
        }
    }
}
