using GenericRepository.Contexts;
using GenericRepository.Entities;
using GenericRepository.Repositories.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Repositories.Concretes;

public class TRepository<T>(GenRepoDbContext _context) : ITRepository<T> where T : Student, new()
{
    public IQueryable<T> GetAllT(bool isTracking, params string[] includes)
    {
        var query=_context.Set<T>().AsQueryable();
        if (!isTracking)
        { 
        query=query.AsNoTracking();
        }
        if (includes.Length>0)
        {
            foreach (string include in includes)
            { 
            query=query.Include(include);
            }
        }
        return query;
    }
}
