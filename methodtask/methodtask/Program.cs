//Overload Tasks
//using System;

//namespace overload
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            double circleArea = Area(5); 
//            Console.WriteLine($"Çevrenin sahesi: {circleArea}");

//            double rectangleArea = Area(4, 6); 
//            Console.WriteLine($"Düzbucaqlının sahesi: {rectangleArea}");

//            double boxArea = Area(4, 6, 8); 
//            Console.WriteLine($"Düzbucaqlı paralelipipedin tam sethinin sahesi: {boxArea}");

//            double triangleArea = Area(3, 4, 5, 2); 
//            Console.WriteLine($"Üçbucaqlının daxiline çekilmiş çevrenin sahesi: {triangleArea}");
//        }

//         static double Area(double radius)
//        {
//            double p = 3;
//            return p * (radius * radius);
//        }


//         static double Area(double length, double width)
//        {
//            return length * width;
//        }


//         static double Area(double length, double width, double height)
//        {
//            return 2 * (length * width + length * height + width * height);
//        }

//        static double Area(double sideA, double sideB, double sideC, double radius)
//        {
//            double p = (sideA + sideB + sideC) / 2;
//            return p * radius;
//        }
//    }
//}

//Task(a.b.c)
//a.Method yaradirsiz 2 eded ve 1 operator('+','-','*','/') qebul edir. Qebul etdiyi operatora uygun a v' b ədədləri üzərində hesablama aparib alinan deyeri qaytarır.
//using System;

//namespace overload
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            Console.WriteLine("İlk ededi daxil edin:");
//            double a = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("İkinci ededi daxil edin:");
//            double b = Convert.ToDouble(Console.ReadLine());

//            Console.WriteLine("Operatoru daxil edin (+, -, *, /):");
//            char operatorType = Console.ReadKey().KeyChar;

//            double result = Calculate(a, b, operatorType);
//            Console.WriteLine($"Netice: {result}");
//        }
//        static double Calculate(double a, double b, char operatorType)
//        {
//            double result = 0;

//            if (operatorType == '+')
//            {
//                result = a + b;
//            }
//            else if (operatorType == '-')
//            {
//                result = a - b;
//            }
//            else if (operatorType == '*')
//            {
//                result = a * b;
//            }
//            else if (operatorType == '/')
//            {

//                result = a / b;
//            }


//            return result;
//        }
//    }
//}

//b.Method yaradırsız əgər methoda bir eded gonderilirse hemin ededin kvadratını, iki eded gonderilirse 1ci ədədi ikinci ədəd qədər qüvvətinə yüksəldirsiz.(Misal: MyMethod(2, 3)-- > 8)
//using System;

//namespace overload
//{
//    internal class Program
//    {
//        static void Main()
//        {

//            Console.WriteLine(MyMethod(7));

//            Console.WriteLine(MyMethod(4, 3));
//        }
//        static double MyMethod(double a, double? b = null)
//        {
//            if (b.HasValue)
//            {
//                double result = 1;
//                for (int i = 0; i < b.Value; i++)
//                {
//                    result *= a;
//                }
//                return result;
//            }
//            else
//            {
//                return a * a;
//            }
//        }
//    }
//}

//c.Methodlar yaradirsiz. Methoda ad gonderende adi ekrana cixardir(Sabir), ad ve soyad gonderende soyadi adi ekrana cixardir(Guliyev Sabir)
//    , ad, soyad ve ata adı göndərildikdə adin baş hərfi nöqtə soyad ata adi ekrana cixardirsiz(S.Guliyev Mehti). Methodlarin adi eyni olmalıdır.
//using System;

//namespace overload
//{
//    internal class Program
//    {
//        static void Main()
//        {
//            PrintName("Naciba");
//            PrintName("Rasulova", "Naciba");
//            PrintName("Naciba", "Rasulova", "Elxan");
//        }
//        static void PrintName(string name)
//        {
//            Console.WriteLine(name);
//        }
//        static void PrintName(string surname, string name)
//        {
//            Console.WriteLine($"{surname} {name}");
//        }
//        static void PrintName(string name, string surname, string fatherName)
//        {
//            Console.WriteLine($"{name[0]}. {surname} {fatherName}");
//        }
//    }
//}
