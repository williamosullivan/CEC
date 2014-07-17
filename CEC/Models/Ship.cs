using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CEC.Models
{
    public class Ship
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}