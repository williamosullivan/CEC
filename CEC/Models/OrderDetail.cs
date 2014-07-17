using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CEC.Models;

namespace CEC.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public int CustomerID { get; set; }
        public int ShipID { get; set; }
        public int Quantity { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}