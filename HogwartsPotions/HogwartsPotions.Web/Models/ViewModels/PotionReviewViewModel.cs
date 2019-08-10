using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.Web.Models
{
    public class PotionReviewViewModel
    {
        public int PotionId { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
    }
}
