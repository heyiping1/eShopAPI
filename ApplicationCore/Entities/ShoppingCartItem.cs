using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Entities
{
    public class ShoppingCartItem
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public string ProductName { get; set; } = string.Empty;
        public int Qty { get; set; }
        public int Price { get; set; }
    }
}
