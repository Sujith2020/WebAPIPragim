namespace DairyDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class swarnadbv2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Orders", "DeliveryTypes", c => c.String());
            DropColumn("dbo.Orders", "DeliveryType");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Orders", "DeliveryType", c => c.String());
            DropColumn("dbo.Orders", "DeliveryTypes");
        }
    }
}
