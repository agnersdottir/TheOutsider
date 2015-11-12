using ObliviousDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObliviousDAL.Context
{
   public class OutsiderContext : DbContext
    {
        public OutsiderContext() : base("TheOutsidersShopDB")
        {
            Database.SetInitializer(new OutsiderContextInitializer());

            //Add this line to make json conversin happy.
            Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasMany(g => g.Categories).WithMany();

            // List all one-to-many and many-to-many here ?
            modelBuilder.Entity<Product>().hasOne(g => g.Brands).WithMany();
        }
        //OnModelCreating States exactly which lists the tables are connected as many-to-many through

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
