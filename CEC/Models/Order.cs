using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CEC.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace CEC.Models
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }

        public virtual ICollection<OrderDetail> Detail { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
