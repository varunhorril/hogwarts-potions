using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.Data.Entities
{
    public class Potion : TimeBase
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Name { get; set; }

        public string Type { get; set; }
        public string Description { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset IntroducedAt { get; set; }

        [StringLength(100)]
        public string PotionPhotoFileName { get; set; }

    }
}
