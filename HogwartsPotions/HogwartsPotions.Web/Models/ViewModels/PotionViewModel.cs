using HogwartsPotions.Web.Models.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.Web.Models
{
    public class PotionViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PotionTypeEnum Type { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset IntroducedAt { get; set; }
        public string PhotoFileName { get; set; }
        public List<PotionReview> Reviews { get; set; }

    }
}
