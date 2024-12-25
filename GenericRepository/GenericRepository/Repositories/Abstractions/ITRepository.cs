using GenericRepository.Entities;

namespace GenericRepository.Repositories.Abstractions;

public interface ITRepository<T> where T : Student, new()
{
    IQueryable<T> GetAllT(bool isTracking, params string[] includes);
}
