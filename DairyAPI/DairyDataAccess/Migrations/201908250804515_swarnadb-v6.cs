namespace DairyDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class swarnadbv6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Address", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Dealers", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Orders", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
            AddColumn("dbo.Products", "RowVersion", c => c.Binary(nullable: false, fixedLength: true, timestamp: true, storeType: "rowversion"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "RowVersion");
            DropColumn("dbo.Orders", "RowVersion");
            DropColumn("dbo.Dealers", "RowVersion");
            DropColumn("dbo.Address", "RowVersion");
        }
    }
}

