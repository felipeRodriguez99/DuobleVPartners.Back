using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Repository.Models;

namespace Repository.Context
{
    public class DoubleDbContext : DbContext
    {
        private readonly IConfiguration _config;
        public DbSet<User> Users { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DoubleDbContext(DbContextOptions<DoubleDbContext> options, IConfiguration config) : base(options) {
            _config = config;
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<Person>().ToTable("Person");
        }

    }
}
