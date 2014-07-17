using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CEC.Models;

namespace CEC.DAL
{
    public class CustomerInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            var customers = new List<Customer>
            {
                new Customer{ ID = 001, Name = "Galactic Empire", Location = "Death Star"},
                new Customer{ ID = 002, Name = "Republic", Location = "Corruscant" },
                new Customer{ ID = 003, Name = "Rebel Alliance", Location = "Hoth" },
                new Customer{ ID = 004, Name = "Serv-O-Droid", Location = "Corruscant" },
                new Customer{ ID = 005, Name = "Cybot Galactica", Location = "Etti IV" },
                new Customer{ ID = 006, Name = "Industrial Automation", Location = "Nubia" },
                new Customer{ ID = 007, Name = "Solo All Legal Exports", Location = "Yavin IV" },
                new Customer{ ID = 008, Name = "Organa Political Influence", Location = "Alderaan" },
                new Customer{ ID = 009, Name = "Jabba's Palace", Location = "Tattooine" },
                new Customer{ ID = 010, Name = "Mos Eisley Cantina Band", Location = "Tattooine" }
            };
            customers.ForEach(s => context.Customers.Add(s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order{ OrderID = 164545, OrderDate = DateTime.Parse("12/11/1005") },
                new Order{ OrderID = 156655, OrderDate = DateTime.Parse("11/14/1004") },
                new Order{ OrderID = 145784, OrderDate = DateTime.Parse("10/22/1006") },
                new Order{ OrderID = 145624, OrderDate = DateTime.Parse("7/04/1002") }
            };
            orders.ForEach(s => context.Orders.Add(s));
            context.SaveChanges();

            var orderDetails = new List<OrderDetail>
            {
                new OrderDetail{ OrderDetailID = 145621, CustomerID = 001, Quantity = 12 },
                new OrderDetail{ OrderDetailID = 144566, CustomerID = 002, Quantity = 14 },
                new OrderDetail{ OrderDetailID = 154784, CustomerID = 003, Quantity = 22 },
                new OrderDetail{ OrderDetailID = 146544, CustomerID = 004, Quantity = 3 },
                new OrderDetail{ OrderDetailID = 184645, CustomerID = 005, Quantity = 37 }
            };
            orderDetails.ForEach(s => context.OrderDetails.Add(s));
            context.SaveChanges();
        }
    }
}