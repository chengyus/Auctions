using Auctions.Models;
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

    public DbSet<Listing> Listings { get; set; }
    public DbSet<Bid> Bids { get; set; }
    public DbSet<Comment> Comments { get; set; }
  }
}
