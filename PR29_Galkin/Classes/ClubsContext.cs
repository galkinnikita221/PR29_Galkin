using Microsoft.EntityFrameworkCore;
using PR29_Galkin.Classes.Common;
using PR29_Galkin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PR29_Galkin.Classes
{
    public class ClubsContext : DbContext
    {
        public DbSet<Clubs> Clubs { get; set; }
        public ClubsContext() => Database.EnsureCreated();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseMySql(Config.ConnectionConfig, Config.Version);
    }
}
