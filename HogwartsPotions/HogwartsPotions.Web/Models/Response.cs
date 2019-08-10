using HogwartsPotions.Web.Exception;
using System.Collections.Generic;
using System.Linq;

namespace HogwartsPotions.Web.Models
{
    public class Response<T>
    {
        public T Data { get; set; }
        public List<Error> Errors { get; set; }

        public void ThrowErrors()
        {
            if (Errors != null && Errors.Any())
            {
                throw new GraphQLException($"Message: {Errors[0].Message} Code: {Errors[0].Code}");
            }
        }

    }

    public class PotionsRack
    {
        public List<PotionViewModel> Potions { get; set; }
    }
}
