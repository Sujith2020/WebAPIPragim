namespace DairyDataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class swarnadbv4 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Address", "Address2");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Address", "Address2", c => c.String());
        }
    }
}
