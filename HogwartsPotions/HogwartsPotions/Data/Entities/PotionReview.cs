using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.Data.Entities
{
    public class PotionReview
    {
        public int Id { get; set; }
        public int PotionId { get; set; }
        public Potion Potion { get; set; }

        [StringLength(100), Required]
        public string Title { get; set; }
        public string Review { get; set; }
    }
}
