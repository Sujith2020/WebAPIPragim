namespace DairyDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class swarnadbv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Address",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address2 = c.String(),
                        PostalCode = c.Int(name: "Postal Code", nullable: false),
                        Address1 = c.String(),
                        Village = c.String(),
                        Mandal = c.String(),
                        District = c.String(),
                        State = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Dealers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Contact = c.Int(nullable: false),
                        AlternateContact = c.Int(name: "Alternate Contact", nullable: false),
                        AddressId = c.Int(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Address", t => t.AddressId, cascadeDelete: true)
                .Index(t => t.AddressId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        EmpId = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        dateofbirth = c.DateTime(nullable: false),
                        salary = c.Int(nullable: false),
                        Gender = c.String(),
                    })
                .PrimaryKey(t => t.EmpId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.DateTime(nullable: false),
                        ProductId = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        DealerId = c.Int(nullable: false),
                        PaymentMode = c.String(),
                        DeliveryTypes = c.String(),
                        TotalBill = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DueDate = c.DateTime(nullable: false),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dealers", t => t.DealerId, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.DealerId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Type = c.String(),
                        Fat = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Measure = c.String(),
                        ManufacturedType = c.String(),
                        RowVersion = c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(maxLength: 450),
                        Password = c.String(),
                        EmpId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmpId, cascadeDelete: true)
                .Index(t => t.Username, unique: true)
                .Index(t => t.EmpId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "EmpId", "dbo.Employees");
            DropForeignKey("dbo.Orders", "ProductId", "dbo.Products");
            DropForeignKey("dbo.Orders", "DealerId", "dbo.Dealers");
            DropForeignKey("dbo.Dealers", "AddressId", "dbo.Address");
            DropIndex("dbo.Users", new[] { "EmpId" });
            DropIndex("dbo.Users", new[] { "Username" });
            DropIndex("dbo.Orders", new[] { "DealerId" });
            DropIndex("dbo.Orders", new[] { "ProductId" });
            DropIndex("dbo.Dealers", new[] { "AddressId" });
            DropTable("dbo.Users");
            DropTable("dbo.Products");
            DropTable("dbo.Orders");
            DropTable("dbo.Employees");
            DropTable("dbo.Dealers");
            DropTable("dbo.Address");
        }
    }
}
