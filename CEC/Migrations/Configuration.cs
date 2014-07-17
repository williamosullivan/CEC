namespace CEC.Migrations
{
    using CEC.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CEC.DAL.CompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CEC.DAL.CompanyContext context)
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
            customers.ForEach(s => context.Customers.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order{ OrderID = 164545, OrderDate = DateTime.Parse("12/11/2005"), CustomerID = 001 },
                new Order{ OrderID = 156655, OrderDate = DateTime.Parse("11/14/2004"), CustomerID = 002 },
                new Order{ OrderID = 145784, OrderDate = DateTime.Parse("10/22/2006"), CustomerID = 003 },
                new Order{ OrderID = 145624, OrderDate = DateTime.Parse("7/04/2002"), CustomerID = 004 }
            };
            orders.ForEach(s => context.Orders.AddOrUpdate(p => p.OrderID, s));
            context.SaveChanges();

            var orderDetails = new List<OrderDetail>
            {
                new OrderDetail{ OrderDetailID = 145621, CustomerID = 001, ShipID = 427, Quantity = 12 },
                new OrderDetail{ OrderDetailID = 144566, CustomerID = 002, ShipID = 452, Quantity = 14 },
                new OrderDetail{ OrderDetailID = 154784, CustomerID = 003, ShipID = 485, Quantity = 22 },
                new OrderDetail{ OrderDetailID = 146544, CustomerID = 004, ShipID = 452, Quantity = 3 },
                new OrderDetail{ OrderDetailID = 184645, CustomerID = 005, ShipID = 427, Quantity = 37 }
            };
            orderDetails.ForEach(s => context.OrderDetails.AddOrUpdate(p => p.OrderDetailID, s));
            context.SaveChanges();

            var ships = new List<Ship>
            {
                new Ship{ ID = 427, Name = "Wanderer", Price = 13000.00 },
                new Ship{ ID = 452, Name = "Radiant IX", Price = 270000.00 },
                new Ship{ ID = 485, Name = "Lakota", Price = 175000.00 }
            };
            ships.ForEach(s => context.Ships.AddOrUpdate(p => p.ID, s));
            context.SaveChanges();
        }
    }
}
