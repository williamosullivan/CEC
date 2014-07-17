using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CEC.Models;

namespace CEC.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}