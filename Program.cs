
using HackathonApi.Database;
using HackathonApi.Services;
using Microsoft.EntityFrameworkCore;
using QuestPDF.Infrastructure;

namespace HackathonApi;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddCors(options => options.AddPolicy("AllowPolicy", policy => policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));



        builder.Services.AddControllers();

        QuestPDF.Settings.License = LicenseType.Community;
        builder.Services.AddScoped<PDFservice>();
        builder.Services.AddScoped<UsosService>();
        builder.Services.AddDbContext<HackathonDbContext>(options => options.UseSqlite("Data Source=HackathonDatabase.db"));

        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseCors("AllowPolicy");
       
        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
