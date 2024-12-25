namespace GenericRepository.Entities;

public class Teacher
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public int Salary { get; set; }
    public ICollection<Group>Groups { get; set; }
}
