using e_Vstopnice.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace e_Vstopnice.Data;

public class UserContext : IdentityDbContext<ApplicationUser>
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }
        public DbSet<Event> Events { get; set; }
        public DbSet<Place> Place { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Event>().ToTable("Events");
        modelBuilder.Entity<Ticket>().ToTable("Tickets");
        modelBuilder.Entity<Place>().ToTable("Places");
    }
}
