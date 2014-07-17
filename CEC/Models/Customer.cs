using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CEC.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime PurchaseDate { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}