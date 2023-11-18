namespace HackathonApi.Database;


using HackathonApi.Entities;
using Microsoft.EntityFrameworkCore;

public class HackathonDbContext : DbContext
{
    public DbSet<Internship> Internships { get; set; }
   // public DbSet<Company> Companies { get; set; }
    public DbSet<NewDateTicket> NewDateTickets { get; set; }


    public HackathonDbContext(DbContextOptions options) : base(options)
    {
        if (!this.Internships.Any())
        {
            this.Internships.Add(new Internship()
            {  StudentEmail = "s022222@student.tu.kielce.pl", ManagerEmail = "p.fraczek@tu.kiece.pl", DateOfEnd = DateTime.Now.AddDays(5), DateOfStart = DateTime.Now.AddDays(4), CompanyAddress = "Kielce 20", CompanyEmail = "ork@jwn.pl", CompanyKrsNumber = "4542312312312", CompanyName = "Zaklad Bagienny SA", CompanyNipNumber = "124124124", CompanyPhoneNumber = "553252352", CompanyRegonNumber = "232332", CompanyRepresentativeFirstname = "Adam", CompanyRepresentativeSurname = "Salamanderski"});
            this.SaveChanges();
        }
    }



}

