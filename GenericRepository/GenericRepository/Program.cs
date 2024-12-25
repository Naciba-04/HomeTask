
using GenericRepository.Contexts;
using GenericRepository.Entities;
using GenericRepository.Repositories.Abstractions;
using GenericRepository.Repositories.Concretes;
using GenericRepository.Services.Abstractions;
using GenericRepository.Services.Concretes;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace GenericRepository
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers().AddJsonOptions(x =>
            x.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve);
            builder.Services.AddScoped<IStudentService,StudentService>();
            builder.Services.AddScoped<ITRepository<Student>, TRepository<Student>>();

            builder.Services.AddControllers();
            builder.Services.AddDbContext<GenRepoDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString
                    ("MSSql"));
            });

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
