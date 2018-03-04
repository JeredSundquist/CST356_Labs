using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;//<---added
using _CST356____Lab4.Data.Entities;//<---added

namespace _CST356____Lab4.Data
{
    public class AppDbContext : DbContext
    {
        //member variables
        public static int id = 0;

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Pet> Pets { get; set; }

        public AppDbContext()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new AppDbInitializer());
        }

        public class AppDbInitializer : DropCreateDatabaseIfModelChanges<AppDbContext>
        {
            //left blank
        }
    }
}