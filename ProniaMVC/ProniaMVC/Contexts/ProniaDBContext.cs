using Microsoft.EntityFrameworkCore;
using ProniaMVC.Models;

namespace ProniaMVC.wwwroot.Contexts;

public class ProniaDBContext:DbContext
{
    public DbSet<Slider>Sliders { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server = .\\JUPITER11;Database=Pronia;Trusted_Connection=True;TrustServerCertificate=True;");
        base.OnConfiguring(optionsBuilder);
    }
}
