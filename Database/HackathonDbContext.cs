namespace HackathonApi.Database;


using HackathonApi.Entities;
using Microsoft.EntityFrameworkCore;

public class HackathonDbContext : DbContext
{
    public DbSet<Internship> Internships { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<NewDateTicket> NewDateTickets { get; set; }


    public HackathonDbContext(DbContextOptions options) : base(options)
    {
    }
}

