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
        if(!this.Companies.Any())
        {
            this.Companies.Add(new Company()
            { Address = "Jaworznia", Email = "Jaworznia@jwn.pl", KrsNumber = "123321312", Name = "Jawokorp", Id = 10, NipNumber = "12312312", PhoneNumber = "1231231", RegonNumber = "123123213", RepresentativeFirstname = "Adam", RepresentativeSurname = "Salamanderski" });
            this.SaveChanges();
        }

        if (!this.Internships.Any())
        {
            this.Internships.Add(new Internship()
            { Id = 10, StudentEmail = "s022222@student.tu.kielce.pl", ManagerEmail = "p.fraczek@tu.kiece.pl", DateOfEnd = DateTime.Now.AddDays(5), DateOfStart = DateTime.Now.AddDays(4), IntershipCreator = Companies.FirstOrDefault(), RecrutationEnd = DateTime.Now.AddDays(3), RecrutationStart = DateTime.Now.AddDays(1) });
            this.SaveChanges();
        }
    }
}

