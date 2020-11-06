using System;
using System.Collections.Generic;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Pizzaria.Domain.Entities
{
    public class Client
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }
        
        public string AddressNumber { get; set; }
        
        public bool IsApartment { get; set; }
        
        public int ApartmentFloor { get; set; }

        public DateTime CreateAt { get; set; }
        
        public DateTime UpdateAt { get; set; }
        public IEnumerable<Order> Orders { get; set; }
    }
}