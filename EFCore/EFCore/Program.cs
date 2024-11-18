using EFCore.ExceptionReflection;
using EFCore.Helper;

namespace EFCore;

public class Program
{
    static void Main()
    {
        Sqlhelper sqlhelper = new Sqlhelper();
        #region
        Console.WriteLine("register uchun 1 duymesine,login uchun 2 duymesine basin");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Register");
                sqlhelper.Register();
                break;

            case 2:
                try
                {
                    Console.WriteLine("Login");
                    sqlhelper.Login();
                }
                catch (UserNotFoundException)
                {
                    Console.WriteLine("Istifadechi adiniz ve ya istifadechi parolunuz yanlishdir!");
                    Console.WriteLine("Yeniden sinayin!");
                    Console.ReadLine();
                }
                break;

            default:
                Console.WriteLine("Yanlis sechim etdiniz,davam etemk uchun entere clickleyin.");
                Console.ReadLine();
                break;

        }
        #endregion

        #region
        Console.WriteLine("1. Məhsullara bax");
        Console.WriteLine("2. Səbətə bax");
        Console.WriteLine("3. Hesabdan çıx");

        int click = int.Parse(Console.ReadLine());

        switch (click)
        {
            case 1:
                
                sqlhelper.ViewProducts();
                break;

            case 2:
                try
                {
                    
                    sqlhelper.ViewBasket();
                }
                catch (ProductNotFoundException)
                {
                    Console.WriteLine("Bu ID ilə məhsul tapılmadı!");
                    Console.WriteLine("Yeniden sinayin!");
                    Console.ReadLine();
                }
                break;
            case 3:
                Console.WriteLine("Hesabdan chixish edilir");
                break; 

            default:
                Console.WriteLine("Yanlis sechim etdiniz,davam etmek uchun entere clickleyin.");
                Console.ReadLine();
                break;


        }
        #endregion
    }
}