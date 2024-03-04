using API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StartspelerContext : IdentityDbContext<Gebruiker>
    {
        public StartspelerContext(DbContextOptions<StartspelerContext> options) : base(options) { }

        public DbSet<Drank> Dranken { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Drank>().ToTable("Drank");
        }

    }
}
