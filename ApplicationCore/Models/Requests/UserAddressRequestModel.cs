using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Models.Requests
{
    public class UserAddressRequestModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public int AddressId { get; set; }
        public Address Address { get; set; } = new Address();
        public bool isDefaultAddress { get; set; }
    }
}
