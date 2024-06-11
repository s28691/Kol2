using Kolokwium2.Data;
using Kolokwium2.Models;
using Microsoft.EntityFrameworkCore;

namespace Kolokwium2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;
    public DbService(DatabaseContext context)
    {
        _context = context;
    }
    public async Task<ICollection<Character>> GetCharacterData(int characterId)
    {
        return await _context.Characters
            .Where(e => e.Id == characterId)
            .ToListAsync();
    }

    public async Task<bool> DoesItemExist(int idItem)
    {
        return await _context.Items.AnyAsync(e => e.Id == idItem);
    }
}