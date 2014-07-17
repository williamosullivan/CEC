namespace CEC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Location = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        OrderDate = c.DateTime(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        Detail_OrderDetailID = c.Int(),
                        Ship_ID = c.Int(),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.OrderDetail", t => t.Detail_OrderDetailID)
                .ForeignKey("dbo.Ship", t => t.Ship_ID)
                .Index(t => t.CustomerID)
                .Index(t => t.Detail_OrderDetailID)
                .Index(t => t.Ship_ID);
            
            CreateTable(
                "dbo.OrderDetail",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        ShipID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderDetailID);
            
            CreateTable(
                "dbo.Ship",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "Ship_ID", "dbo.Ship");
            DropForeignKey("dbo.Order", "Detail_OrderDetailID", "dbo.OrderDetail");
            DropForeignKey("dbo.Order", "CustomerID", "dbo.Customer");
            DropIndex("dbo.Order", new[] { "Ship_ID" });
            DropIndex("dbo.Order", new[] { "Detail_OrderDetailID" });
            DropIndex("dbo.Order", new[] { "CustomerID" });
            DropTable("dbo.Ship");
            DropTable("dbo.OrderDetail");
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
        }
    }
}
