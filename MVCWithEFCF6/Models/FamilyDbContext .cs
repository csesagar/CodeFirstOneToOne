using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCWithEFCF6.Models
{
    public class FamilyDbContext : DbContext
    {

        public FamilyDbContext() : base("ConStr")
        {
            Database.SetInitializer(new DropCreateDatabaseAlways<FamilyDbContext>());
        }
        public DbSet<Player> Players { get; set; }
        public DbSet<Spouse> Spouses { get; set; }
    }
}