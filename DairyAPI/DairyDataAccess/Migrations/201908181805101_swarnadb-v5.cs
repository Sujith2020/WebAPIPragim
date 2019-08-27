namespace DairyDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class swarnadbv5 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Address", "Address2", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Address", "Address2");
        }
    }
}
