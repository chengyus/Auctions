using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Auctions.Data
{
  public class AppDbContext : DbContext
  {
    protected readonly IConfiguration Configuration;

    public AppDbContext(IConfiguration configuration)
    {
      Configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      options.UseNpgsql(Configuration.GetConnectionString("DefaultConnection"));
    }
  }
}
