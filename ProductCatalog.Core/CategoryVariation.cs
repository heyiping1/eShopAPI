﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class CategoryVariation
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; } = new ProductCategory();
        public string VariationName { get; set; } = string.Empty;
        public List<VariationValue> VariationValues { get; set; } = new List<VariationValue>();
    }
}
