using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using GalaxyStoreAPI.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace GalaxyStoreAPI.DAL
{
    public class GalaxyStoreDbContext : DbContext
    {
        public GalaxyStoreDbContext ():base("GalaxyStoreDbContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}