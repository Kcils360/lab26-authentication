﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lab26Identity.Models
{
    public class CMS
    {
        public int ID { get; set; }

        public string Dish { get; set; }

        public string Category { get; set; }

        public string Ingredients { get; set; }

        public string Recipe { get; set; }

        public bool IsPublished { get; set; }

    }
}
