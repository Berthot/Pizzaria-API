using System;
using System.Collections.Generic;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Pizzaria.Domain.Entities
{
    public class PizzaFlavor
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        
        public int FlavorId { get; set; }
        
        public DateTime CreateAt { get; set; }
        
        public virtual Flavor Flavor { get; set; }
        
        public virtual Order Order { get; set; }
        
        public IEnumerable<Order> Orders { get; set; }
    }
}