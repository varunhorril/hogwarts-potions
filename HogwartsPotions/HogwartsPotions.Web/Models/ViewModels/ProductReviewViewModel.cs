﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HogwartsPotions.Web.Models
{
    public class ProductReviewViewModel
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public string Review { get; set; }
    }
}