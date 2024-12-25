using GenericRepository.Entities;
using GenericRepository.Repositories.Abstractions;
using GenericRepository.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Services.Concretes;

public class StudentService(ITRepository<Student> _studentRepository) : IStudentService
{
    public async Task<List<Student>> GetAllStudentAsync()
    {
        IQueryable<Student> queryableStudents = _studentRepository.GetAllT(false, "Group");
        List<Student>students=await queryableStudents.ToListAsync();
        return students;

    }
}
