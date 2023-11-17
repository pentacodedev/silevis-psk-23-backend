using HackathonApi.Entities;
using Microsoft.EntityFrameworkCore;

public class HackathonDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Intership> Interships { get; set; }
    public DbSet<Company> Compamies { get; set; }
    public DbSet<Student> Students { get; set; }

    public HackathonDbContext(DbContextOptions options) : base(options)
    {
    }
}

