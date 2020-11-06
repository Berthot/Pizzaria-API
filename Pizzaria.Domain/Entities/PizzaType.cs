using System;
using System.Collections.Generic;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Pizzaria.Domain.Entities
{
    public class PizzaType
    {

        public int Id { get; set; }

        public string Name { get; set; }
        
        public int QtyPrice { get; set; }
        
        public int QtyFlavors { get; set; }
        
        public DateTime UpdateAt { get; set; }
        
        public IEnumerable<Order> Orders { get; set; }
    }
}