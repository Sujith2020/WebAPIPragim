namespace DairyDataAccess.Migrations
{
    using DairyDataAccess.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DairyDataAccess.SwarnaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(DairyDataAccess.SwarnaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            IList<User> Users = new List<User>();

            Users.Add(new User() { Username = "User 1", Password = "First Password", EmpId = 1001});
            Users.Add(new User() { Username = "User 2", Password = "Second Password", EmpId = 1002 });
            Users.Add(new User() { Username = "User 3", Password = "Third Password", EmpId = 1003 });
            //context.Users.AddRange(Users);
           

            base.Seed(context);
        }
    }
}
