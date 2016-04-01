using System;
using Microsoft.Data.Entity;

namespace NVTest.Models
{
    public class TestContext : DbContext
    {

        public TestContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Question> Questions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            var connString = Startup.Configuration["Data:TestContextConnection"];
            optionsBuilder.UseSqlServer(connString);

            base.OnConfiguring(optionsBuilder);
        }
    }
}
