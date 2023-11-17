namespace HackathonApi.Database;


using HackathonApi.Entities;
using Microsoft.EntityFrameworkCore;

public class HackathonDbContext : DbContext
{
    public DbSet<Intership> Interships { get; set; }
    public DbSet<Company> Companies { get; set; }

    public HackathonDbContext(DbContextOptions options) : base(options)
    {
    }
}

