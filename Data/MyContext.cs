using e_Vstopnice.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Vstopnice.Data;

public class MyContext : DbContext
{
    public MyContext(DbContextOptions<MyContext> options) : base(options)
    {
    }

    public DbSet<Event> Events { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Place> Place { get; set; }
    public DbSet<Ticket> Tickets { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Event>().ToTable("Events");
        modelBuilder.Entity<User>().ToTable("Users");
        modelBuilder.Entity<Ticket>().ToTable("Tickets");
        modelBuilder.Entity<Place>().ToTable("Places");
    }
}