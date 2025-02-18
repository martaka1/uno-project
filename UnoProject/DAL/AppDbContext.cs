using Database;
using Microsoft.EntityFrameworkCore;


namespace DAL;

// dotnet ef migrations add --project DAL --startup-project ConsoleApp InitialCreate
public class AppDbContext : DbContext
{
    public DbSet<Game> Games { get; set; } = default!;
    public DbSet<Player> Players { get; set; } = default!;
    
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }
}