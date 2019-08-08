using GraphQL.Types;
using HogwartsPotions.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.GraphQL.Types
{
    public class PotionQuery : ObjectGraphType
    {
        public PotionQuery(PotionRepository potionRepository)
        {
            Field<ListGraphType<PotionType>>(
                "potions",
                resolve: context => potionRepository.GetAll()

                );

            Field<PotionType>(
                "potion",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                { Name = "id" }),
                resolve: context =>
                   {
                       var id = context.GetArgument<int>("id");
                       return potionRepository.Get(id);
                   }
               );
        }
    }
}
