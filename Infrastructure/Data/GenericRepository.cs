using Core.Interfaces;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class GenericRepository<T> : IGenericRepository<T> where T : Base
{
    private readonly DatabaseContext _context;
    public GenericRepository(DatabaseContext context)
    {
        _context = context;
    }
    
    // Add
    public async Task<T> Add(T Base)
    {
        _context.Set<T>().Add(Base);
        await _context.SaveChangesAsync();
        
        return Base;
    }

    // Delete
    public async Task<T> Delete(int id)
    {
        var entity = await _context.Set<T>().FindAsync(id);

        if (entity is null) return entity;

        _context.Set<T>().Remove(entity);
        await _context.SaveChangesAsync();

        return entity;
    }

    // GetByID
    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    // Get
    public async Task<IReadOnlyList<T>> ListAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    // Update
    public async Task<T> Update(T Base)
    {
        _context.Entry(Base).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return Base;
    }
}
