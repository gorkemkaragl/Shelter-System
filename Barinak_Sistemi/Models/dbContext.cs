using Barinak_Sistemi.Models;
using Microsoft.EntityFrameworkCore;




namespace Barinak_Sistemi.Models
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions<dbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseSerialColumns();
        } 
        public DbSet<User> User { get; set; }
        public DbSet<Animal> Animals { get; set; }
        public DbSet<DropAnimal> DAnimal { get; set; }
        public DbSet<ShelterUsers> SUser { get; set; }
    }
}