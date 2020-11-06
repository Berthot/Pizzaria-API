using System;
using System.Collections.Generic;
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace Pizzaria.Domain.Entities
{
    public class Order
    {
        public int Id { get; set; }

        public string Nf { get; set; }
        
        public float Price { get; set; }
        
        public int ClientId { get; set; }
        
        public int PizzaFlavorId { get; set; }
        
        public int PizzaTypeId { get; set; }
        
        public DateTime CreateAt { get; set; }
        
        public virtual Client Client { get; set; }
        
        public virtual PizzaFlavor PizzaFlavor { get; set; }
        
        public virtual PizzaType PizzaType { get; set; }

        public IEnumerable<PizzaFlavor> PizzaFlavors { get; set; }
        

    }
}