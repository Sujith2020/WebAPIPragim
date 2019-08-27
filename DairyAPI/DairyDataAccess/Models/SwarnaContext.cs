using DairyDataAccess.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DairyDataAccess
{
    public class SwarnaContext:DbContext
    {
        public SwarnaContext() : base("name=SwarnaContext")
        //public SwarnaContext() : base("SwarnaDB")
        {
            //To Disable initializer - Means from dropping database
            //Database.SetInitializer<SwarnaContext>(null);
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SwarnaContext, DairyDataAccess.Migrations.Configuration>());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Dealer> Dealers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
