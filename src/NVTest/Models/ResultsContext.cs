using System;
using Microsoft.Data.Entity;

namespace NVTest.Models
{
    public class ResultsContext : DbContext
    {

        public ResultsContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Result> Results { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connString = Startup.Configuration["Data:ResultsContextConnection"];
            optionsBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
