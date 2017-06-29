using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KingslandRedux.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace KingslandRedux.Data
{
    public class KingslandContext : DbContext
    {
        public KingslandContext() : base("KingslandContext")
        {
        }

        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Bread> Breads { get; set; }
        public DbSet<Condiment> Condiments { get; set; }
        public DbSet<Dairy> Dairys { get; set; }
        public DbSet<Meat> Meats { get; set; }
        public DbSet<Produce> Produces { get; set; }
        public DbSet<ToGo> ToGos { get; set; }
        public DbSet<Sandwich> Sandwiches { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}