using GenericRepository.Entities;

namespace GenericRepository.Services.Abstractions;

public interface IStudentService
{
    Task<List<Student>> GetAllStudentAsync();
}
