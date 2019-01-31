using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace TravelAgency.Models.TravelAgency
{
    public class VacationDb : DbContext
    {
        public VacationDb() : base("TravelAgency")
        {

        }

        public DbSet<Vacation> Vacations { get; set; }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}