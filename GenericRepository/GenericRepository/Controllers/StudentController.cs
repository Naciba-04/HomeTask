using GenericRepository.Contexts;
using GenericRepository.Entities;
using GenericRepository.Services.Abstractions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Controllers;

[Route("api/[controller]")]
[ApiController]
public class StudentController(IStudentService _studentService): ControllerBase
{
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        List<Student> students = await _studentService.GetAllStudentAsync();
        return Ok(students);
    }
}
