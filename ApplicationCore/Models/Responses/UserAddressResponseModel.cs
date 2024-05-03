using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Responses
{
    public class UserAddressResponseModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public int AddressId { get; set; }
        public Address Address { get; set; } = new Address();
        public bool isDefaultAddress { get; set; }
    }
}
