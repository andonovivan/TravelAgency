using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TravelAgency.Models.TravelAgency
{
    public class VacationDb : DbContext
    {
        public VacationDb() : base("name=DefaultConnection")
        {

        }

        public DbSet<Vacation> Vacations { get; set; }

        public DbSet<Review> Reviews { get; set; }
    }
}