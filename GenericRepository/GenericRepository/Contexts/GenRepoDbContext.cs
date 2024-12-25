using GenericRepository.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericRepository.Contexts;

public class GenRepoDbContext:DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Group> Groups { get; set; }
    
    public GenRepoDbContext(DbContextOptions opt) : base(opt) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
       
        base.OnModelCreating(modelBuilder);
    }
}
