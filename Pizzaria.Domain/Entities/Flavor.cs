using System;
using System.Collections.Generic;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Pizzaria.Domain.Entities
{
    public class Flavor
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }
        
        public float Price { get; set; }
        
        public bool? Available { get; set; }
        
        public DateTime CreateAt { get; set; }
        
        public DateTime UpdateAt { get; set; }
        
        public IEnumerable<PizzaFlavor> PizzaFlavors { get; set; }
    }
}