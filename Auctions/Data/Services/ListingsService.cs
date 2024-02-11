using Auctions.Models;
using Microsoft.EntityFrameworkCore;

namespace Auctions.Data.Services
{
  public class ListingsService : IListingsService
  {
    private readonly ApplicationDbContext _context;

    public ListingsService(ApplicationDbContext context)
    {
      _context = context;
    }

    public IQueryable<Listing> GetAll()
    {
      var applicationDbContext = _context.Listing.Include(l => l.User);
      return applicationDbContext;
    }
  }
}
