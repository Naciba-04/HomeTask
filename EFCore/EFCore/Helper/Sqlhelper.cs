using EFCore.Contexts;
using EFCore.ExceptionReflection;
using EFCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Helper;

public class Sqlhelper
{
    #region 
    public void Register()
    {
        Console.WriteLine("Adinizi daxil edin");
        string name = Console.ReadLine();
        Console.WriteLine("Soyadinizi daxil edin");
        string surname = Console.ReadLine();
        Console.WriteLine("Istifadechi adinizi daxil edin");
        string username = Console.ReadLine();
        Console.WriteLine("Istifadechi parolunuzu daxil edin");
        string password = Console.ReadLine();

        using (AppDbContext sql = new AppDbContext())
        {
            sql.Users.Add(new User
            {
                Name = name,
                Surname = surname,
                Username = username,
                Password = password
            });
            sql.SaveChanges();
            Console.WriteLine("Successfully created!");
        }
    }
    List<User> users = [];
    public void Login()
    {
        Console.WriteLine("Istifadechi adinizi daxil edin");
        string username = Console.ReadLine();
        Console.WriteLine("Istifadechi parolunuzu daxil edin");
        string password = Console.ReadLine();

        using (AppDbContext sql = new AppDbContext())
        {
            users = sql.Users.ToList();
        }
        users.ForEach(u => Console.WriteLine(u.Username, u.Password));

        using (var db = new AppDbContext())
        {
            var users = db.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (users == null)
            {
                throw new UserNotFoundException("Istifadechi adi ve ya parol sehvdir.");
            }
        }
    }
    #endregion

    #region
    List<Product> products = [];
    public void ViewProducts()
    {
        Console.WriteLine("Istifadechinin Id sini daxil edin");
        int id = int.Parse(Console.ReadLine());
        

        using (AppDbContext sql = new AppDbContext())
        {
            products = sql.Products.ToList();
        }
        products.ForEach(p => Console.WriteLine($"{p.Id}. {p.Name} - {p.Price} AZN"));

        using (var db = new AppDbContext())
        {
            var product = db.Products.FirstOrDefault(p => p.Id ==id);
            if (product == null)
            {
                throw new ProductNotFoundException("Bu ID ilə məhsul tapılmadı!");
            }
            else
            {
                
                Console.WriteLine("Daxil etdiyiniz ID duzgun deyil.Duzgun ID daxil edin.");
            }
        }
    }

    public void ViewBasket()
    {

    }
    #endregion
}
