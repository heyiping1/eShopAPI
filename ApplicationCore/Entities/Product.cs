﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; } = new ProductCategory();
        public decimal Price { get; set; }
        public int Qty { get; set ;}
        public string ProductImage { get; set; } = string.Empty;
        public string SKU { get; set; } = string.Empty;
        public List<ProductVariationValue> ProductVariationValues { get; set; } = new List<ProductVariationValue>();
    }
}
