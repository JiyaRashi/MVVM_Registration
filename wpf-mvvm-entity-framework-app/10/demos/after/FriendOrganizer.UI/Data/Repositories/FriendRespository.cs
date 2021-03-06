using FriendOrganizer.DataAccess;
using FriendOrganizer.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace FriendOrganizer.UI.Data.Repositories
{
  public class FriendRespository : IFriendRepository
  {
    private FriendOrganizerDbContext _context;

    public FriendRespository(FriendOrganizerDbContext context)
    {
      _context = context;
    }
    public async Task<Friend> GetByIdAsync(int friendId)
    {
      return await _context.Friends.SingleAsync(f => f.Id == friendId);
    }

    public bool HasChanges()
    {
      return _context.ChangeTracker.HasChanges();
    }

    public async Task SaveAsync()
    {
      await _context.SaveChangesAsync();
    }
  }
}
